namespace EGreetings.Models.ViewModelAccount
{
    public class BookingFeedback
    {
        public int BookingID { get; set; }
        public string? Comment { get; set; }
        public float? Total { get; set; }
        public string? Status { get; set; }
        public DateTime? BookingDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public List<string>? Templates { get; set; }
    }
}
