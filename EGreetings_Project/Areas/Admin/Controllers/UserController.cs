using EGreetings_Project.Data;
using EGreetings_Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EGreetings_Project.Areas.Admin.Models;

namespace EGreetings_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly EGreetingsDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly UserManager<User> _userManager;

        public UserController(EGreetingsDbContext context, IWebHostEnvironment hostEnvironment, UserManager<User> userManager)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index() {
          var users = await _context.Users
                                    .Where(itemUser => itemUser.UserName != "Admin")
                                    .ToListAsync();
    
          return View(users);
        }


        public async Task<IActionResult> UserSubscriptionList(string userId, string userName) {
          var records = await _context.UserSubscriptions
                                      .Join(_context.Subscriptions,
                                            itemUser => itemUser.SubscriptionId,
                                            itemSubscription => itemSubscription.SubscriptionID,
                                            (itemUser, itemSubscription) => new UserSubscriptionListViewModel {
                                              UserId = itemUser.UserId,
                                              SubName = itemSubscription.SubName,
                                              StartDate = itemUser.StartDate,
                                              EndDate = itemUser.EndDate
                                            })
                                      .Where(item => item.UserId == userId)
                                      .ToListAsync();
          ViewData["UserName"] = userName;
          return View(records);
        }


        public async Task<IActionResult> UserTransactionList(string userId, string userName) {
          var records = await _context.Transactions
                                      .Join(_context.Users,
                                            itemTransaction => itemTransaction.UserId,
                                            itemUser => itemUser.Id,
                                            (itemTransaction, itemUser) => new UserTransactionListViewModel {
                                              UserId = itemUser.Id,
                                              Amount = itemTransaction.Amount,
                                              TransactionDate = itemTransaction.TransactionDate,
                                              TransactionMethods = itemTransaction.TransactionMethods,
                                              TransactionStatus = itemTransaction.TransactionStatus
                                            })
                                      .Where(item => item.UserId == userId)
                                      .ToListAsync();
          ViewData["UserName"] = userName;
          return View(records);
        }


        public async Task<IActionResult> UserFeedbackList(string userId, string userName) {
          var records = await _context.Feedbacks
                                      .Join(_context.Bookings,
                                            itemFeedback => itemFeedback.BookingId,
                                            itemBooking => itemBooking.BookingId,
                                            (itemFeedback, itemBooking) => new UserFeedbackListViewModel {
                                              UserId = itemBooking.UserId,
                                              Suject = itemBooking.Subject,
                                              ReceivedEmail = itemBooking.ReceivedEmail,
                                              Comment = itemFeedback.Comment,
                                              CreatedDate = itemFeedback.CreatedDate
                                            })
                                      .Where(item => item.UserId == userId)
                                      .ToListAsync();
          ViewData["UserName"] = userName;
          return View(records);
        }


    }
}
