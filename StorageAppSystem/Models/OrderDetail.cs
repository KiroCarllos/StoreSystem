using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageAppSystem.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int SupplierId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public virtual Order Order { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Product Product { get; set; }

    }
}
