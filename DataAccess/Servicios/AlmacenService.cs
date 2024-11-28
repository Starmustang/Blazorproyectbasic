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
    public class AlmacenService : IAlmacenService
    {
        private readonly InventaryContext _context;

        public AlmacenService(InventaryContext context)
        {
            _context = context;
        }

        public async Task<List<AlmacenEntity>> GetAllAlmacenAsync()
        {
            return await _context.Almacenes.ToListAsync();
        }

        public async Task CreateAlmacenAsync(AlmacenEntity almacenEntity)
        {
            await _context.AddAsync(almacenEntity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAlmacenAsync(AlmacenEntity almacenEntity)
        {
            _context.Almacenes.Update(almacenEntity);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAlmacenAsync(AlmacenEntity almacenEntity)
        {
            _context.Almacenes.Remove(almacenEntity);
            await _context.SaveChangesAsync();
        }

        public async Task<AlmacenEntity> GetAlmacenById(string id)
        {
            return await _context.Almacenes.Where(p => p.AlmacenId == id).OrderBy(p => p.AlmacenId).FirstOrDefaultAsync();
        }
    }
}
