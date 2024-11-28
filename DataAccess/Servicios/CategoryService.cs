using Blazorproyect.DataAccess;
using Blazorproyect.Entity;
using DataAccess.Servicios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Servicios
{
    public class CategoryService : ICategoryService
    {
        private readonly InventaryContext _context;
        public CategoryService(InventaryContext context) 
        {
            _context = context;
        }

        public async Task<List<CategoryEntity>> GetAllCategoriesAsync()
        {
            return await _context.Category.ToListAsync();
        }
        public async Task CreateCategoryAsync(CategoryEntity category)
        {
            await _context.Category.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task<CategoryEntity> GetCategoryById(string categoryId)
        {
           return await _context.Category.Where(p => p.categoryId == categoryId).OrderBy(p => p.categoryId).LastOrDefaultAsync();
        }

        public async Task UpdateCategoryAsync(CategoryEntity category)
        {
            _context.Category.Update(category);
            await _context.SaveChangesAsync();
        }
    }
}
