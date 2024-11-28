﻿using Blazorproyect.DataAccess;
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
    public class BodegaService : IBodegaService
    {
        private readonly InventaryContext _context;

        public BodegaService(InventaryContext context)
        {
            _context = context;
        }

        public async Task<List<BodegaEntity>> GetAllBodegasAsync()
        {
            return await _context.Bodegas.ToListAsync();
        }

        public async Task CreateBodegaAsync(BodegaEntity bodega)
        {
            await _context.AddRangeAsync(bodega);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBodegaAsync(BodegaEntity bodega)
        {
             _context.Bodegas.Update(bodega);
            await _context.SaveChangesAsync();
        }

        public async Task<BodegaEntity> GetBodegaById(string id)
        {
            return await _context.Bodegas.Where(p => p.BodegaId == id).OrderBy(p => p.BodegaId).LastOrDefaultAsync();
        }
    }
}
