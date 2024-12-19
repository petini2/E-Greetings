using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGreetings_Project.Models {
  public class Booking {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BookingId { get; set; }
    public string? UserId { get; set; }
    public int TemplateId { get; set; }
    public string? Subject { get; set; }
    public string? ReceivedEmail { get; set; }
    public DateTime BookingDate { get; set; }
    public float PriceTemplate { get; set; }
    public float SubTotal { get; set; }
    public float Discount { get; set; }
    public float Total { get; set; }
    public bool Status { get; set; }
    public DateTime CreatedDate { get; set; }
  }
}
