using EGreetings.Areas.Admin.Models;
using EGreetings.Data;
using EGreetings.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EGreetings.Areas.Admin.Controllers
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

        public async Task<IActionResult> Index()
        {
            var users = await _context.Users
                                      .Where(itemUser => itemUser.UserName != "Admin")
                                      .ToListAsync();

            return View(users);
        }


        public async Task<IActionResult> UserSubscriptionList(string userId, string userName)
        {
            var records = await _context.UserSubs
                                        .Join(_context.Subscriptions,
                                              itemUser => itemUser.SubscriptionID,
                                              itemSubscription => itemSubscription.SubscriptionID,
                                              (itemUser, itemSubscription) => new UserSubscriptionListViewModel
                                              {
                                                  UserId = itemUser.UserID,
                                                  SubName = itemSubscription.SubName,
                                                  StartDate = itemUser.StartDate,
                                                  EndDate = itemUser.EndDate
                                              })
                                        .Where(item => item.UserId == userId)
                                        .ToListAsync();
            ViewData["UserName"] = userName;
            return View(records);
        }


        public async Task<IActionResult> UserTransactionList(string userId, string userName)
        {
            var records = await _context.Transactions
                                        .Join(_context.Users,
                                              itemTransaction => itemTransaction.UserID,
                                              itemUser => itemUser.Id,
                                              (itemTransaction, itemUser) => new UserTransactionListViewModel
                                              {
                                                  UserId = itemUser.Id,
                                                  Amount = itemTransaction.Amount,
                                                  TransactionDate = itemTransaction.TransactionDate,
                                                  TransactionMethod = itemTransaction.TransactionMethods,
                                                  TransactionStatus = itemTransaction.TransactionStatus
                                              })
                                        .Where(item => item.UserId == userId)
                                        .ToListAsync();
            ViewData["UserName"] = userName;
            return View(records);
        }


        public async Task<IActionResult> UserFeedbackList(string userId, string userName)
        {
            var records = await _context.Feedbacks
                                        .Join(_context.Bookings,
                                              itemFeedback => itemFeedback.BookingID,
                                              itemBooking => itemBooking.BookingID,
                                              (itemFeedback, itemBooking) => new UserFeedbackListViewModel
                                              {
                                                  UserId = itemBooking.UserID,
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


        public async Task<IActionResult> OrderList()
        {
            var records = await _context.Bookings
                                        .Join(_context.Users,
                                              itemBooking => itemBooking.UserID, itemUser => itemUser.Id,
                                              (itemBooking, itemUser) => new OrderListViewModel
                                              {
                                                  BookingId = itemBooking.BookingID,
                                                  UserId = itemUser.Id,
                                                  UserName = itemUser.UserName,
                                                  CreatedDate = itemBooking.CreatedDate ?? DateTime.MinValue,
                                                  Total = itemBooking.Total ?? 0,
                                                  Status = itemBooking.Status ?? "Unknown"
                                              })
                                        .Where(itemUser => itemUser.UserName != "Admin")
                                        .ToListAsync();

            return View(records);
        }

        public async Task<IActionResult> FeedbackList()
        {
            var result = await (from b in _context.Bookings
                                join u in _context.Users on b.UserID equals u.Id
                                join t in _context.Templates on b.TemplateID equals t.TemplatesID
                                join f in _context.Feedbacks on b.BookingID equals f.BookingID into feedbackGroup
                                from f in feedbackGroup.DefaultIfEmpty() // Left Join to include bookings without feedback
                                select new FeedbackListViewModel
                                {
                                    BookingId = b.BookingID,
                                    UserId = u.Id,
                                    UserName = u.UserName,
                                    TemplateName = t.TemplateName,
                                    CreatedDate = f.CreatedDate,
                                    Comment = f != null ? f.Comment : "No Feedback"
                                })
                          .ToListAsync();
            return View(result);
        }
    }
}
