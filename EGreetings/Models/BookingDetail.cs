using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGreetings.Models
{
    public class BookingDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetailID { get; set; }


        public int BookingID { get; set; }


        public string? RecipientEmail { get; set; }
        public string? RecipientName { get; set; }
        public DateTime? CreatedDate { get; set; }


        public Booking Booking { get; set; }
    }
}
