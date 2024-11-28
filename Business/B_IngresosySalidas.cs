using Blazorproyect.Entity;
using DataAccess.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_IngresosySalidas
    {
        private readonly IIngresosySalidas _ingresosySalidas;

        public B_IngresosySalidas(IIngresosySalidas ingresosySalidas)
        {
            _ingresosySalidas = ingresosySalidas;
        }

        public async Task<List<IngresosySalidasEntity>> GetIngresosySalidasAsync()
        {
            return await _ingresosySalidas.GetAllIngresosySalidasAsync();
        }

        public async Task CreateIngresosySalidasAsync(IngresosySalidasEntity ingresosySalidas)
        {
            await _ingresosySalidas.CreateIngresosySalidasAsync(ingresosySalidas);
        }

        public async Task UpdateIngresosySalidasAsync(IngresosySalidasEntity ingresosySalidas)
        {
            await _ingresosySalidas.UpdateIngresosySalidasAsync(ingresosySalidas);
        }

        public async Task<IngresosySalidasEntity> GetIngresosySalidasByIdAsync(string id)
        {
            return await _ingresosySalidas.GetIngresosySalidasByIdAsync(id);
        }
    }
}
