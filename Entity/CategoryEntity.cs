using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazorproyect.Entity
{
    public class CategoryEntity
    {
        [Key]
        [StringLength(50)]
        public string categoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string categoryName { get; set; }

        public ICollection<ProductEntity> Products { get; set; }

    }
}
