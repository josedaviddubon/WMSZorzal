using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(50)]

        public string StorageId { get; set; }

        [Required]
        public DateTime LastUpdate { get; set; }

        [Required]
        public int PartialQuantity { get; set; }


        ///Relacion con producto
        public string ProductId { get; set; }

        public ProductEntity Product { get; set; }

        //relacion con bodegas Warehouse

        public string WarehouseID { get; set; }

        public WarehouseEntity Warehouse { get;set; }

        //relacion con movimientos (InputOutPut)

        public ICollection<InputOutputEntity> InputOutPut { get; set; }

    }
}
