using Blazorproyect.Entity;
using DataAccess.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Product
    {
        private readonly IProductService _productService;

        public B_Product(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<List<ProductEntity>> GetProductListAsync()
        {
            return await _productService.GetAllProductsAsync();
        }

        public async Task<ProductEntity> GetProductById(string id)
        {
            return await _productService.GetProductById(id);
        }

        public  async Task CreateProductAsync(ProductEntity product)
        {
            await _productService.CreateProductAsync(product);
        }

        public async Task UpdateProductAsync(ProductEntity product)
        {
            await _productService.UpdateProductAsync(product);
        }

    }
}
