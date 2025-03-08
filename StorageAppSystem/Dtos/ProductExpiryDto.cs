using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageAppSystem.Dtos
{
    public class ProductExpiryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public DateTime AddedOn { get; set; } = DateTime.Now;
        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public int RemainDaysToExpire { get; set; } 
        public DateTime ProductionDate { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
