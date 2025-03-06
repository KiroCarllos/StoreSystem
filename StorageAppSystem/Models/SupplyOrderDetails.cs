using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageAppSystem.Models
{
    public class SupplyOrderDetails
    {
        public int Id { get; set; }
        public int SupplyOrderId { get; set; }
        public int SupplierId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public virtual SupplyOrder SupplyOrder { get; set; }
        public virtual Product Product { get; set; }
        public virtual Supplier Supplier { get; set; }

    }
}
