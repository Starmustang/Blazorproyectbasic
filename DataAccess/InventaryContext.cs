using Blazorproyect.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazorproyect.DataAccess
{
    public class InventaryContext : DbContext
    {
        public InventaryContext(DbContextOptions<InventaryContext> options) : base(options)
        {

        }

        public DbSet<ProductEntity> Products { get; set; }

        public DbSet<CategoryEntity> Category { get; set; }

        public DbSet<AlmacenEntity> Almacenes { get; set; }

        public DbSet<BodegaEntity> Bodegas { get; set; }

        public DbSet<IngresosySalidasEntity> ingresosySalidas { get; set; }      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { categoryId="ASH", categoryName="Aseo Hogar"},
                new CategoryEntity { categoryId = "ASP", categoryName = "Aseo Personal" },
                new CategoryEntity { categoryId = "HGR", categoryName = "Hogar" },
                new CategoryEntity { categoryId = "PRF", categoryName = "Perfumeria" },
                new CategoryEntity { categoryId = "SLD", categoryName = "Salud" },
                new CategoryEntity { categoryId = "VDJ", categoryName = "Video Juegos" }
                );

            modelBuilder.Entity<AlmacenEntity>().HasData(
                new AlmacenEntity { AlmacenId=Guid.NewGuid().ToString(), AlmacenName="Almacen central", AlmacenDireccion="Por ahi"},
                new AlmacenEntity { AlmacenId = Guid.NewGuid().ToString(), AlmacenName = "Almacen de Los Frailes 1 ", AlmacenDireccion = "Frailes 1" },
                new AlmacenEntity { AlmacenId = Guid.NewGuid().ToString(), AlmacenName = "Almacen de Los Frailes 2", AlmacenDireccion = "Frailes 2" },
                new AlmacenEntity { AlmacenId = Guid.NewGuid().ToString(), AlmacenName = "Almacen Tame Impala", AlmacenDireccion = "Tame Impala" }
                );
        }

    }
}
