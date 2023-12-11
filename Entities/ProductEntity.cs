using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductEntity
    {
        [Key]
        [StringLength(50)]
        public string ProductId { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(600)]
        public string ProductDescription { get; set; }


        public int TotalQuantity { get; set; }


        /**RELACION DE MUCHOS A UNO EN CATEGORIA**/
        public string CategoryID { get; set; }

        public CategoryEntity Category { get; set; }


        /**relacion con almacenamiento**/

        public ICollection<StorageEntity> Storages { get; set; }

    }
}
