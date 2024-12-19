using EGreetings_Project.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EGreetings_Project.Models;

namespace EGreetings_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubscriptionController : Controller
    {
        private readonly EGreetingsDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public SubscriptionController(EGreetingsDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var subscriptions = await _context.Subscriptions.ToListAsync();
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
        public async Task<IActionResult> Edit(int id, Subscribes subscription)
        {
            if (id != subscription.SubscriptionID)
            {
                return BadRequest();
            }

            if (string.IsNullOrEmpty(subscription.SubName))
            {
                ModelState.AddModelError("SubName", "Name is required.");
            }
            if (subscription.SubName?.Length < 3 || subscription.SubName?.Length > 50) {
                ModelState.AddModelError("SubName", "It is between 3 and 50 characters long.");
            }

            if (string.IsNullOrEmpty(subscription.Price.ToString())) {
                ModelState.AddModelError("Price", "Price is required.");
            }
            if (string.IsNullOrEmpty(subscription.Quantity.ToString())) {
                ModelState.AddModelError("Quantity", "Quantity is required.");
            }           
            if (subscription.Price < 0) {
                ModelState.AddModelError("Price", "Price cannot be less than 0.");
            }
            if (subscription.Quantity < 0) {
                ModelState.AddModelError("Quantity", "Quantity cannot be less than 0.");
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
                existingSubscription.Quantity = subscription.Quantity;
          
                _context.Update(existingSubscription);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(subscription);
        }               

    }
}


