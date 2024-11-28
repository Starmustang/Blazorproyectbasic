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
    public class ProductService : IProductService
    {
        private  readonly InventaryContext _context;

        public ProductService(InventaryContext context)
        {
            _context = context;
        }

        public async Task<List<ProductEntity>> GetAllProductsAsync()
        {
           return await _context.Products.ToListAsync();
        } 

        public async Task<ProductEntity> GetProductById(string id)
        {
            return await _context.Products
                .Where(p => p.ProductId == id)
                .OrderBy(p => p.ProductId)
                .LastOrDefaultAsync();
        }

        public  async Task CreateProductAsync(ProductEntity product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProductAsync(ProductEntity product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}
