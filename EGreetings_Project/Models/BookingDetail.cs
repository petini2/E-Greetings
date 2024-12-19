using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGreetings_Project.Models {
  public class BookingDetail {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DetailId { get; set; }
    public int BookingId { get; set; }
    public string? RecipientEmail { get; set; }
    public string? RecipientName { get; set; }
    public DateTime CreatedDate { get; set; }
  }
}
