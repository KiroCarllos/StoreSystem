using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageAppSystem.Models
{
    public class Warehouse
    {
        [Key]
        public int Id{ get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Address { get; set; }

        public string ManagerName { get; set; }
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
