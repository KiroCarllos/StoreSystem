using MetroFramework.Forms;
using StorageAppSystem.Data;
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

namespace StorageAppSystem
{
    public partial class ProductForm : MetroForm
    {
        private AppDBContext db;
        public ProductForm()
        {
            InitializeComponent();
            db = new AppDBContext();
        }
        private void loadProducts()
        {
            dataGridView1.DataSource = null;
            dataGridView1.ClearSelection();
            nameTextBox.Text = barcodeTextBox.Text = "";
            //warehouseCombobox.Items.Clear();
            //, Warehouse = p.Warehouse.Name
            var products = db.products.Select(p => new { p.Id, p.Name, p.Barcode }).ToList();
            dataGridView1.DataSource = products;
            //var warehouses = db.warehouses.ToList();
            //warehouseCombobox.Items.Add("Select Warehouse");
            //foreach (var warehouse in warehouses)
            //{
                //warehouseCombobox.Items.Add(warehouse.Name);
            //}
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = barcodeTextBox.Text = "";
            //warehouseCombobox.SelectedIndex = 0;
            dataGridView1.ClearSelection();
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                nameTextBox.Text = selectedRow.Cells["Name"].Value.ToString();
                barcodeTextBox.Text = selectedRow.Cells["Barcode"].Value.ToString();
                //warehouseCombobox.SelectedItem = selectedRow.Cells["Warehouse"].Value.ToString();
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            loadProducts();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //|| warehouseCombobox.SelectedIndex == 0
            if (nameTextBox.Text == "" || barcodeTextBox.Text == "" )
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            else
            {
                //var warehouse = db.warehouses.FirstOrDefault(w => w.Name == warehouseCombobox.SelectedItem.ToString());
               //, Warehouse = warehouse
                var product = new Product { Name = nameTextBox.Text, Barcode = barcodeTextBox.Text };
                db.Add(product);
                db.SaveChanges();
                MessageBox.Show("Product added successfully");
                loadProducts();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            //|| warehouseCombobox.SelectedIndex == 0
            if (nameTextBox.Text == "" || barcodeTextBox.Text == "" )
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            else
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGridView1.SelectedRows[0];
                    var id = int.Parse(selectedRow.Cells["Id"].Value.ToString());
                    var product = db.products.FirstOrDefault(p => p.Id == id);
                    //var warehouse = db.warehouses.FirstOrDefault(w => w.Name == warehouseCombobox.SelectedItem.ToString());
                    product.Name = nameTextBox.Text;
                    product.Barcode = barcodeTextBox.Text;
                    //product.Warehouse = warehouse;
                    db.SaveChanges();
                    MessageBox.Show("Product updated successfully");
                    loadProducts();
                }
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //|| warehouseCombobox.SelectedIndex == 0
            if (nameTextBox.Text == "" || barcodeTextBox.Text == "" )
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            else
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var product = db.products.FirstOrDefault(p => p.Id == int.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString()));
                    db.Remove(product);
                    db.SaveChanges();
                    MessageBox.Show("Product deleted successfully");
                    loadProducts();
                }
            }
        }
    }
}
