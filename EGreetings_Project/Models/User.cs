using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace EGreetings_Project.Models
{
    public class User : IdentityUser
    {
        public DateTime Dob { get; set; }

        
        public string? Gender { get; set; }

        public bool isSubscribed { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public DateTime CreatedDate { get; set; }

        public DateTime? EmailConfirmationSentDate { get; set; }
        public DateTime? TokenResetPasswordCreatedDate { get; set; }

        public string? imgAvatar { get; set; }
    }
}
