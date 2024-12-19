using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGreetings_Project.Models {
  public class Feedback {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int FeedbackId { get; set; }
    public int BookingId { get; set; }
    public string? Comment { get; set; }
    public DateTime CreatedDate { get; set; }
   }
}
