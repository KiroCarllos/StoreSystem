using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageAppSystem.Models
{
    public class SupplyOrder
    {
        public int Id { get; set; }
        public int WarehouseId { get; set; }
   
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual Warehouse Warehouse { get; set; }
     
        public virtual ICollection<SupplyOrderDetails> OrderDetails { get; set; } = new HashSet<SupplyOrderDetails>();
    }
}
