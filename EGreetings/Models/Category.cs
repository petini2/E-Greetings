using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EGreetings.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-incrementing CategoryId
        public int CategoryID { get; set; }

        public string? CategoryName { get; set; }

        public DateTime? CreatedDate { get; set; }

        // Validation for predefined set of values
        [RegularExpression("BD|WD|NY|LV|FE|OT", ErrorMessage = "Invalid GroupCate value.")]
        public string? GroupCate { get; set; }

        public bool Status { get; set; }
        public ICollection<Template>? Templates { get; set; }
    }

}
