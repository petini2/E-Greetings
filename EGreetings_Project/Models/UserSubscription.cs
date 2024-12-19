using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGreetings_Project.Models {
  public class UserSubscription {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UserSubscriptionId { get; set; }
    public string? UserId { get; set; }
    public int SubscriptionId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Quantity { get; set; }
    public bool IsActive { get; set; }
    public string? Template1 { get; set; }
    public string? Template2 { get; set; }
    public string? Template3 { get; set; }
  }
}


