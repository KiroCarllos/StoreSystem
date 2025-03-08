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
    public partial class SupplyOrderForm : MetroForm
    {
        private AppDBContext db;
        public SupplyOrderForm()
        {
            InitializeComponent();
            db = new AppDBContext();
            orderDataGridView.ClearSelection();
        }
        private void loadSupplyOrders()
        {
            orderDataGridView.DataSource = null;
            orderDataGridView.ClearSelection();
            warehouseCombobox.Items.Clear();
            var orders = db.supplyOrders.Select(o => new { o.Id, o.OrderNumber, Warehouse = o.Warehouse.Name, o.OrderDate }).ToList();
            orderDataGridView.DataSource = orders;

            var warehouses = db.warehouses.ToList();
            warehouseCombobox.Items.Add("Select Warehouse");
            foreach (var warehouse in warehouses)
            {
                warehouseCombobox.Items.Add(warehouse.Name);
            }
            var products = db.products.Select(p => new { p.Id, p.Name, p.Barcode }).ToList();
            allProductDataGridView.DataSource = products;
        }

        private void AddOrUpdateRow(int id, string name, int qtyInput, string Supplier, string productionDate, string expiryDate)
        {
            bool found = false;

            foreach (DataGridViewRow row in productdataGridView.Rows)
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
                productdataGridView.Rows.Add(id, name, qtyInput, Supplier, productionDate, expiryDate);
            }
        }

        private void SupplyOrderForm_Load(object sender, EventArgs e)
        {
            loadSupplyOrders();
            productdataGridView.ClearSelection();
            productdataGridView.Columns.Add("Id", "ID");
            productdataGridView.Columns.Add("Name", "Name");
            productdataGridView.Columns.Add("Qty", "Qty");

            DataGridViewComboBoxColumn supplierColumn = new DataGridViewComboBoxColumn();
            supplierColumn.HeaderText = "Supplier";
            supplierColumn.Name = "Supplier";
            var suppliers = db.suppliers.Select(e => e.Name).ToArray();
            supplierColumn.Items.AddRange(suppliers);
            productdataGridView.Columns.Add(supplierColumn);

            DataGridViewTextBoxColumn productionDateColumn = new DataGridViewTextBoxColumn();
            productionDateColumn.HeaderText = "ProductionDate";
            productionDateColumn.Name = "ProductionDate";
            productdataGridView.Columns.Add(productionDateColumn);

            DataGridViewTextBoxColumn expiryDateColumn = new DataGridViewTextBoxColumn();
            expiryDateColumn.HeaderText = "Expiry Date";
            expiryDateColumn.Name = "ExpiryDate";
            productdataGridView.Columns.Add(expiryDateColumn);

            productdataGridView.CellClick += showCalendarInCell;


            productdataGridView.Columns["Id"].ReadOnly = true;
            productdataGridView.Columns["Name"].ReadOnly = true;
            productdataGridView.Rows.Clear();

        }
        private void showCalendarInCell(object sender, DataGridViewCellEventArgs e)

        {
            if (productdataGridView.Columns.Contains("ExpiryDate"))
            {
                int expiryDateColumnIndex = productdataGridView.Columns["ExpiryDate"].Index;
            }
            else
            {
                MessageBox.Show("ExpiryDate column does not exist!");
            }

            var x = productdataGridView.Columns["ProductionDate"].Index;
            var y = productdataGridView.Columns["ExpiryDate"].Index;
            if (e.RowIndex >= 0 && (e.ColumnIndex == productdataGridView.Columns["ProductionDate"].Index || e.ColumnIndex == productdataGridView.Columns["ExpiryDate"].Index))
            {
                DateTimePicker dtp = new DateTimePicker();
                productdataGridView.Controls.Add(dtp);
                dtp.Format = DateTimePickerFormat.Short;
                Rectangle cellRectangle = productdataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtp.Size = new Size(cellRectangle.Width, cellRectangle.Height);
                dtp.Location = new Point(cellRectangle.X, cellRectangle.Y);
                if (productdataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DateTime dateValue;
                    if (DateTime.TryParse(productdataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out dateValue))
                    {
                        dtp.Value = dateValue;
                    }
                }
                dtp.CloseUp += (s, args) =>
                {
                    productdataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dtp.Value.ToShortDateString();
                    dtp.Visible = false;
                };

                dtp.Leave += (s, args) => { dtp.Visible = false; };

                dtp.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SupplyOrderAddForm main = new SupplyOrderAddForm();
            main.Show();
            this.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Close();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            orderDataGridView.ClearSelection();
            productdataGridView.Rows.Clear();
            allProductDataGridView.ClearSelection();
            warehouseCombobox.SelectedIndex = 0;
            productdataGridView.DataSource = null;
        }

        private void orderDataGridView_Click(object sender, EventArgs e)
        {
            if (orderDataGridView.SelectedRows.Count > 0)
            {
                var selectedWarehouse = orderDataGridView.SelectedRows[0].Cells[2].Value;
                warehouseCombobox.SelectedItem = selectedWarehouse;

                var selectedOrderId = int.Parse(orderDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                var orderDetails = db.supplyOrderDetails.Where(d => d.SupplyOrderId == selectedOrderId).Select(d => new { d.Product.Id, d.Product.Name, Qty = d.Quantity, Supplier = d.Supplier.Name, d.ProductionDate, d.ExpiryDate }).ToList();
                productdataGridView.Rows.Clear();
                foreach (var item in orderDetails)
                {
                    productdataGridView.Rows.Add(item.Id, item.Name, item.Qty, item.Supplier, item.ProductionDate, item.ExpiryDate);
                }
            }
        }

        private void productdataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow row in productdataGridView.SelectedRows)
                {
                    if (!row.Selected)
                    {
                        productdataGridView.Rows.Remove(row);
                    }
                }
            }
        }

        private void allProductDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (allProductDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = allProductDataGridView.CurrentRow;
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
                        int quantity = int.Parse(qtyInput);
                        AddOrUpdateRow(int.Parse(id), name, int.Parse(qtyInput), supplier, productionDate, expiryDate);
                    }
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (warehouseCombobox.SelectedItem == "Select Warehouse")
            {
                MessageBox.Show("Please select a warehouse and atleast one product");
                return;
            }
            if (orderDataGridView.SelectedRows.Count > 0)
            {
                var selectedOrderId = int.Parse(orderDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                var selectedWarehouse = warehouseCombobox.SelectedItem.ToString();
                var selectedProducts = productdataGridView.Rows.Cast<DataGridViewRow>()
                  .Where(r => r.Cells["Id"].Value != null && r.Cells["Qty"].Value != null)
                  .Select(r => new SupplyOrderDetails
                  {
                      ProductId = Convert.ToInt32(r.Cells["Id"].Value),
                      Quantity = Convert.ToInt32(r.Cells["Qty"].Value),
                      ExpiryDate = DateTime.Parse(r.Cells["ExpiryDate"].Value.ToString()),
                      ProductionDate = DateTime.Parse(r.Cells["ProductionDate"].Value.ToString()),
                      SupplierId = db.suppliers.FirstOrDefault(s => s.Name == r.Cells["Supplier"].Value.ToString()).Id
                  })
                  .ToList();
                if (selectedWarehouse == "Select Warehouse" || selectedProducts.Count == 0)
                {
                    MessageBox.Show("Please select a warehouse and atleast one product");
                    return;
                }
                else
                {
                    var order = db.supplyOrders.Find(selectedOrderId);
                    order.WarehouseId = db.warehouses.FirstOrDefault(w => w.Name == selectedWarehouse).Id;
                    // order.SupplierId = db.suppliers.FirstOrDefault(s => s.Name == selectedSupplier).Id;
                    db.RemoveRange(db.supplyOrderDetails.Where(d => d.SupplyOrderId == selectedOrderId));
                    order.OrderDetails = selectedProducts;
                    db.SaveChanges();
                    MessageBox.Show("Order updated successfully");
                    loadSupplyOrders();
                    resetBtn_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Please select a warehouse and supplier and atleast one product");
                return;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var d = MessageBox.Show("Are you sure you want to delete this order?", "Delete Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.No)
            {
                return;
            }
            else
            {
                var selectedOrderId = int.Parse(orderDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                if (selectedOrderId == 0)
                {
                    MessageBox.Show("Please select an order to delete");
                    return;
                }
                else
                {
                    var order = db.supplyOrders.Find(selectedOrderId);
                    db.RemoveRange(db.supplyOrderDetails.Where(d => d.SupplyOrderId == selectedOrderId));
                    db.supplyOrders.Remove(order);
                    db.SaveChanges();
                    MessageBox.Show("Order deleted successfully");
                    loadSupplyOrders();
                    resetBtn_Click(sender, e);
                }
            }
        }
    }
}
