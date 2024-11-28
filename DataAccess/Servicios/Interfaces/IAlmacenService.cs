using Blazorproyect.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Servicios.Interfaces
{
    public interface IAlmacenService
    {
        Task<List<AlmacenEntity>> GetAllAlmacenAsync();

        Task CreateAlmacenAsync(AlmacenEntity almacen);

        Task UpdateAlmacenAsync(AlmacenEntity almacen);

        Task DeleteAlmacenAsync(AlmacenEntity almacen);

        Task <AlmacenEntity> GetAlmacenById(string id);
    }
}
