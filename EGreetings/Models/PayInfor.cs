using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EGreetings.Models
{
    public class PayInfor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PayID { get; set; }

        // UserID is a foreign key referencing the Id of the User table
        public string UserID { get; set; }  // Ensure it's of type string to match the Id of User

        public int? PayNumber { get; set; }
        public string? HolderName { get; set; }
        public string? PayCate { get; set; }
        public DateTime? ExpireDate { get; set; }

        // Navigation property to the User table (optional but good practice)
        public virtual User User { get; set; }  // Optional: allows navigation from PayInfor to User
    }
}
