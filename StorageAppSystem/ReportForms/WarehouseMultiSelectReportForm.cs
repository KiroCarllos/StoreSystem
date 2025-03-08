using StorageAppSystem.Data;
using StorageAppSystem.Dtos;
using StorageAppSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageAppSystem.ReportForms
{
    public partial class WarehouseMultiSelectReportForm : Form
    {
        AppDBContext db;
        List<Warehouse> warehouses;
        List<ProductDto> warehousesProducts;
        public WarehouseMultiSelectReportForm()
        {
            InitializeComponent();
            db = new AppDBContext();
            warehouses = new List<Warehouse>();
            warehousesProducts = new List<ProductDto>();
        }

        private void WarehouseMultiSelectReportForm_Load(object sender, EventArgs e)
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
        private void backBtn_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Close();
        }



        private void warehousesDataGridView_MouseClick(object sender, EventArgs e)
        {
            if (warehousesDataGridView.SelectedRows.Count > 0)
            {
                var wareHouseIds = warehousesDataGridView.SelectedRows.Cast<DataGridViewRow>().Select(r => Convert.ToInt32(r.Cells[0].Value)).ToList();
                warehousesProducts= db.supplyOrderDetails
                 .Where(s => wareHouseIds.Contains(s.SupplyOrder.WarehouseId))
                 .Select(p => new ProductDto
                 {
                     Id = p.Product.Id,
                     Name = p.Product.Name,
                     Qty = db.supplyOrderDetails
                         .Where(so => so.ProductId == p.ProductId && so.SupplierId == p.SupplierId && wareHouseIds.Contains(so.SupplyOrder.WarehouseId))
                         .Sum(so => so.Quantity)
                         - db.orderDetails
                         .Where(o => wareHouseIds.Contains(o.Order.WarehouseId) && o.ProductId == p.ProductId)
                         .Sum(o => o.Qty),
                     Supplier = p.Supplier.Name,
                     ProductionDate = p.ProductionDate,
                     ExpiryDate = p.ExpiryDate,
                     AddedOn = p.SupplyOrder.OrderDate
                 })
                 .AsEnumerable()  // Move data processing to memory
                 .GroupBy(p => new { p.Id, p.Supplier })  // Group by Product Id in memory
                 .Select(g => g.First()) // Take the first record from each group
                 .Where(p => p.Qty > 0)
                 .ToList();

                var data = warehousesProducts.Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.Qty,
                    p.Supplier,
                    p.ProductionDate,
                    p.ExpiryDate,
                    p.AddedOn
                }).ToList();
                wareProductGridView.DataSource = data;
            }
        }
        private void filterBtn_Click(object sender, EventArgs e)
        {
            if (warehousesDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a warehouse first");
                return;
            }
            else
            {
                DateTime fromDate = fromDateTimePicker.Value;
                DateTime toDate = toDateTimePicker.Value;
                wareProductGridView.DataSource = warehousesProducts.Where(p => p.AddedOn >= fromDate && p.AddedOn <= toDate).ToList();

            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            fromDateTimePicker.Value = DateTime.Now;
            toDateTimePicker.Value = DateTime.Now;
            warehousesDataGridView.ClearSelection();

            wareProductGridView.DataSource = null;
        }

    }

    public class ProductDto
    {

        public int Id{ get; set; }
        public string Name { get; set; }
        public int Qty{ get; set; }
        public string Supplier { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime AddedOn { get; set; }


    }
}
