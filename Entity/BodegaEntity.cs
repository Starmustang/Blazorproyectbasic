using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazorproyect.Entity
{
    public class BodegaEntity //storage
    {
        [Key]
        [StringLength(50)]
        public string BodegaId { get; set; }

        [Required]
        public DateTime UltimaActualizacion { get; set; }

        [Required]
        public int CantidadParcial { get; set; }

        //Relacion con productos
        public string ProductId { get; set; }
        public ProductEntity Product { get; set; }

        //Relacion con almacen (AlmacenEntity)
        public string AlmacenId { get; set; }
        public AlmacenEntity Almacen { get; set; }

        //Relacion con movimientos (IngresosySalidasEntity)
        public ICollection<IngresosySalidasEntity> ingresosySalidas { get; set; }
    }
}
