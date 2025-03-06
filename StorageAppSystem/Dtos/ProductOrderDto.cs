using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageAppSystem.Dtos
{
    public class ProductOrderDto

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public string Supplier { get; set; }
    }
}
