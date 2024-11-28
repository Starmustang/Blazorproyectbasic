using Blazorproyect.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Blazorproyect.DataAccess;
using DataAccess.Servicios.Interfaces;

namespace Business
{
    public class B_Category
    {
        private readonly ICategoryService _categoryService;

        public B_Category(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<List<CategoryEntity>> GetCategoryListAsync()
        {
            return await _categoryService.GetAllCategoriesAsync();
        }

        public async Task CreateCategoryAsync(CategoryEntity category)
        {
            await _categoryService.CreateCategoryAsync(category);
        }

        public async Task UpdateCategoryAsync(CategoryEntity category)
        {
            await _categoryService.UpdateCategoryAsync(category);
        }

        public async Task<CategoryEntity> GetCategoryById(string categoryId)
        {
           return await _categoryService.GetCategoryById(categoryId);
        }
    }
}
