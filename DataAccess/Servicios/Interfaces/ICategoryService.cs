using Blazorproyect.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Servicios.Interfaces
{
    public interface ICategoryService
    {
        Task<List<CategoryEntity>> GetAllCategoriesAsync();
        Task CreateCategoryAsync(CategoryEntity category);
        Task UpdateCategoryAsync(CategoryEntity category);

        Task <CategoryEntity> GetCategoryById(string categoryId);
    }
}
