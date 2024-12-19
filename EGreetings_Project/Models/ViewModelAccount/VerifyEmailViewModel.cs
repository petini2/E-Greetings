using System.ComponentModel.DataAnnotations;

namespace EGreetings_Project.Models.ViewModelAccount
{
    public class VerifyEmailViewModel
    {
        [Required(ErrorMessage = " Email is required")]
        [EmailAddress]
        public string? Email { get; set; }
    }
}
