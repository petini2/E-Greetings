using Microsoft.AspNetCore.Identity;


namespace EGreetings.Models
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
        public ICollection<Transaction> Transactions { get; set; }
        public ICollection<UserSub> UserSubs { get; set; }
        public ICollection<Booking> Bookings { get; set; }
        public ICollection<PayInfor> PayInfors { get; set; }
    }
}
