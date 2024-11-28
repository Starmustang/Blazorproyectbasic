using Blazorproyect.Entity;
using DataAccess.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Almacen 
    { 
        private readonly IAlmacenService _Almacen;

        public B_Almacen (IAlmacenService almacen)
        {
            _Almacen = almacen;
        }

        public async Task<List<AlmacenEntity>> GetAlmacenListAsync()
        {
            return await _Almacen.GetAllAlmacenAsync();
        }

        public async Task CreateAlmacenAsync(AlmacenEntity almacen)
        {
            await _Almacen.CreateAlmacenAsync(almacen);
        }

        public async Task UpdateAlmacenAsync(AlmacenEntity almacen)
        {
            await _Almacen.UpdateAlmacenAsync(almacen);
        }

        public async Task<AlmacenEntity> GetAlmacenByIdAsync(string id)
        {
           return await _Almacen.GetAlmacenById(id);     
        }
    }
}
