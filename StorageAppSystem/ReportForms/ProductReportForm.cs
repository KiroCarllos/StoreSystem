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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageAppSystem.ReportForms
{
    public partial class ProductReportForm : Form
    {
        AppDBContext db;
        List<WarehouseProductDto> warehouseProducts = new List<WarehouseProductDto>();
        public ProductReportForm()
        {
            InitializeComponent();
            db = new AppDBContext();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Close();
        }

        private void ProductReportForm_Load(object sender, EventArgs e)
        {
            warehouseProducts = db.supplyOrderDetails.Include(sod => sod.SupplyOrder).Select(sod => new WarehouseProductDto
            {
                Id = sod.ProductId,
                Name = sod.Product.Name,
                Barcode = sod.Product.Barcode,
                AddedOn = sod.Product.AddedOn,
                WarehouseId = sod.SupplyOrder.WarehouseId,
                WarehouseName = sod.SupplyOrder.Warehouse.Name,
            }).Distinct().ToList();
            var data = warehouseProducts.Select(wp => new { wp.Id, wp.Name, wp.Barcode, wp.AddedOn, wp.WarehouseName, wp.WarehouseId }).ToList();
            dataGridView1.DataSource = data;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            fromDateTimePicker.Value = DateTime.Now;
            toDateTimePicker.Value = DateTime.Now;
            var data = warehouseProducts.Select(wp => new { wp.Id, wp.Name, wp.Barcode, wp.AddedOn, wp.WarehouseName ,wp.WarehouseId}).ToList();
            dataGridView1.DataSource = data;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "")
            {
                dataGridView1.DataSource = warehouseProducts.Where(wp => wp.Name.ToLower().Contains(nameTextBox.Text.ToLower())).ToList();
            }
            else
            {
                dataGridView1.DataSource = warehouseProducts;
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = warehouseProducts.Where(wp => wp.AddedOn >= fromDateTimePicker.Value && wp.AddedOn <= toDateTimePicker.Value).Where(wp => wp.Name.ToLower().Contains(nameTextBox.Text.ToLower())).ToList();
        }
    }
}
