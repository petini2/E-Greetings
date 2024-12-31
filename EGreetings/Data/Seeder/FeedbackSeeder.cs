namespace EGreetings.Data.Seeder
{
    public class FeedbackSeeder
    {
        public static void Seed(EGreetingsDbContext dbContext)
        {
            //if (!dbContext.Feedbacks.Any()) // Nếu không có dữ liệu trong bảng Bookings, ta mới tiến hành seeding
            //{
            //    var feedbacks = new Feedback[]
            //{
            //    new Feedback
            //    {
            //        BookingID = 20,
            //        Comment = "My friends extremely happy when they receive the email",
            //        CreatedDate = DateTime.Parse("2024-12-21")
            //    }
            //};

            //    // Thêm các feedback vào DbContext
            //    dbContext.Feedbacks.AddRange(feedbacks);

            //    // Lưu các thay đổi vào cơ sở dữ liệu
            //    dbContext.SaveChanges();
            //}
        }
    }
}
