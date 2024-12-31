using System.ComponentModel.DataAnnotations;

namespace EGreetings.Models.ViewModelAccount
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = " Email is required")]
        [EmailAddress]
        public string? Email { get; set; }
        // Thêm thuộc tính Token để nhận token từ URL
        public string? Token { get; set; } // Thêm token cho việc reset mật khẩu

        [Required(ErrorMessage = "Password is required")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "The {0} must be at {2} and at max {1} characters.")]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        [Compare("ConfirmNewPassword", ErrorMessage = "Password does not match.")]
        public string? NewPassword { get; set; }


        [Required(ErrorMessage = " Confirm Password is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm New Password")]
        public string? ConfirmNewPassword { get; set; }
    }
}
