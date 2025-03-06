using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageAppSystem.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int WarehouseId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual Client Client { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }= new HashSet<OrderDetail>(); 
    }
}
