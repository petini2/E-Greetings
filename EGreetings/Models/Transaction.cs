using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGreetings.Models
{
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionID { get; set; }

        public string? UserID { get; set; }
        public int BookingID { get; set; }
        public float Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string? TransactionMethods { get; set; }
        public string? TransactionStatus { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual User User { get; set; }
        public Booking Booking { get; set; }
    }

}
