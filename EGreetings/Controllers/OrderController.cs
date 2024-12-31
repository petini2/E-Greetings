using EGreetings.Data;
using EGreetings.Models;
using EGreetings.Models.ViewModelAccount;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EGreetings.Controllers
{
    public class OrderController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly EGreetingsDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        public OrderController(UserManager<User> userManager, EGreetingsDbContext context, IWebHostEnvironment hostEnvironment)
        {
            this.userManager = userManager;
            _context = context;
            _hostEnvironment = hostEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            //Get UserID from Cookie
            string userId = Request.Cookies["UserID"];
            //Check if is login
            if (userId != null)
            {
                //Find uset
                var user = await userManager.FindByIdAsync(userId);
                //Take all user's order
                var orders = await _context.Bookings
                                               .Where(x => x.UserID == userId)
                                               .ToListAsync();
                //Return Index page with list order
                return View(orders);
            }
            else
            {
                // Ask to login page
                return RedirectToAction("OrderNoContent", "Order");
            }
        }
        public IActionResult OrderNoContent()
        {
            return View();
        }
        public async Task<IActionResult> OnGoing()
        {
            //Get UserID from Cookie
            string userId = Request.Cookies["UserID"];
            //Get all on going orders of this user
            var processingOrder = await _context.Bookings
                                           .Where(itemBooking => itemBooking.Status == "Ongoing" && itemBooking.UserID == userId)
                                           .ToListAsync();
            return View(processingOrder);
        }
        public async Task<IActionResult> Complete()
        {
            //Get UserID from Cookie
            string userId = Request.Cookies["UserID"];
            //Get all complete orders of this user
            var completeOrder = await _context.Bookings
                                           .Where(itemBooking => itemBooking.Status == "Complete" && itemBooking.UserID == userId)
                                           .ToListAsync();
            return View(completeOrder);
        }
        public async Task<IActionResult> Pending()
        {
            //Get UserID from Cookie
            string userId = Request.Cookies["UserID"];
            //Get all pending orders of this user
            var pendingOrder = await _context.Bookings
                                           .Where(itemBooking => itemBooking.Status == "Pending" && itemBooking.UserID == userId)
                                           .ToListAsync();
            return View(pendingOrder);
        }
        public async Task<IActionResult> Fail()
        {
            //Get UserID from Cookie
            string userId = Request.Cookies["UserID"];
            //Get all fail orders of this user
            var failOrder = await _context.Bookings
                                           .Where(itemBooking => itemBooking.Status == "Fail" && itemBooking.UserID == userId)
                                           .ToListAsync();
            return View(failOrder);
        }
        public async Task<IActionResult> Detail(int id)
        {
            //Find booking with the Id
            var booking = await _context.Bookings.FindAsync(id);
            //Find feedback of the booking
            var feedback = await _context.Feedbacks.FirstOrDefaultAsync(f => f.BookingID == id);
            //Find related templates
            var templates = await _context.TemplateHistories.Where(t => t.BookingID == id).ToListAsync();
            if (booking == null)
            {
                return NotFound();
            }
            //Check if already have feedback
            string commentValue = null;
            if (feedback != null)
            {
                commentValue = feedback.Comment;
            }
            List<string> tempIds = new List<string>();
            //Check have related template
            if (templates != null)
            {
                //Add template to List
                foreach (var template in templates)
                {
                    tempIds.Add(template.SvgUrl);
                }
            }
            //Create view model booking Feedback to show booking detail, related template, feedback(if have)
            BookingFeedback bkg = new BookingFeedback
            {
                BookingID = booking.BookingID,
                BookingDate = booking.BookingDate,
                CreatedDate = booking.BookingDate,
                Status = booking.Status,
                Total = booking.Total,
                Comment = commentValue,
                Templates = tempIds,
            };
            return View(bkg);
        }
        public async Task<IActionResult> Update(int id)
        {
            //Find booking with the Id
            var booking = await _context.Bookings.FindAsync(id);
            //Find templates with the booking
            var templates = await _context.TemplateHistories.Where(t => t.BookingID == id).ToListAsync();
            List<string> tempIds = new List<string>();
            //Add related template to List
            if (templates != null)
            {
                foreach (var template in templates)
                {
                    tempIds.Add(template.SvgUrl);
                }
            }
            if (booking == null)
            {
                return NotFound();
            }
            //Create view model booking Feedback to show booking detail, related template to show data
            var bookingEdit = new BookingFeedback
            {
                Status = booking.Status,
                Total = booking.Total,
                BookingDate = booking.BookingDate,
                CreatedDate = booking.CreatedDate,
                BookingID = booking.BookingID,
                Templates = tempIds,
            };
            return View(bookingEdit);
        }
        [HttpPost]
        public async Task<IActionResult> Update(BookingFeedback feedback)
        {
            //Check comment is null
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Feedback comment is required!");
                return View("Update", feedback);
            }
            //Add new feedback for this booking
            Feedback newfeed = new Feedback { BookingID = feedback.BookingID, Comment = feedback.Comment, CreatedDate = DateTime.Now };
            //Save to db
            _context.Feedbacks.Add(newfeed);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}