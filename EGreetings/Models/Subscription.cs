using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGreetings.Models
{
    public class Subscription
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubscriptionID { get; set; }
        public string? SubName { get; set; }
        public string? SubCate { get; set; }
        public float? Price { get; set; }

        public int? Quantity { get; set; }
        public bool? isActive { get; set; }
        public ICollection<UserSub> UserSubs { get; set; }

    }
}
