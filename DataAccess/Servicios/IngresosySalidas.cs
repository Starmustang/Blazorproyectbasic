using Blazorproyect.DataAccess;
using Blazorproyect.Entity;
using DataAccess.Servicios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Servicios
{
    public class IngresosySalidas : IIngresosySalidas
    {
        private readonly InventaryContext _context;

        public IngresosySalidas(InventaryContext context)
        {
            _context = context;
        }

        public async Task<List<IngresosySalidasEntity>> GetAllIngresosySalidasAsync()
        {
            return await _context.ingresosySalidas.ToListAsync();
        }

        public async Task CreateIngresosySalidasAsync(IngresosySalidasEntity ingresosySalidas)
        {
            await _context.ingresosySalidas.AddAsync(ingresosySalidas);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateIngresosySalidasAsync(IngresosySalidasEntity ingresosySalidas)
        {
            _context.ingresosySalidas.Update(ingresosySalidas);
            await _context.SaveChangesAsync();
        }

        public async Task<IngresosySalidasEntity> GetIngresosySalidasByIdAsync(string id)
        {
            return await _context.ingresosySalidas.Where(p => p.IngresoId == id).OrderBy(p => p.IngresoId).LastOrDefaultAsync();
        }
    }
}
