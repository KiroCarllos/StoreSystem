    using Microsoft.EntityFrameworkCore;
using StorageAppSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageAppSystem.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext()
        {
            
        }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS2022;Initial Catalog=StorageAppSystemDB;User ID=sa;Password=root@123;Encrypt=False;");
        }

        public DbSet<Client> clients { get; set; }
        public DbSet<Supplier> suppliers { get; set; }
        public DbSet<Warehouse> warehouses { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductUnit> productUnits { get; set; }
        public DbSet<SupplyOrder> supplyOrders { get; set; }
        public DbSet<SupplyOrderDetails> supplyOrderDetails { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetail> orderDetails { get; set; }
    }
}
