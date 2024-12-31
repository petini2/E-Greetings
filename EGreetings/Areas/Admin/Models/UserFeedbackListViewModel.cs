namespace EGreetings.Areas.Admin.Models
{
    public class UserFeedbackListViewModel
    {
        public string? UserId { get; set; }
        public string? Suject { get; set; }
        public string? ReceivedEmail { get; set; }
        public string? Comment { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

