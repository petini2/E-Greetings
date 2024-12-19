using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGreetings_Project.Models
{
    public class Template
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TemplateId { get; set; }
        public string? TemplateName { get; set; }
        public int CategoryId { get; set; }
        public string? ImgVer { get; set; }
        public string? ImgHoz { get; set; }
        public string? SvgVer { get; set; }
        public string? SvgHoz { get; set; }
        public float Price { get; set; }
        public float Discounts { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
        public string? Description { get; set; }
    }
}

