using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazorproyect.Entity
{
    public class ProductEntity
    {
        [Key]
        [StringLength(50)]
        public string ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [StringLength(600)]
        public string ProductDescription { get; set; }

        public int ProductQuantity { get; set; }
        // Relacion con categorias (CategoryEntity)
        public string categoryId { get; set; }
        public CategoryEntity Category { get; set; }

        //Relacion con Bodegas (BodegaEntity)
        public ICollection<BodegaEntity> Bodegas { get; set; }
    }
}
