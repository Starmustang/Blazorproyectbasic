using Blazorproyect.Entity;
using DataAccess.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Bodega
    {
        private readonly IBodegaService _bodegaService;

        public B_Bodega(IBodegaService bodegaService)
        {
            _bodegaService = bodegaService;
        }

        public async Task<List<BodegaEntity>> GetBodegaListAsync()
        {
            return await _bodegaService.GetAllBodegasAsync();
        }

        public async Task CreateBodegaAsync(BodegaEntity bodega)
        {
            await _bodegaService.CreateBodegaAsync(bodega);
        }

        public async Task UpdateBodegaAsync(BodegaEntity bodega)
        {
            await _bodegaService.UpdateBodegaAsync(bodega);
        }

        public async Task<BodegaEntity> GetBodegaById(string id)
        {
            return await _bodegaService.GetBodegaById(id);
        }

        public bool IsProductInAlmacen(string idBodega)
        {
            return _bodegaService.IsProductInAlmacen(idBodega);
        }

        public Task<List<BodegaEntity>> BodegaProductByAlmacen(string idAlmacen)
        {
            return _bodegaService.BodegaProductByAlmacen(idAlmacen);
        }
    }
}
