using Blazorproyect.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Servicios.Interfaces
{
    public interface IBodegaService
    {
        Task<List<BodegaEntity>> GetAllBodegasAsync();

        Task CreateBodegaAsync(BodegaEntity bodega);

        Task UpdateBodegaAsync(BodegaEntity bodega);

        Task<BodegaEntity> GetBodegaById(string id);

        bool IsProductInAlmacen(string idBodega);

        Task<List<BodegaEntity>> BodegaProductByAlmacen(string idAlmacen);
    }
}
