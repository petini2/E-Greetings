namespace EGreetings.Areas.Admin.Models
{
    public class UserTransactionListViewModel
    {
        public string? UserId { get; set; }
        public float Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string? TransactionMethod { get; set; }
        public string? TransactionStatus { get; set; }
    }
}

