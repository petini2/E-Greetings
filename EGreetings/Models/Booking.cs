using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGreetings.Models
{

    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingID { get; set; }

        public string? UserID { get; set; }  // Foreign key to User
        public int TemplateID { get; set; }

        public string? Subject { get; set; }
        public string? ReceivedEmail { get; set; }
        public DateTime? BookingDate { get; set; }
        public float? PriceTemplate { get; set; }
        public float? SubTotal { get; set; }
        public float? Discount { get; set; }
        public float? Total { get; set; }
        public string? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public float? SubcribesSub { get; set; }


        public Feedback? Feedback { get; set; }

        public ICollection<TemplateHistory> TemplateHistories { get; set; }
        public ICollection<BookingDetail> BookingDetails { get; set; }
        public User User { get; set; }
        public Template Template { get; set; }

        public Transaction Transaction { get; set; }
    }
}