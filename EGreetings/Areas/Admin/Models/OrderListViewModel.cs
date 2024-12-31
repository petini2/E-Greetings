namespace EGreetings.Areas.Admin.Models
{
    public class OrderListViewModel
    {
        public int BookingId { get; set; }
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public DateTime CreatedDate { get; set; }
        public float Total { get; set; }
        public string? Status { get; set; }
    }
}
