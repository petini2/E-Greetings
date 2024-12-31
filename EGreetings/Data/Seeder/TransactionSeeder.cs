namespace EGreetings.Data.Seeder
{
    public class TransactionSeeder
    {
        public static void Seed(EGreetingsDbContext dbContext)
        {
            //if (!dbContext.Transactions.Any()) // Nếu không có dữ liệu trong bảng Bookings, ta mới tiến hành seeding
            //{
            //    var transactions = new Transaction[]
            //{
            //    new Transaction
            //    {
            //        UserID = "028b357b-a576-4594-ae1f-526bb2d7bda6",
            //        BookingID = 20,
            //        Amount = 1000,
            //        TransactionDate = DateTime.Parse("2024-12-23"),
            //        TransactionMethods = "Paypal",
            //        CreatedDate = DateTime.Parse("2024-12-23")
            //    }
            //};

            //    // Thêm các transaction vào DbContext
            //    dbContext.Transactions.AddRange(transactions);

            //    // Lưu các thay đổi vào cơ sở dữ liệu
            //    dbContext.SaveChanges();
            //}
        }
    }
}
