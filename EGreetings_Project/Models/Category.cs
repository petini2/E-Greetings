using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGreetings_Project.Models {
public class Category
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-incrementing CategoryId
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public string? CreatedDate { get; set; }

    // Validation for predefined set of values
    [RegularExpression("BD|WD|NY|LV|FE|OT", ErrorMessage = "Invalid GroupCate value.")]
    public string? GroupCate { get; set; }

    public bool Status { get; set; }
}
}
