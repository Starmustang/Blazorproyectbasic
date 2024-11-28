using Blazorproyect.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Servicios.Interfaces
{
    public interface IIngresosySalidas
    {
        Task<List<IngresosySalidasEntity>> GetAllIngresosySalidasAsync();

        Task CreateIngresosySalidasAsync(IngresosySalidasEntity ingresosySalidas);

        Task UpdateIngresosySalidasAsync(IngresosySalidasEntity ingresosySalidas);

        Task<IngresosySalidasEntity> GetIngresosySalidasByIdAsync(string id);
    }
}
