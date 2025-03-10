using MetroFramework.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
    public partial class WarehouseForm : Form
    {
        private AppDBContext db;
        public WarehouseForm()
        {
            InitializeComponent();
            db = new AppDBContext();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Close();
        }
        private void loadWarehouses()
        {
            dataGridView1.DataSource = null;
            var warehouses = db.warehouses.Select(w => new { w.Id, w.Name, w.Address, w.ManagerName }).ToList();
            dataGridView1.DataSource = warehouses;
            nameTextBox.Text = addressTextBox.Text = managerTextBox.Text = "";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || addressTextBox.Text == "" || managerTextBox.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            else
            {
                Warehouse warehouse = new Warehouse { Address = addressTextBox.Text, ManagerName = managerTextBox.Text, Name = nameTextBox.Text };
                db.Add(warehouse);
                db.SaveChanges();
                MessageBox.Show("Warehouse added successfully");
                loadWarehouses();
            }
        }

        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            loadWarehouses();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.SelectedRows[0];
            nameTextBox.Text = selectedRow.Cells["Name"].Value.ToString();
            addressTextBox.Text = selectedRow.Cells["Address"].Value.ToString();
            managerTextBox.Text = selectedRow.Cells["ManagerName"].Value.ToString();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString());
            if (nameTextBox.Text == "" || addressTextBox.Text == "" || managerTextBox.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            else
            {
                Warehouse warehouse = db.warehouses.FirstOrDefault(w => w.Id == Id);
                warehouse.Name = nameTextBox.Text;
                warehouse.Address = addressTextBox.Text;
                warehouse.ManagerName = managerTextBox.Text;
                db.SaveChanges();
                MessageBox.Show("Warehouse Updated successfully");
                loadWarehouses();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString());
            if (nameTextBox.Text == "" || addressTextBox.Text == "" || managerTextBox.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            else 
            {
                try
                {
                    Warehouse warehouse = db.warehouses.FirstOrDefault(w => w.Id == Id);
                    db.Remove(warehouse);
                    db.SaveChanges();
                    MessageBox.Show("Warehouse deleted successfully");
                    loadWarehouses();
                }
                catch (DbUpdateException ex)
                {
                    if (ex.InnerException is SqlException sqlEx && sqlEx.Number == 547)
                    {
                        MessageBox.Show("Cannot delete warehouse because it has associated products.");
                    }
                    else
                    {
                        MessageBox.Show($"Database error: {ex.Message}");
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
