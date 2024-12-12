using System.ComponentModel.DataAnnotations;
//using Microsoft.AspNetCore.Http;

namespace EGreetings_Project.Models.ViewModelAccount
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Username is required!")]
        [Display(Name = "Username")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Display(Name = "Email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Phone is required!")]
        [Phone(ErrorMessage = "Invalid phone number")]
        [Display(Name = "Phone")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Gender is required!")]
        [Display(Name = "Gender")]
        public bool Gender { get; set; }

        [Required(ErrorMessage = "Date of birth is required!")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [StringLength(100, ErrorMessage = "Password must be at least 6 characters long.", MinimumLength = 6)]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required!")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string? ConfirmPassword { get; set; }

        // Use IFormFile to handle file uploads for the Avatar image
        [Display(Name = "Avatar Image")]
        public IFormFile? imgAvatar { get; set; }
    }
}
