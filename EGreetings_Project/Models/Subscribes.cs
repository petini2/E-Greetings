using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EGreetings_Project.Models
{
    public class Subscribes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubscriptionID { get; set; }
        public string? SubName { get; set; }
        public string? SubCate { get; set; }
        public float? Price { get; set; }
        
        public int? Quantity { get; set; }
        public bool? isActive { get; set; }

    }
}
