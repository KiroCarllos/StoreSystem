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
    public partial class ExpiryForm : Form
    {
        List<ProductExpiryDto> productExpiryDtos;
        AppDBContext db;
        public ExpiryForm()
        {
            InitializeComponent();
            db = new AppDBContext();
            productExpiryDtos = new List<ProductExpiryDto>();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Close();
        }

        private void ExpiryForm_Load(object sender, EventArgs e)
        {
            productExpiryDtos = db.supplyOrderDetails.Select(s => new ProductExpiryDto
            {
                Id = s.Product.Id,
                Name = s.Product.Name,
                Barcode = s.Product.Barcode,
                AddedOn = s.Product.AddedOn,
                WarehouseId = s.SupplyOrder.WarehouseId,
                WarehouseName = s.SupplyOrder.Warehouse.Name,
                ProductionDate = s.ProductionDate,
                ExpiryDate = s.ExpiryDate,
                RemainDaysToExpire = (s.ExpiryDate - DateTime.Now).Days
            }).ToList();

            var data = productExpiryDtos.Select(p => new
            {
                p.Id,
                p.Name,
                p.Barcode,
                p.AddedOn,
                p.WarehouseId,
                p.WarehouseName,
                p.ProductionDate,
                p.ExpiryDate,
                p.RemainDaysToExpire
            }).ToList();
            // need make if product is expired make row by red color
            dataGridView1.DataBindingComplete += (o, _) =>
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToInt32(row.Cells["RemainDaysToExpire"].Value) < 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            };
            dataGridView1.DataSource = data;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {

            var data = productExpiryDtos.Select(p => new
            {
                p.Id,
                p.Name,
                p.Barcode,
                p.AddedOn,
                p.WarehouseId,
                p.WarehouseName,
                p.ProductionDate,
                p.ExpiryDate,
                p.RemainDaysToExpire
            }).ToList();
            dataGridView1.DataSource = data;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            textBox1.Text = "";
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            var from = dateTimePicker1.Value;
            var to = dateTimePicker2.Value;
            var data = productExpiryDtos.Select(p => new
            {
                p.Id,
                p.Name,
                p.Barcode,
                p.AddedOn,
                p.WarehouseId,
                p.WarehouseName,
                p.ProductionDate,
                p.ExpiryDate,
                p.RemainDaysToExpire
            }).ToList();
            dataGridView1.DataSource = data.Where(d => d.ExpiryDate >= from && d.ExpiryDate <= to).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // make sure text is number of remain days to expire
            if (textBox1.Text.Length > 0)
            {
                if (!int.TryParse(textBox1.Text, out int days))
                {
                    MessageBox.Show("Please enter a valid number");
                    textBox1.Text = "";
                    return;
                }
                var data = productExpiryDtos.Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.Barcode,
                    p.AddedOn,
                    p.WarehouseId,
                    p.WarehouseName,
                    p.ProductionDate,
                    p.ExpiryDate,
                    p.RemainDaysToExpire
                }).ToList();
                dataGridView1.DataSource = data.Where(d => d.RemainDaysToExpire == days).ToList();
            }
            else
            {
                var data = productExpiryDtos.Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.Barcode,
                    p.AddedOn,
                    p.WarehouseId,
                    p.WarehouseName,
                    p.ProductionDate,
                    p.ExpiryDate,
                    p.RemainDaysToExpire
                }).ToList();
                dataGridView1.DataSource = data;
            }
        }
    }
}
