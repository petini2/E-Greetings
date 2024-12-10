﻿using EGreetings_Project.Models;
using EGreetings_Project.Models.ViewModelAccount;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Security.Claims;

namespace EGreetings_Project.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;
        private readonly IEmailSender emailSender;

        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager, IEmailSender emailSender)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.emailSender = emailSender;
        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Tìm người dùng theo email
                    var user = await userManager.FindByEmailAsync(model.Email);

                    if (user == null)
                    {
                        ModelState.AddModelError("", "Email or password is incorrect.");
                        return View(model);
                    }

                    // Kiểm tra xem người dùng đã xác nhận email chưa
                    if (!user.EmailConfirmed)
                    {
                        if (user.EmailConfirmationSentDate.HasValue &&
                            (DateTime.Now - user.EmailConfirmationSentDate.Value).TotalHours > 24)  // token hết hạn sau 24 giờ
                        {
                            var code = await userManager.GenerateEmailConfirmationTokenAsync(user);
                            var callbackUrl = Url.Action(
                                "ConfirmEmail",
                                "Account",
                                new { userId = user.Id, code = code },
                                protocol: Request.Scheme
                            );

                            var emailSent = await SendConfirmationEmail(user.Email, callbackUrl);
                            if (emailSent)
                            {
                                user.EmailConfirmationSentDate = DateTime.Now;
                                await userManager.UpdateAsync(user);
                                return RedirectToAction("ResendMailConfirm", "Account");
                            }
                            else
                            {
                                ModelState.AddModelError("", "There was an error sending the confirmation email.");
                                return View(model);
                            }
                        }
                        else
                        {
                            return RedirectToAction("Notifications", "Account");
                        }
                    }

                    // Kiểm tra mật khẩu người dùng
                    var result = await signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);

                    if (result.Succeeded)
                    {
                        var imageUrl = string.IsNullOrEmpty(user.Image) ? "/images/user/default-image.jpg" : user.Image;  // If no image, use the default image

                        // Create claims
                        var claims = new List<Claim>
{
    new Claim(ClaimTypes.Name, user.UserName),
    new Claim(ClaimTypes.Email, user.Email),
    new Claim("Image", imageUrl) // Store the image URL in the claim
};

                        // Create ClaimsIdentity and add Cookie Authentication
                        var claimsIdentity = new ClaimsIdentity(claims, "Login");
                        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                        // Signin Account and store claims
                        await HttpContext.SignInAsync(claimsPrincipal);


                        // Check user role
                        var isAdmin = await userManager.IsInRoleAsync(user, "Admin");
                        if (isAdmin)
                        {
                            return RedirectToAction("Privacy", "Home");
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home");
                        }
                    }
                    else
                    {
                        if (result.IsLockedOut)
                        {
                            ModelState.AddModelError("", "Your account is locked. Please try again later.");
                        }
                        else if (result.IsNotAllowed)
                        {
                            ModelState.AddModelError("", "You need to confirm your email address before you can log in.");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Email or password is incorrect.");
                        }
                        return View(model);
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "An unexpected error occurred: " + ex.Message);
                    return View(model);
                }
            }

            return View(model);
        }



        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Kiểm tra xem email đã tồn tại trong cơ sở dữ liệu chưa
                var existingUser = await userManager.FindByEmailAsync(model.Email);
                if (existingUser != null)
                {
                    ModelState.AddModelError("", "Account with this email already exists!");
                    return View(model);
                }

                var user = new User
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    Gender = model.Gender,
                    PhoneNumber = model.Phone,
                    Dob = model.Dob,
                    CreatedDate = DateTime.Now,
                };

                // Check and upload image
                if (model.Image != null && model.Image.Length > 0)
                {

                    var directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "user");
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);  // Create folder if it isn't exist
                    }

                    // Create name file to prevent duplicate 
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(model.Image.FileName);
                    var filePath = Path.Combine(directoryPath, fileName);

                    // Store image to  folder images/user
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await model.Image.CopyToAsync(stream);
                    }


                    user.Image = "/images/user/" + fileName;
                }

                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    var roleResult = await userManager.AddToRoleAsync(user, "User");
                    if (!roleResult.Succeeded)
                    {
                        foreach (var error in roleResult.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                        return View(model);
                    }

                    // Lưu thời gian gửi email xác nhận
                    user.EmailConfirmationSentDate = DateTime.Now;
                    await userManager.UpdateAsync(user);

                    var code = await userManager.GenerateEmailConfirmationTokenAsync(user);

                    var callbackUrl = Url.Action(
                        "ConfirmEmail",
                        "Account",
                        new { userId = user.Id, code = code },
                        protocol: Request.Scheme
                    );

                    var emailSent = await SendConfirmationEmail(model.Email, callbackUrl);
                    if (emailSent)
                    {
                        return RedirectToAction("RegistrationConfirmation", "Account");
                    }
                    else
                    {
                        ModelState.AddModelError("", "There was an error sending the confirmation email.");
                        return View(model);
                    }
                }
                else
                {
                    // Nếu có lỗi khi tạo người dùng, thông báo lỗi
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }

            return View(model);
        }



        // Method to Send Confirmation Form to Email
        private async Task<bool> SendConfirmationEmail(string email, string callbackUrl)
        {
            try
            {

                string htmlContent = $@"
        <html>
        <head>
            <style>
                /* CSS for email */
                body {{
                    font-family: Arial, sans-serif;
                }}
                .container {{
                    max-width: 600px;
                    margin: 0 auto;
                    padding: 20px;
                }}
                .card {{
                    border: 1px solid #ddd; /* Viền xám */
                    border-radius: 8px;
                    padding: 20px;
                    background-color: #ffffff; /* Màu nền trắng */
                }}
                .card-header {{
                    text-align: center;
                    font-size: 24px;
                    font-weight: bold;
                    color: #333;
                }}
                .card-body {{
                    padding: 20px;
                }}
                .btn {{
                    display: inline-block;
                    padding: 0px 30px;
                    height: 55px;
                    background-color: #070d0c;
                    color: #f7f7f5;
                    text-decoration: none;
                    font-size: 16px;
                    border-radius: 5px;
                    text-align: center;
                    text-decoration: none;
                
                }}
                .btn:hover {{
                    background-color: #070d0c;
                }}
                .footer {{
                    text-align: center;
                    font-size: 12px;
                    color: #888;
                    margin-top: 20px;
                }}
            </style>
        </head>
        <body>
            <div class='container'>
                <div class='card'>
                    <div class='card-header'>
                        Confirm Your Email
                    </div>
                    <div class='card-body'>
                        <p>Thank you for registering with us. Please confirm your email address by clicking the link below:</p>
                        <div style='text-align: center;'>
                            <a href='{callbackUrl}' class='btn'><p style='color:  #f7f7f5'>Click here</p></a>
                        </div>
                        <p>If you did not register, please ignore this email.</p>
                    </div>
                    <div class='footer'>
                        <small>&copy; 2024 Your Company. All rights reserved.</small>
                    </div>
                </div>
            </div>
        </body>
        </html>";

                // Gửi email
                await emailSender.SendEmailAsync(email, "Confirm your email", htmlContent);
                return true;
            }
            catch (Exception ex)
            {
                // Log lỗi nếu có vấn đề trong quá trình gửi email
                // _logger.LogError(ex, "Error sending email.");
                return false;
            }
        }




        public IActionResult RegistrationConfirmation()
        {
            return View();
        }

        public IActionResult VerifyEmail()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> VerifyEmail(VerifyEmailViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(model.Email); // Tìm người dùng theo email
                if (user == null)
                {
                    ModelState.AddModelError("", "Email không tồn tại.");
                    return View(model);
                }

                // Tạo token reset mật khẩu
                var token = await userManager.GeneratePasswordResetTokenAsync(user);

                // Tạo thời gian tạo token
                var tokenCreationTime = DateTime.Now;
                user.TokenResetPasswordCreatedDate = tokenCreationTime; // Lưu thời gian tạo token

                // Lưu vào cơ sở dữ liệu (nếu cần)
                await userManager.UpdateAsync(user);

                // Tạo URL để người dùng reset mật khẩu (chứa token)
                var resetUrl = Url.Action("ChangePassword", "Account", new { token = token, email = model.Email }, Request.Scheme);

                // Gửi email với liên kết reset mật khẩu
                var subject = "Reset your password";
                var body = $"Click here to reset your password: <a href='{resetUrl}'>Reset Password</a>";

                // Giả sử bạn đã có phương thức gửi email:
                await emailSender.SendEmailAsync(model.Email, subject, body);

                return RedirectToAction("CheckEmail");
            }

            return View(model);
        }
        public IActionResult CheckEmail()
        {
            return View();
        }

        public async Task<IActionResult> ChangePassword(string email, string token)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(token))
            {
                return RedirectToAction("VerifyEmail", "Account");
            }

            // Kiểm tra thời gian token được tạo (token sống trong 1 giờ)
            var user = await userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return RedirectToAction("VerifyEmail", "Account");
            }

            // Kiểm tra thời gian tạo token
            if (user.TokenResetPasswordCreatedDate == null ||
                (DateTime.UtcNow - user.TokenResetPasswordCreatedDate.Value).TotalHours > 1)
            {
                // Token hết hạn, tạo lại token mới và gửi email
                var newToken = userManager.GeneratePasswordResetTokenAsync(user).Result;
                var resetUrl = Url.Action("ChangePassword", "Account", new { token = newToken, email = email }, Request.Scheme);
                emailSender.SendEmailAsync(email, "Reset your password", $"Your reset link has expired. Click here to reset your password: {resetUrl}");
                return RedirectToAction("CheckEmail"); // Thông báo cho người dùng kiểm tra lại email
            }

            return View(new ChangePasswordViewModel { Email = email, Token = token });
        }



        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Tìm người dùng theo email
                var user = await userManager.FindByEmailAsync(model.Email);
                if (user == null)
                {
                    ModelState.AddModelError("", "Email không hợp lệ.");
                    return View(model);
                }

                // Kiểm tra token reset mật khẩu có hợp lệ không
                var result = await userManager.ResetPasswordAsync(user, model.Token, model.NewPassword);

                if (result.Succeeded)
                {
                    // Nếu đổi mật khẩu thành công, chuyển hướng đến trang đăng nhập
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(model);
                }
            }

            ModelState.AddModelError("", "Có lỗi xảy ra. Vui lòng thử lại!");
            return View(model);
        }



        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            //await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index", "Home");
        }


        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var result = await userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
            {
                return View("ConfirmEmail");
            }
            return RedirectToAction("Login", "Account");
        }


        public IActionResult ResendConfirmationEmail()
        {
            return View();
        }
    }
}
