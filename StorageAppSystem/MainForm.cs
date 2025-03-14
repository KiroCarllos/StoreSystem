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
            Form supplierForm = new SupplierForm();
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
