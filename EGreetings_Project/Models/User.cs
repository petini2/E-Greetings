using Microsoft.AspNetCore.Identity;

namespace EGreetings_Project.Models
{
    public class User:IdentityUser
    {

        public DateTime Dob {  get; set; }

        public bool Gender { get; set; }

        public bool isSubscribed { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public DateTime CreatedDate { get; set; }
        //Store time to handle the time for token
        public DateTime? EmailConfirmationSentDate { get; set; }
        public DateTime? TokenResetPasswordCreatedDate { get; set; }
    }
}
