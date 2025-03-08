using MetroFramework.Forms;
using StorageAppSystem.Data;
using StorageAppSystem.Extensions;
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
    public partial class SupplyOrderAddForm : MetroForm
    {
        private AppDBContext db;
        public SupplyOrderAddForm()
        {
            InitializeComponent();
            db = new AppDBContext();
            dataGridView1.ClearSelection();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            SupplyOrderForm form = new SupplyOrderForm();
            form.Show();
            this.Close();
        }

        private void loadSupplyOrders()
        {
            dataGridView1.DataSource = null;
            dataGridView1.ClearSelection();
            warehouseCombobox.Items.Clear();
            var products = db.products.Select(p => new { p.Id, p.Name, p.Barcode }).ToList();
            dataGridView1.DataSource = products;

            var warehouses = db.warehouses.ToList();
            warehouseCombobox.Items.Add("Select Warehouse");
            foreach (var warehouse in warehouses)
            {
                warehouseCombobox.Items.Add(warehouse.Name);
            }
         
        }

        private void SupplyOrderForm_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            loadSupplyOrders();
            dataGridView1.ClearSelection();
            dataGridView2.Columns.Add("Id", "ID");
            dataGridView2.Columns.Add("Name", "Name");
            dataGridView2.Columns.Add("Qty", "Qty");

            DataGridViewComboBoxColumn supplierColumn = new DataGridViewComboBoxColumn();
            supplierColumn.HeaderText = "Supplier";
            supplierColumn.Name = "Supplier";
            var suppliers = db.suppliers.Select(e=>e.Name).ToArray();
            supplierColumn.Items.AddRange(suppliers);
            dataGridView2.Columns.Add(supplierColumn);


            DataGridViewTextBoxColumn productionDateColumn = new DataGridViewTextBoxColumn();
            productionDateColumn.HeaderText = "ProductionDate";
            productionDateColumn.Name = "ProductionDate";
            dataGridView2.Columns.Add(productionDateColumn);

            DataGridViewTextBoxColumn expiryDateColumn = new DataGridViewTextBoxColumn();
            expiryDateColumn.HeaderText = "ExpiryDate";
            expiryDateColumn.Name = "ExpiryDate";
            dataGridView2.Columns.Add(expiryDateColumn);

            dataGridView2.CellClick += showCalendarInCell;


            dataGridView2.Columns["Id"].ReadOnly = true;
            dataGridView2.Columns["Name"].ReadOnly = true;
            dataGridView2.Rows.Clear();
        }
        private void showCalendarInCell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == dataGridView2.Columns["ProductionDate"].Index || e.ColumnIndex == dataGridView2.Columns["ExpiryDate"].Index))
            {
                DateTimePicker dtp = new DateTimePicker();
                dataGridView2.Controls.Add(dtp);
                dtp.Format = DateTimePickerFormat.Short;
                Rectangle cellRectangle = dataGridView2.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtp.Size = new Size(cellRectangle.Width, cellRectangle.Height);
                dtp.Location = new Point(cellRectangle.X, cellRectangle.Y);
                if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DateTime dateValue;
                    if (DateTime.TryParse(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out dateValue))
                    {
                        dtp.Value = dateValue;
                    }
                }
                dtp.CloseUp += (s, args) => {
                    dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dtp.Value.ToShortDateString();
                    dtp.Visible = false;
                };

                dtp.Leave += (s, args) => { dtp.Visible = false; };

                dtp.Show();
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.CurrentRow;
                var id = selectedRow.Cells[0].Value.ToString();
                var name = selectedRow.Cells[1].Value.ToString();
                string result = Helper.ShowInputDialogBox("Enter Qty", "Please enter the quantity:");
                if (result != null)
                {
                    string[] parts = result.Split(',');
                    if (parts.Length == 4)
                    {
                        string supplier = parts[0].Replace("Supplier: ", "").Trim();
                        string productionDate = parts[1].Replace("Production Date: ", "").Trim();
                        string expiryDate = parts[2].Replace("Expiry Date: ", "").Trim();
                        string qtyInput = parts[3].Replace("Quantity: ", "").Trim();
                        DateTime productionDateValue = DateTime.Parse(productionDate);
                        DateTime expiryDateValue = DateTime.Parse(expiryDate);
                        AddOrUpdateRow(int.Parse(id), name, int.Parse(qtyInput),supplier,productionDate,expiryDate);
                    }

                }
            }
        }

        private void AddOrUpdateRow(int id, string name, int qtyInput,string supplier, string productionDate,string expiryDate)
        {
            bool found = false;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["Id"].Value != null && (int)row.Cells["Id"].Value == id) 
                {
                    int existingQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = existingQty + qtyInput; 
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                dataGridView2.Rows.Add(id, name, qtyInput,supplier ,productionDate, expiryDate); 
            }
        }
        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                {
                    if (!row.Selected)
                    {
                        dataGridView2.Rows.Remove(row);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (warehouseCombobox.SelectedItem == null )
            {
                MessageBox.Show("Please select a warehouse and atleast one product");
            }
            else
            {
                var selectedWarehouse = warehouseCombobox.SelectedItem.ToString();
               
                var selectedProducts = dataGridView2.Rows.Cast<DataGridViewRow>().Select(r => new
                {
                    ProductId = (int)r.Cells["Id"].Value,
                    Qty = (int)r.Cells["Qty"].Value,
                    Supplier = r.Cells["Supplier"].Value.ToString(),
                    ProductionDate = r.Cells["ProductionDate"].Value.ToString(),
                    ExpiryDate = r.Cells["ExpiryDate"].Value.ToString()
                }).ToList();
                if (selectedWarehouse == "Select Warehouse" || selectedProducts.Count == 0)
                {
                    MessageBox.Show("Please select a warehouse and supplier and atleast one product");
                    return;
                }
                var supplyOrder = db.supplyOrders.Add(new SupplyOrder
                {
                    WarehouseId = db.warehouses.FirstOrDefault(w => w.Name == selectedWarehouse).Id,
                    OrderDate = DateTime.Now,
                    OrderNumber = Helper.GenerateInvoiceNumber(),
                    OrderDetails = selectedProducts.Select(p => new SupplyOrderDetails
                    {
                        ProductId = p.ProductId,
                        Quantity = p.Qty,
                        ProductionDate = DateTime.Parse(p.ProductionDate),
                        ExpiryDate = DateTime.Parse(p.ExpiryDate),
                        SupplierId = db.suppliers.FirstOrDefault(s => s.Name == p.Supplier).Id
                    }).ToList()
                });
                db.SaveChanges();
                MessageBox.Show("Supply Order added successfully");
                dataGridView2.Rows.Clear();
                dataGridView1.ClearSelection();
                warehouseCombobox.SelectedIndex = 0;
            }
        }
    }
}
