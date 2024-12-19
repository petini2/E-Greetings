using EGreetings_Project.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using EGreetings_Project.Models;

namespace EGreetings_Project.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly EGreetingsDbContext _context;

        public CategoryService(EGreetingsDbContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetCategoriesByGroupCate(string groupCate)
        {
            return await _context.Categories
                .Where(c => c.GroupCate == groupCate)
                .ToListAsync();
        }

        Task<List<Category>> ICategoryService.GetCategoriesByGroupCate(string groupCate)
        {
            throw new NotImplementedException();
        }
    }



}
