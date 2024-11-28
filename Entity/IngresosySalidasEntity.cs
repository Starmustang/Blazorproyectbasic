using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazorproyect.Entity
{
    public class IngresosySalidasEntity
    {
        [Key]
        public string IngresoId { get; set; }

        [Required]
        [StringLength(50)]
        public DateTime IngresoFecha { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public bool Isinput { get; set; }

        //Relacion con Bodega (BodegaEntity)

        public string BodegaId { get; set; }

        public BodegaEntity Bodegas { get; set; }

    }
}
