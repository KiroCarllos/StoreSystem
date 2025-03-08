using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageAppSystem.Dtos
{
    public class OrderProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public DateTime AddedOn { get; set; } = DateTime.Now;
        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
