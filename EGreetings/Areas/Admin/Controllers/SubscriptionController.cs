using EGreetings.Areas.Admin.Models;
using EGreetings.Data;
using EGreetings.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EGreetings.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubscriptionController : Controller
    {
        private readonly EGreetingsDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly UserManager<User> _userManager;

        public SubscriptionController(EGreetingsDbContext context, IWebHostEnvironment hostEnvironment, UserManager<User> userManager)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var subscriptions = await _context.Subscriptions.ToListAsync();
            ViewData["IsSubscription"] = true;
            ViewData["IsSubscriptionList"] = true;

            return View(subscriptions);
        }


        [HttpPost]
        public async Task<IActionResult> UpdateStatus(int subscriptionId, bool status)
        {
            var subscription = await _context.Subscriptions.FindAsync(subscriptionId);
            if (subscription != null)
            {
                subscription.isActive = status;
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Edit(int id)
        {
            var subscription = await _context.Subscriptions.FindAsync(id);
            if (subscription == null)
            {
                return NotFound();
            }

            return View(subscription);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Subscription subscription)
        {
            if (id != subscription.SubscriptionID)
            {
                return BadRequest();
            }

            if (string.IsNullOrEmpty(subscription.SubName))
            {
                ModelState.AddModelError("SubName", "Name is required.");
            }
            if (subscription.SubName?.Length < 3 || subscription.SubName?.Length > 50)
            {
                ModelState.AddModelError("SubName", "It is between 3 and 50 characters long.");
            }

            if (string.IsNullOrEmpty(subscription.Price.ToString()))
            {
                ModelState.AddModelError("Price", "Price is required.");
            }
            if (subscription.Price < 0)
            {
                ModelState.AddModelError("Price", "Price cannot be less than 0.");
            }

            if (ModelState.IsValid)
            {
                var existingSubscription = await _context.Subscriptions.FindAsync(id);
                if (existingSubscription == null)
                {
                    return NotFound();
                }

                existingSubscription.SubName = subscription.SubName;
                existingSubscription.Price = subscription.Price;

                _context.Update(existingSubscription);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(subscription);
        }


        public async Task<IActionResult> UsersDetail(int subscriptionId, string subCate)
        {
            var records = await _context.UserSubs
                                .Join(_context.Users,
                                      itemUserSubscription => itemUserSubscription.UserID, itemUser => itemUser.Id,
                                      (itemUserSubscription, itemUser) => new UsersDetailViewModel
                                      {
                                          UserId = itemUserSubscription.UserID,
                                          SubscriptionId = itemUserSubscription.SubscriptionID,
                                          UserName = itemUser.UserName,
                                          StartDate = itemUserSubscription.StartDate,
                                          EndDate = itemUserSubscription.EndDate,
                                          Quantity = itemUserSubscription.Quantity ?? 0,
                                          IsActive = itemUserSubscription.isActive
                                      })
                                .Where(item => item.SubscriptionId == subscriptionId)
                                .ToListAsync();
            ViewData["SubCate"] = subCate;

            return View(records);
        }


        [HttpPost]
        public async Task<IActionResult> UpdateUserStatus(string userId, bool status, string subCate)
        {
            var userSubscription = await _context.UserSubs.FirstOrDefaultAsync(item => item.UserID == userId);
            if (userSubscription != null)
            {
                userSubscription.isActive = status;

                if (status && subCate == "Monthly")
                {
                    userSubscription.StartDate = DateTime.Now;
                    //userSubscription.EndDate = DateTime.Now.AddDays(30);
                    userSubscription.EndDate = DateTime.Now.AddMinutes(10);
                }
                else
                {
                    Console.WriteLine("Deactive User");
                }

                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(UsersDetail), new { subscriptionId = userSubscription.SubscriptionID, subCate = subCate });
        }
    }
}


