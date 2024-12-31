

using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EGreetings.Models
{

    public class Template
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TemplatesID { get; set; }
        [JsonProperty("id")]
        public string? TemplateName { get; set; }

        // Foreign Key to Category
        public int CategoryID { get; set; }

        public string? Description { get; set; }
        public float? Price { get; set; }
        public float? Discount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool Status { get; set; }
        public string? ImgVer { get; set; }
        public string? ImgHoz { get; set; }
        public string? SvgVer { get; set; }
        public string? SvgHoz { get; set; }

        // Navigation property to Category
        [ForeignKey("CategoryID")]
        public virtual Category? Category { get; set; }
        public ICollection<TemplateHistory>? TemplateHistories { get; set; }
        public ICollection<Booking>? Bookings { get; set; }
    }
}
