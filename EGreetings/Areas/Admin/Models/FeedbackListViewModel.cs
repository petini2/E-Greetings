namespace EGreetings.Areas.Admin.Models
{
    public class FeedbackListViewModel
    {
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public int BookingId { get; set; }
        public string? TemplateName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? Comment { get; set; }
    }
}
