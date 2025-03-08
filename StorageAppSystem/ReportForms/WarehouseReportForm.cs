using Microsoft.EntityFrameworkCore;
using StorageAppSystem.Data;
using StorageAppSystem.Dtos;
using StorageAppSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageAppSystem.ReportForms
{
    public partial class WarehouseReportForm : Form
    {
        AppDBContext db;
        List<Warehouse> warehouses;
        public WarehouseReportForm()
        {
            InitializeComponent();
            db = new AppDBContext();
            warehouses = new List<Warehouse>();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Close();
        }

        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            warehouses = db.warehouses.ToList();
            var dataWarehouse = warehouses.Select(w => new
            {
                Id = w.Id,
                Name = w.Name,
                Address = w.Address,
                ManagerName = w.ManagerName
            }).ToList();
            warehousesDataGridView.DataSource = dataWarehouse;
            warehousesDataGridView.ClearSelection();
        }

        private void warehousesDataGridView_MouseClick(object sender, EventArgs e)
        {
            if (warehousesDataGridView.SelectedRows.Count > 0)
            {
                var wareHouseId = Convert.ToInt32(warehousesDataGridView.SelectedRows[0].Cells[0].Value);
                wareProductGridView.DataSource = db.supplyOrderDetails
                 .Where(s => s.SupplyOrder.WarehouseId == wareHouseId)
                 .Select(p => new
                 {
                     Id = p.Product.Id,
                     Name = p.Product.Name,
                     Qty = db.supplyOrderDetails
                         .Where(so => so.ProductId == p.ProductId && so.SupplierId == p.SupplierId && so.SupplyOrder.WarehouseId == wareHouseId)
                         .Sum(so => so.Quantity)
                         - db.orderDetails
                         .Where(o => o.Order.WarehouseId == wareHouseId && o.ProductId == p.ProductId)
                         .Sum(o => o.Qty),
                     Supplier = p.Supplier.Name,
                     ProductionDate = p.ProductionDate,
                     ExpiryDate = p.ExpiryDate,
                     AddedOn = p.SupplyOrder.OrderDate
                 })
                 .AsEnumerable()  // Move data processing to memory
                 .GroupBy(p => new { p.Id ,p.Supplier})  // Group by Product Id in memory
                 .Select(g => g.First()) // Take the first record from each group
                 .Where(p => p.Qty > 0)
                 .ToList();
            }
        }

    }
}
