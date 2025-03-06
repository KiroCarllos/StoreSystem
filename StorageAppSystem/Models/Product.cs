using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageAppSystem.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
       // [ForeignKey("Warehouse")]
       // public int WarehouseId { get; set; }
        public DateTime AddedOn { get; set; } = DateTime.Now;
        //public Warehouse Warehouse { get; set; }
        public virtual ICollection<ProductUnit> ProductUnits { get; set; } = new HashSet<ProductUnit>();

    }
}
