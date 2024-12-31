using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGreetings.Models
{
    public class Feedback
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FeedbackID { get; set; }

        public int BookingID { get; set; }  // Foreign Key to Booking

        public string? Comment { get; set; }
        public DateTime CreatedDate { get; set; }

        // Define the relationship with Booking (One-to-One)
        public Booking Booking { get; set; }  // Feedback has one Booking
    }
}
