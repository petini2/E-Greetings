using EGreetings.Data;
using EGreetings.Models;
using EGreetings.Models.ViewModelAccount;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EGreetings.Controllers
{
    public class UserController : Controller
    {
        private readonly EGreetingsDbContext _context;
        private readonly UserManager<User> userManager;
        private readonly IWebHostEnvironment env;
        public UserController(EGreetingsDbContext context, UserManager<User> userManager, IWebHostEnvironment env)
        {
            this.env = env;
            _context = context;
            this.userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            //Get User Id from cookie
            string userId = Request.Cookies["UserID"];
            if (userId != null)
            {
                //Find user
                var user = await userManager.FindByIdAsync(userId);
                //Find user's available send time
                List<UserSub> sub = await _context.UserSubs.Where(x => x.UserID == userId).ToListAsync();
                int sends = 0;
                bool basic = false;
                bool standard = false;
                bool premium = false;
                foreach (var subItem in sub)
                {
                    Subscription subData = await _context.Subscriptions.FirstOrDefaultAsync(x => x.SubscriptionID == subItem.SubscriptionID);
                    if (subData != null && subData.SubCate == "Sends")
                    {
                        sends += (int)subData.Quantity;
                    }
                    if (subData.SubName == "Basic Plan")
                    {
                        basic = true;
                    }
                    else if (subData.SubName == "Standard Plan")
                    {
                        standard = true;
                    }
                    else if (subData.SubName == "Premium Plan")
                    {
                        premium = true;
                    }
                }
                EditProfileModel userInfo = new EditProfileModel
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Email = user.Email,
                    Phone = user.PhoneNumber,
                    Dob = user.Dob,
                    imgAvatar = user.imgAvatar,
                    sendTimes = sends,
                    useBasic = basic,
                    useStandard = standard,
                    usePremium = premium,
                };
                return View(userInfo);
            }
            else
            {
                //Ask to login
                return RedirectToAction("Login", "Account");
            }
        }
        public async Task<IActionResult> Edit(string id)
        {
            //Find user
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            //Add user detail to view model 
            var editUser = new EditProfileModel
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                Phone = user.PhoneNumber,
                Dob = user.Dob,
                imgAvatar = user.imgAvatar,
            };
            return View(editUser);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditProfileModel model)
        {
            //Check validation
            if (string.IsNullOrEmpty(model.UserName))
            {
                ModelState.AddModelError("UserName", "Username is required.");
            }
            if (model.UserName?.Length < 3 || model.UserName?.Length > 50)
            {
                ModelState.AddModelError("UserName", "It is between 3 and 50 characters long.");
            }
            if (model.Phone?.Length < 10 || model.Phone?.Length > 12)
            {
                ModelState.AddModelError("Phone", "It is between 10 and 12 digits");
            }
            var existedUser = await _context.Users.FindAsync(model.Id);

            //Check UserName is updated
            if (!string.IsNullOrWhiteSpace(model.UserName))
            {
                existedUser.UserName = model.UserName;
            }
            //Check Email is updated
            if (!string.IsNullOrWhiteSpace(model.Email))
            {
                existedUser.Email = model.Email;
            }
            //Check Phone is updated
            if (!string.IsNullOrWhiteSpace(model.Phone))
            {
                existedUser.PhoneNumber = model.Phone;
            }
            //Check Dob is updated
            if (!string.IsNullOrWhiteSpace(model.Dob.Value.ToString("yyyy-MM-dd")))
            {
                existedUser.Dob = model.Dob.GetValueOrDefault();
            }
            //Handle new avatar
            if (model.newAvatar != null && model.newAvatar.Length > 0)
            {
                if (!model.newAvatar.ContentType.StartsWith("image/"))
                {
                    return Content("Please upload image only!");
                }
                var uploadFolder = Path.Combine(env.WebRootPath, "images/useravarta");
                if (!Directory.Exists(uploadFolder))
                {
                    Directory.CreateDirectory(uploadFolder);
                }
                string imgFilename = Guid.NewGuid().ToString() + Path.GetExtension(model.newAvatar.FileName);
                string imgPathname = Path.Combine(uploadFolder, imgFilename);
                using (var stream = new FileStream(imgPathname, FileMode.Create))
                {
                    await model.newAvatar.CopyToAsync(stream);
                }
                string avatarFileName = Path.Combine("images/useravarta", imgFilename);
                existedUser.imgAvatar = avatarFileName;
                //Delete old avatar cookie
                Response.Cookies.Delete("UserAvatar");

                //Update new avatar cookie
                Response.Cookies.Append("UserAvatar", existedUser.imgAvatar, new CookieOptions
                {
                    Expires = DateTimeOffset.Now.AddDays(7), // Đặt thời gian hết hạn cho cookie
                    HttpOnly = false,  // Chỉ có thể truy cập từ phía server
                    Secure = true,    // Chỉ gửi qua HTTPS
                    SameSite = SameSiteMode.None  // Cài đặt SameSite cho cookie
                });
            }

            //Update user's data
            _context.Update(existedUser);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
