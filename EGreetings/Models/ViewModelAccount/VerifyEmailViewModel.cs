using System.ComponentModel.DataAnnotations;

namespace EGreetings.Models.ViewModelAccount
{
    public class VerifyEmailViewModel
    {
        [Required(ErrorMessage = " Email is required")]
        [EmailAddress]
        public string? Email { get; set; }
    }
}
