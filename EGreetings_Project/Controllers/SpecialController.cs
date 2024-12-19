using EGreetings_Project.Data;
using EGreetings_Project.Models;
using Microsoft.AspNetCore.Mvc;

public class SpecialController : Controller
{
    private readonly EGreetingsDbContext db;

    public SpecialController(EGreetingsDbContext db)
    {
        this.db = db;
    }

    //Main site (default is discount)
    public IActionResult Index()
    {
        var templates = db.Templates
            .Where(t => t.Discount > 0)  
            .OrderByDescending(t => t.CreatedDate)  
            .Take(8)  
            .ToList();

        return View("Special", templates);  
    }

    
    public IActionResult SpecialOffers(string type)
    {
        List<Template> templates;

        if (type == "discounts")
        {
           
            templates = db.Templates
                .Where(t => t.Discount > 0)
                .OrderByDescending(t => t.CreatedDate)
                .Take(8)
                .ToList();
        }
        else
        {
           
            templates = db.Templates
                .OrderByDescending(t => t.CreatedDate)
                .Take(8)
                .ToList();
        }

        return View("Special", templates);  
    }
}
