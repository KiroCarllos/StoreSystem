using MetroFramework.Forms;
using Microsoft.EntityFrameworkCore;
using StorageAppSystem.Data;
using StorageAppSystem.Dtos;
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
    public partial class SaleForm : Form
    {
        AppDBContext db;
        List<Order> orders = new List<Order>();
        List<Warehouse> warehouses = new List<Warehouse>();
        List<ProductOrderDto> oldOrderData = new List<ProductOrderDto>();
        public SaleForm()
        {
            InitializeComponent();
            db = new AppDBContext();
            warehouses.Add(new Warehouse { Id = 0, Name = "All Warehouses" });
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            SaleAddForm main = new SaleAddForm();
            main.Show();
            this.Close();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            loadOrders();
            ordersDataGridView.ClearSelection();
        }
        private void loadOrders()
        {
            orders.AddRange(db.orders.Include(q => q.Client).Include(q => q.Warehouse).ToList());
            warehouses.AddRange(db.warehouses.ToList());
            ordersDataGridView.DataSource = orders.Select(o => new
            {
                o.Id,
                o.OrderNumber,
                Warehouse = o.Warehouse.Name,
                Client = o.Client.Name,
                o.OrderDate,
            }).ToList();

            ordersDataGridView.ClearSelection();
            wareComboBox.Items.Clear();
            wareComboBox.Items.AddRange(warehouses.Select(w => w.Name).ToArray());



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

        private void orderDataGridView_Click(object sender, EventArgs e)
        {
            if (ordersDataGridView.SelectedRows.Count > 0)
            {
                var selectedWarehouse = ordersDataGridView.SelectedRows[0].Cells["Warehouse"].Value.ToString();
                wareComboBox.SelectedIndex = wareComboBox.Items.IndexOf(selectedWarehouse);
                var wareHouseId = warehouses.FirstOrDefault(w => w.Name == selectedWarehouse).Id;
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


                var orderId = (int)ordersDataGridView.SelectedRows[0].Cells[0].Value;
                oldOrderData = db.orderDetails
                    .Include(o => o.Product)
                    .Include(o => o.Order)
                    .Where(o => o.OrderId == orderId)
                    .Select(o => new ProductOrderDto
                    {
                        Id = o.Product.Id,
                        Name = o.Product.Name,
                        Qty = o.Qty,
                        Supplier = o.Supplier.Name
                    }).ToList();
                clientProductDataGridView.Rows.Clear();
                foreach (var item in oldOrderData)
                {
                    clientProductDataGridView.Rows.Add(item.Id, item.Name, item.Qty, item.Supplier);
                }
            }
        }

        private void wareProductDataGridView_Click(object sender, EventArgs e)
        {
            if (wareProductDataGridView.SelectedRows.Count > 0)
            {
                var productId = (int)wareProductDataGridView.SelectedRows[0].Cells[0].Value;
                var productName = (string)wareProductDataGridView.SelectedRows[0].Cells[1].Value;
                var Supplier = (string)wareProductDataGridView.SelectedRows[0].Cells[3].Value;
                var maxQty = getLatestMaxQty(productId, Supplier);
                string qtyInput = Helper.ShowQtyInputDialogBox("Enter Quantity", $"Please enter a quantity (max: {maxQty}):", maxQty);
                if (!string.IsNullOrEmpty(qtyInput))
                {
                    AddOrUpdateRow(productId, productName, int.Parse(qtyInput), Supplier);
                }
            }
        }
        private int getLatestMaxQty(int productId, string Supplier)
        {
            var maxQty = (int)wareProductDataGridView.SelectedRows[0].Cells[2].Value;
            int alreadyAddedQty = 0;
            foreach (DataGridViewRow row in clientProductDataGridView.Rows)
            {
                if (row.Cells[0].Value is int cellValue && cellValue == productId)
                {
                    var cellQty = (int)row.Cells[2].Value;
                    var oldQty = oldOrderData.Where(o => o.Id == productId).FirstOrDefault().Qty;

                    alreadyAddedQty += cellQty - oldQty;
                }
            }
            return maxQty - alreadyAddedQty;
        }

        private void AddOrUpdateRow(int id, string name, int qtyInput, string Supplier)
        {
            bool found = false;

            foreach (DataGridViewRow row in clientProductDataGridView.Rows)
            {
                // check by id and supplier name
                var prod_id = int.Parse(row.Cells["Id"].Value.ToString());
                if (prod_id == id && row.Cells["Supplier"].Value.ToString() == Supplier)
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


        private void editQtyCell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv == null) return;

                var productId = (int)dgv.Rows[e.RowIndex].Cells[0].Value;
                var productName = (string)dgv.Rows[e.RowIndex].Cells[1].Value;
                var supplier = (string)dgv.Rows[e.RowIndex].Cells[3].Value;

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
                    if (row.Index != e.RowIndex && row.Cells[0].Value != null && (int)row.Cells[0].Value == productId && row.Cells[3].Value == supplier)
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (ordersDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to save.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                var orderId = (int)ordersDataGridView.SelectedRows[0].Cells[0].Value;
                var order = db.orders.Include(o => o.OrderDetails).FirstOrDefault(o => o.Id == orderId);
                if (order == null)
                {
                    MessageBox.Show("Order not found.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                order.OrderDetails.Clear();
                foreach (DataGridViewRow row in clientProductDataGridView.Rows)
                {
                    var productId = (int)row.Cells[0].Value;
                    var qty = (int)row.Cells[2].Value;
                    var supplier = row.Cells[3].Value.ToString();
                    order.OrderDetails.Add(new OrderDetail
                    {
                        OrderId = orderId,
                        ProductId = productId,
                        Qty = qty,
                        SupplierId = db.suppliers.FirstOrDefault(s => s.Name == supplier).Id
                    });
                }
                db.SaveChanges();
                MessageBox.Show("Order saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetBtn_Click(sender, e);
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            wareComboBox.SelectedIndex = 0;
            wareProductDataGridView.DataSource = null;
            clientProductDataGridView.Rows.Clear();

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (ordersDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to save.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                var orderId = (int)ordersDataGridView.SelectedRows[0].Cells[0].Value;
                var order = db.orders.Include(o => o.OrderDetails).FirstOrDefault(o => o.Id == orderId);
                if (order == null)
                {
                    MessageBox.Show("Order not found.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                order.OrderDetails.Clear();
                db.orders.Remove(order);
                db.SaveChanges();
                MessageBox.Show("Order deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetBtn_Click(sender, e);
                loadOrders();
            }
        }

        private void wareComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
