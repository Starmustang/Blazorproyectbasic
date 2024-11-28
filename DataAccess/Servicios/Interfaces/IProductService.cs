using Blazorproyect.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Servicios.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductEntity>> GetAllProductsAsync();

        Task<ProductEntity> GetProductById(string id);

        Task CreateProductAsync(ProductEntity product);

        Task UpdateProductAsync(ProductEntity product);
    }
}
