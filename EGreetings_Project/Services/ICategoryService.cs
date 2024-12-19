
// ICategoryService.cs
using System.Collections.Generic;
using System.Threading.Tasks;
using EGreetings_Project.Models;

namespace EGreetings_Project.Services
{
  

    public interface ICategoryService
    {
        Task<List<Category>> GetCategoriesByGroupCate(string groupCate);
    }

}
