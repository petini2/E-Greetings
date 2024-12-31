using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGreetings.Models
{
    public class TemplateHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VersionID { get; set; }

        public int TemplateID { get; set; }  // Foreign key to Template
        public int BookingID { get; set; }   // Foreign key to Booking
        public string? SvgUrl { get; set; }
        public string? VideoUrl { get; set; }
        public bool? TemplateStatus { get; set; }
        public DateTime? CreatedDate { get; set; }

        // Navigation properties
        public virtual Template Template { get; set; }   // Navigation to Template
        public virtual Booking Booking { get; set; }    // Navigation to Booking
    }
}
