using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazorproyect.Entity
{
    public class AlmacenEntity //warehouse
    {
        [Key]
        [StringLength(50)]
        public string AlmacenId { get; set; }
        [Required]
        [StringLength(50)]
        public string AlmacenName { get; set; }
        [Required]
        [StringLength(100)]
        public string AlmacenDireccion { get; set; }

        //Relacion con BodegaEntity
        public ICollection<BodegaEntity> Bodegas { get; set; }
    }
}
