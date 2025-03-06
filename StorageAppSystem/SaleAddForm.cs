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
    public partial class SaleAddForm : MetroForm
    {
        AppDBContext db;
        List<Warehouse> Warehouses = new List<Warehouse>();
        List<Client> Clients = new List<Client>();
        public SaleAddForm()
        {
            InitializeComponent();
            db = new AppDBContext();
            Warehouses.Add(new Warehouse { Id = 0, Name = "All Warehouses" });
            Clients.Add(new Client { Id = 0, Name = "All Clients" });
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            SaleForm main = new SaleForm();
            main.Show();
            this.Close();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            Warehouses.AddRange(db.warehouses.ToList());

            warehouseComboBox.Items.AddRange(Warehouses.Select(e => e.Name).ToArray());
            warehouseComboBox.SelectedIndex = 0;

            Clients.AddRange(db.clients.ToList());
            clientComboBox.Items.AddRange(Clients.Select(e => e.Name).ToArray());
            clientComboBox.SelectedIndex = 0;
            // add columns
            clientProductDataGridView.Columns.Add("Id", "ID");
            clientProductDataGridView.Columns.Add("Name", "Name");
            clientProductDataGridView.Columns.Add("Qty", "Qty");

            DataGridViewComboBoxColumn supplierColumn = new DataGridViewComboBoxColumn();
            supplierColumn.HeaderText = "Supplier";
            supplierColumn.Name = "Supplier";
            supplierColumn.ReadOnly = true;
            var suppliers = db.suppliers.Select(e => e.Name).ToArray();
            supplierColumn.Items.AddRange(suppliers);
            clientProductDataGridView.Columns.Add(supplierColumn);

            clientProductDataGridView.Columns["Id"].ReadOnly = true;
            clientProductDataGridView.Columns["Name"].ReadOnly = true;
            clientProductDataGridView.Rows.Clear();

            clientProductDataGridView.CellClick += editQtyCell;
        }
        private void editQtyCell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv == null) return;

                var productId = (int)dgv.Rows[e.RowIndex].Cells[0].Value;
                var productName = (string)dgv.Rows[e.RowIndex].Cells[1].Value;

                var maxQty = 0;
                foreach (DataGridViewRow row in wareProductDataGridView.Rows)
                {
                    if (row.Cells[0].Value != null && (int)row.Cells[0].Value == productId)
                    {
                        maxQty = (int)row.Cells[2].Value;
                        break;
                    }
                }

                int alreadyAddedQty = 0;
                foreach (DataGridViewRow row in clientProductDataGridView.Rows)
                {
                    if (row.Index != e.RowIndex && row.Cells[0].Value != null && (int)row.Cells[0].Value == productId)
                    {
                        alreadyAddedQty += (int)row.Cells[2].Value;
                    }
                }

                int remainingQty = maxQty - alreadyAddedQty;

                string qtyInput = Helper.ShowQtyInputDialogBox("Edit Quantity",
                    $"Enter Qty (max: {remainingQty}):", remainingQty);

                if (!string.IsNullOrEmpty(qtyInput) && int.TryParse(qtyInput, out int enteredQty))
                {
                    if (enteredQty > remainingQty)
                    {
                        MessageBox.Show($"Quantity cannot exceed {remainingQty}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        dgv.Rows[e.RowIndex].Cells[2].Value = enteredQty;
                    }
                }
            }
        }

        private void warehouseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var wareHouseId = Warehouses[warehouseComboBox.SelectedIndex].Id;
            var products = db.supplyOrderDetails
                            .Where(s => s.SupplyOrder.WarehouseId == wareHouseId)
                            .Select(p => new
                            {
                                p.Product.Id,
                                p.Product.Name,
                                Quantity = db.supplyOrderDetails
                                    .Where(so => so.ProductId == p.ProductId && so.SupplierId == p.SupplierId && so.SupplyOrder.WarehouseId == wareHouseId)
                                    .Sum(so => so.Quantity)
                                    - db.orderDetails
                                    .Where(o => o.Order.WarehouseId == wareHouseId && o.ProductId == p.ProductId) // Ensure correct product
                                    .Sum(o => o.Qty),
                                Supplier = p.Supplier.Name
                            }).Distinct().Where(p => p.Quantity > 0).ToList();
            wareProductDataGridView.DataSource = products;
        }

        private void wareProductDataGridView_Click(object sender, EventArgs e)
        {
            if (wareProductDataGridView.SelectedRows.Count > 0)
            {
                var productId = (int)wareProductDataGridView.SelectedRows[0].Cells[0].Value;
                var productName = (string)wareProductDataGridView.SelectedRows[0].Cells[1].Value;
                var Supplier = (string)wareProductDataGridView.SelectedRows[0].Cells[3].Value;
                var maxQty = getLatestMaxQty(productId);
                string qtyInput = Helper.ShowQtyInputDialogBox("Enter Quantity", $"Please enter a quantity (max: {maxQty}):", maxQty);
                if (!string.IsNullOrEmpty(qtyInput))
                {
                    AddOrUpdateRow(productId, productName, int.Parse(qtyInput), Supplier);
                }
            }
        }
        private void AddOrUpdateRow(int id, string name, int qtyInput, string Supplier)
        {
            bool found = false;

            foreach (DataGridViewRow row in clientProductDataGridView.Rows)
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
                clientProductDataGridView.Rows.Add(id, name, qtyInput, Supplier);
            }
        }

        private int getLatestMaxQty(int productId)
        {
            var maxQty = (int)wareProductDataGridView.SelectedRows[0].Cells[2].Value;
            int alreadyAddedQty = 0;
            foreach (DataGridViewRow row in clientProductDataGridView.Rows)
            {
                if (row.Cells[0].Value != null && (int)row.Cells[0].Value == productId)
                {
                    alreadyAddedQty += (int)row.Cells[2].Value;
                }
            }
            return maxQty - alreadyAddedQty;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var selectedWareHouseId = Warehouses[warehouseComboBox.SelectedIndex].Id;
            var selectedClientId = Clients[clientComboBox.SelectedIndex].Id;

            if (selectedWareHouseId == 0 || selectedClientId == 0 || clientProductDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Please select a warehouse & Client & at Least One Product", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                var order = new Order
                {
                    WarehouseId = selectedWareHouseId,
                    ClientId = selectedClientId,
                    OrderDate = DateTime.Now,
                    OrderNumber = Helper.GenerateInvoiceNumber(),
                };
                foreach (DataGridViewRow row in clientProductDataGridView.Rows)
                {
                    var productId = (int)row.Cells[0].Value;
                    var qty = (int)row.Cells[2].Value;
                    var supplier = row.Cells[3].Value.ToString();
                    order.OrderDetails.Add(new OrderDetail
                    {
                        ProductId = productId,
                        Qty = qty,
                        SupplierId = db.suppliers.FirstOrDefault(s => s.Name == supplier).Id,
                        OrderId = order.Id,
                    });
                }
                db.orders.Add(order);
                db.SaveChanges();
                MessageBox.Show("Order Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetBtn_Click(sender, e);
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            clientProductDataGridView.Rows.Clear();
            warehouseComboBox.SelectedIndex = 0;
            clientComboBox.SelectedIndex = 0;
            wareProductDataGridView.DataSource = null;
        }
    }
}
