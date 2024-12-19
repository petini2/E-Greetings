using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGreetings_Project.Models {
  public class Transaction {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TransactionId { get; set; }
    public string? UserId { get; set; }
    public int BookingId { get; set; }
    public float Amount { get; set; }
    public DateTime TransactionDate { get; set; }
    public string? TransactionMethods { get; set; }
    public string? TransactionStatus { get; set; }
    public DateTime CreatedDate { get; set; }
  }
}
