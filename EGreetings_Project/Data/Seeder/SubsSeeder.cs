using EGreetings_Project.Models;

namespace EGreetings_Project.Data.Seeder
{
    public class SubsSeeder
    {
        public static void Seed(EGreetingsDbContext context)
        {
            // Kiểm tra xem bảng Subscribes đã có dữ liệu hay chưa
            if (!context.Subscriptions.Any())
            {
                context.Subscriptions.AddRange(
                    new Subscribes
                    {
                       
                        SubName = "Basic Plan",
                        SubCate = "Monthly",
                        Price = 79f,
                        Quantity = 10,

                    },
                    new Subscribes
                    {
                        
                        SubName = "Standard Plan",
                        SubCate = "Monthly",
                        Price = 99f,
                        Quantity = 15,

                    },
                    new Subscribes
                    {
                       
                        SubName = "Premium Plan",
                        SubCate = "Monthly",
                        Price = 119f,
                        Quantity = 20,

                    },
                     new Subscribes
                     {
                         
                         SubName = "Combo 10 Templates",
                         SubCate = "Birthday",
                         Price = 9.99f,
                         Quantity=10,


                     },
                    new Subscribes
                    {
                       
                        SubName = "Combo 10 Templates",
                        SubCate = "Wedding",
                        Price = 9.99f,
                        Quantity =10,

                    },
                    new Subscribes
                    {

                        SubName = "Combo 10 Templates",
                        SubCate = "Love",
                        Price = 9.99f,
                        Quantity =10,

                    },
                        new Subscribes
                        {

                            SubName = "Combo 10 Templates",
                            SubCate = "New Year",
                            Price = 9.99f,
                            Quantity =10,

                        },
                        new Subscribes
                        {

                            SubName = "Combo 10 Templates",
                            SubCate = "Festivals",
                            Price = 9.99f,
                            Quantity =10,
                        },
                        new Subscribes
                        {

                            SubName = "Combo 10 Templates",
                            SubCate = "Others",
                            Price = 9.99f,
                            Quantity = 10,
                        }

                        ,
                            new Subscribes
                            {

                                SubName = "Combo 10 Sends",
                                SubCate = "Sends",
                                Price = 4.99f,
                                Quantity = 10,


                            },
                            new Subscribes
                            {

                                SubName = "Combo 15 Sends",
                                SubCate = "Sends",
                                Price = 6.99f,
                                Quantity = 15,
                            },
                            new Subscribes
                            {

                                SubName = "Combo 20 Sends",
                                SubCate = "Sends",
                                Price = 8.99f,
                                Quantity=20,
                            }
                );

                context.SaveChanges();
            }
        }
    
    }

}
