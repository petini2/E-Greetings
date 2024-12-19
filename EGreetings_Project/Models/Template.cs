namespace EGreetings_Project.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

        public class Template
        {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TemplatesID { get; set; }

            public string? TemplateName { get; set; }

            public int CategoryID { get; set; }

            public string? Description { get; set; }

            public float? Price { get; set; }

            public float? Discount { get; set; }

            public DateTime? CreatedDate { get; set; }

            public bool Status { get; set; }

            public string? ImgVer { get; set; }

            public string? ImgHoz { get; set; }

            public string? SVGVer { get; set; }

            public string? SVGHoz { get; set; }
            public Category Category { get; set; }
    }
    }


