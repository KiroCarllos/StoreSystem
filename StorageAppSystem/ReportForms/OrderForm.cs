using StorageAppSystem.Data;
using StorageAppSystem.Dtos;
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
    public partial class OrderForm : Form
    {
        AppDBContext db;
        List<OrderProductDto> warehouseProductDtos;
        public OrderForm()
        {
            InitializeComponent();
            db = new AppDBContext();
            warehouseProductDtos = new List<OrderProductDto>();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Close();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            warehouseProductDtos = db.orderDetails.Select(o => new OrderProductDto
            {
                Id = o.Product.Id,
                Name = o.Product.Name,
                Barcode = o.Product.Barcode,
                AddedOn = o.Product.AddedOn,
                WarehouseId = o.Order.WarehouseId,
                WarehouseName = o.Order.Warehouse.Name,
                OrderDate = o.Order.OrderDate
            }).ToList();

            var data = warehouseProductDtos.Select(w => new
            {
                w.Id,
                w.Name,
                w.Barcode,
                w.AddedOn,
                w.WarehouseId,
                w.WarehouseName,
                w.OrderDate
            }).ToList();
            dataGridView1.DataSource = data;
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            var fromDate = dateTimePicker1.Value;
            var toDate = dateTimePicker2.Value;
            var data = warehouseProductDtos.Select(w => new
            {
                w.Id,
                w.Name,
                w.Barcode,
                w.AddedOn,
                w.WarehouseId,
                w.WarehouseName,
                w.OrderDate
            }).ToList();
            dataGridView1.DataSource = data.Where(d => d.OrderDate >= fromDate && d.OrderDate <= toDate).ToList();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = warehouseProductDtos.Select(w => new
            {
                w.Id,
                w.Name,
                w.Barcode,
                w.AddedOn,
                w.WarehouseId,
                w.WarehouseName,
                w.OrderDate
            }).ToList();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }
    }

}
