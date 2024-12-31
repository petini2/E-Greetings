namespace EGreetings.Areas.Admin.Models
{
    public class UsersDetailViewModel
    {
        public int SubscriptionId { get; set; }
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int Quantity { get; set; }
        public bool IsActive { get; set; }
    }
}
