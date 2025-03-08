using MetroFramework.Forms;
using Microsoft.EntityFrameworkCore;
using StorageAppSystem.Data;
using StorageAppSystem.Models;
using StorageAppSystem.ReportForms;

namespace StorageAppSystem
{
    public partial class MainForm : Form
    {
        private readonly AppDBContext db;

        public MainForm()
        {
            InitializeComponent();
            db = new AppDBContext();
            db.Database.EnsureCreated();
            db.Database.Migrate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadProducts();
            loadWarehouses();
        }

        private void warehouseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedWarehouse = warehouseComboBox.SelectedItem.ToString();
            if (selectedWarehouse == "All Warehouses")
            {
                loadProducts();
            }
            else
            {
                dataGridView1.DataSource = null;
                //.Where(p => p.Warehouse.Name == selectedWarehouse)
                //, Warehouse = p.Warehouse.Name
                var products = db.products.Select(p => new { p.Id, p.Name, p.AddedOn }).ToList();
                dataGridView1.DataSource = products;
            }
        }

        private void loadProducts()
        {
            dataGridView1.DataSource = null;
            //, Warehouse = p.Warehouse.Name
            var products = db.products.Select(p => new { p.Id, p.Name, p.AddedOn }).ToList();
            dataGridView1.DataSource = products;
        }
        private void loadWarehouses()
        {
            warehouseComboBox.Items.Clear();
            var warehouses = db.warehouses.Select(w => w.Name).ToArray();
            warehouseComboBox.Items.Add("All Warehouses");
            warehouseComboBox.SelectedIndex = 0;
            warehouseComboBox.Items.AddRange(warehouses);
        }

        private void warehousesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            WarehouseForm warehouseForm = new WarehouseForm();
            warehouseForm.Show();
        }

        private void clientsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientForm clientForm = new ClientForm();
            clientForm.Show();
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MetroForm supplierForm = new SupplierForm();
            supplierForm.Show();
        }

        private void ProductsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductForm productForm = new ProductForm();
            productForm.Show();
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportForm reportForm = new ReportForm();
            reportForm.Show();
        }

        private void supplyOrderBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupplyOrderForm supplyOrderForm = new SupplyOrderForm();
            supplyOrderForm.Show();
        }

        private void releaseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SaleForm form = new SaleForm();
            form.Show();
        }
        private void transferProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferProductForm form = new TransferProductForm();
            form.Show();
        }

        private void expirayReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExpiryForm form = new ExpiryForm();
            form.Show();
        }

        private void ordersReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm form = new OrderForm();
            form.Show();
        }

        private void productsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductReportForm form = new ProductReportForm();
            form.Show();
        }

        private void warehouseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            WarehouseReportForm form = new WarehouseReportForm();
            form.Show();
        }

        private void warehouseMultiReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            WarehouseMultiSelectReportForm form = new WarehouseMultiSelectReportForm();
            form.Show();
        }
    }
}
