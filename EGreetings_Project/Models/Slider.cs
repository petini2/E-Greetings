using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGreetings_Project.Models {
  public class Slider {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SliderId { get; set; }
    public string? SliderImage { get; set; }
    public string? SliderTitle { get; set; }
    public string? SliderContent { get; set; }
    public bool IsActive { get; set; }
  }
}
