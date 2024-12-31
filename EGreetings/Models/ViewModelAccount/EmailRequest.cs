namespace EGreetings.Models.ViewModelAccount
{
    public class EmailRequest
    {
        public string RecipientEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime SendDate { get; set; }  // Send date
    }
}
