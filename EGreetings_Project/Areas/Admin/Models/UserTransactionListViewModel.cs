namespace EGreetings_Project.Areas.Admin.Models {
  public class UserTransactionListViewModel {
    public string? UserId { get; set; }
    public float Amount { get; set; }
    public DateTime TransactionDate { get; set; }
    public string? TransactionMethods { get; set; }
    public string? TransactionStatus { get; set; }
  }
}

