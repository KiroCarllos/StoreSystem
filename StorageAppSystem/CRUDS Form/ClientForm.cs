using MetroFramework.Forms;
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
    public partial class ClientForm : Form
    {
        private AppDBContext db;
        public ClientForm()
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

        private void loadClients()
        {
            dataGridView1.DataSource = null;
            dataGridView1.ClearSelection();
            var clients = db.clients.ToList();
            dataGridView1.DataSource = clients;
            nameTextBox.Text = faxTextBox.Text = emailTextBox.Text = phoneTextBox.Text = websiteTextBox.Text = "";
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            loadClients();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                nameTextBox.Text = selectedRow.Cells["Name"].Value.ToString();
                phoneTextBox.Text = selectedRow.Cells["Phone"].Value.ToString();
                faxTextBox.Text = selectedRow.Cells["Fax"].Value.ToString();
                websiteTextBox.Text = selectedRow.Cells["Website"].Value.ToString();
                emailTextBox.Text = selectedRow.Cells["Email"].Value.ToString();
            }

        }

        private void reset_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = faxTextBox.Text = emailTextBox.Text = phoneTextBox.Text = websiteTextBox.Text = "";
            dataGridView1.ClearSelection();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || websiteTextBox.Text == "" || faxTextBox.Text == "" || emailTextBox.Text == "" || phoneTextBox.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            else
            {
                var client = new Client { Name = nameTextBox.Text, Phone = phoneTextBox.Text, Email = emailTextBox.Text, Fax = faxTextBox.Text, Website = websiteTextBox.Text };
                db.Add(client);
                db.SaveChanges();
                MessageBox.Show("Client added successfully");
                loadClients();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || websiteTextBox.Text == "" || faxTextBox.Text == "" || emailTextBox.Text == "" || phoneTextBox.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            else
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var editBtn = db.clients.FirstOrDefault(c => c.Id == int.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString()));
                    editBtn.Name = nameTextBox.Text;
                    editBtn.Phone = phoneTextBox.Text;
                    editBtn.Email = emailTextBox.Text;
                    editBtn.Fax = faxTextBox.Text;
                    editBtn.Website = websiteTextBox.Text;
                    db.SaveChanges();
                    MessageBox.Show("Client updated successfully");
                    loadClients();
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    var deleteBtn = db.clients.FirstOrDefault(c => c.Id == int.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString()));
                    db.clients.Remove(deleteBtn);
                    db.SaveChanges();
                    MessageBox.Show("Client deleted successfully");
                    loadClients();
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show("Client cannot be deleted because it is being used in other transactions");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select on Client");
            }
        }

   
    }
}
