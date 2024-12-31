using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGreetings.Models
{
    public class UserSub
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserSubID { get; set; }

        // Foreign Key to the User table (IdentityUser)
        [ForeignKey("User")]
        public string UserID { get; set; }

        // Navigation property for User
        public virtual User User { get; set; }

        // Foreign Key to the Subscription table
        [ForeignKey("Subscription")]
        public int SubscriptionID { get; set; }

        // Navigation property for Subscription
        public virtual Subscription Subscription { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Quantity { get; set; }
        public bool isActive { get; set; }
        public int? Template1 { get; set; }
        public int? Template2 { get; set; }
        public int? Template3 { get; set; }
    }
}
