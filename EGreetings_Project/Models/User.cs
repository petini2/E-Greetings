using Microsoft.AspNetCore.Identity;

namespace EGreetings_Project.Models
{
    public class User : IdentityUser
    {
        // User Infor
        public DateTime Dob { get; set; }
        public bool Gender { get; set; }
        public bool isSubscribed { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public DateTime CreatedDate { get; set; }

        // Time send email confirm and token reset password 
        public DateTime? EmailConfirmationSentDate { get; set; }
        public DateTime? TokenResetPasswordCreatedDate { get; set; }

        // Avatar user
        public string Image { get; set; } 
    }
}
