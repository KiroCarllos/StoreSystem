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
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageAppSystem
{
    public partial class TransferProductForm : Form
    {
        List<Warehouse> warehouses = new List<Warehouse>();
        AppDBContext db;
        List<ProductOrderDto> oldWare1ProductData;
        List<ProductOrderDto> oldWare2ProductData;
        BindingList<ProductOrderDto> toDataGridViewData;

        public TransferProductForm()
        {
            InitializeComponent();
            warehouses.Add(new Warehouse { Id = 0, Name = "All Warehouses" });
            db = new AppDBContext();
            oldWare1ProductData = new List<ProductOrderDto>();
            oldWare2ProductData = new List<ProductOrderDto>();
            toDataGridViewData = new BindingList<ProductOrderDto>();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Close();
        }
        private void TransferProductForm_Load(object sender, EventArgs e)
        {
            warehouses.AddRange(db.warehouses.ToList());
            fromComboBox.DataSource = warehouses.Select(w => w.Name).ToArray();
            toComboBox.DataSource = null;
        }

        private void fromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var wareHouseId = warehouses[fromComboBox.SelectedIndex].Id;
            toComboBox.DataSource = warehouses.Where(w => w.Id != wareHouseId).Select(w => w.Name).ToArray();
            oldWare1ProductData = db.supplyOrderDetails
                   .Where(s => s.SupplyOrder.WarehouseId == wareHouseId)
                   .Select(p => new ProductOrderDto
                   {
                       Id = p.Product.Id,
                       Name = p.Product.Name,
                       Qty = db.supplyOrderDetails
                           .Where(so => so.ProductId == p.ProductId && so.SupplierId == p.SupplierId && so.SupplyOrder.WarehouseId == wareHouseId)
                           .Sum(so => so.Quantity)
                           - db.orderDetails
                           .Where(o => o.Order.WarehouseId == wareHouseId && o.ProductId == p.ProductId) // Ensure correct product
                           .Sum(o => o.Qty),
                       Supplier = p.Supplier.Name
                   }).Distinct().Where(p => p.Qty > 0).ToList();
            fromDataGridView.DataSource = oldWare1ProductData;

            //fromDataGridView.CellClick -= FromDataGridView_CellClick;
            //fromDataGridView.CellClick += FromDataGridView_CellClick;
            toDataGridView.DataSource = null;

        }

        private void toComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var wareHouseId = toComboBox.SelectedIndex > 0 ? warehouses.Where(w => w.Name == toComboBox.SelectedItem?.ToString()).FirstOrDefault().Id : 0;
            if (wareHouseId > 0)
            {
                toDataGridViewData.Clear();
                oldWare2ProductData = db.supplyOrderDetails
                .Where(s => s.SupplyOrder.WarehouseId == wareHouseId)
                .Select(p => new ProductOrderDto
                {
                    Id = p.Product.Id,
                    Name = p.Product.Name,
                    Qty = db.supplyOrderDetails
                        .Where(so => so.ProductId == p.ProductId && so.SupplierId == p.SupplierId && so.SupplyOrder.WarehouseId == wareHouseId)
                        .Sum(so => so.Quantity)
                        - db.orderDetails
                        .Where(o => o.Order.WarehouseId == wareHouseId && o.ProductId == p.ProductId) // Ensure correct product
                        .Sum(o => o.Qty),
                    Supplier = p.Supplier.Name
                }).Distinct().Where(p => p.Qty > 0).ToList();
                var data = oldWare2ProductData.Select(o => new { o.Id, o.Name, o.Qty, o.Supplier }).ToList();
                foreach (var item in data)
                {
                    toDataGridViewData.Add(new ProductOrderDto { Id = item.Id, Name = item.Name, Qty = item.Qty, Supplier = item.Supplier });
                }
                toDataGridView.DataSource = toDataGridViewData;
            }
        }

        private void FromDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (toComboBox.SelectedIndex != 0)
            {
                if (e.ColumnIndex == 2 && e.RowIndex >= 0)
                {
                    DataGridView dgv = sender as DataGridView;
                    if (dgv == null) return;

                    var productId = (int)dgv.Rows[e.RowIndex].Cells[0].Value;
                    var productName = (string)dgv.Rows[e.RowIndex].Cells[1].Value;
                    var supplier = (string)dgv.Rows[e.RowIndex].Cells[3].Value;

                    var maxQty = 0;
                    foreach (DataGridViewRow row in fromDataGridView.Rows)
                    {
                        if (row.Cells[0].Value != null && (int)row.Cells[0].Value == productId)
                        {
                            maxQty = (int)row.Cells[2].Value;
                            break;
                        }
                    }

                    int alreadyAddedQty = 0;
                    foreach (DataGridViewRow row in toDataGridView.Rows)
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
            else
            {
                MessageBox.Show("Please select a warehouse to transfer to.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void fromDataGridView_Click(object sender, EventArgs e)
        {
            if (fromDataGridView.SelectedRows.Count > 0 && toComboBox.SelectedIndex != 0)
            {
                var productId = (int)fromDataGridView.SelectedRows[0].Cells[0].Value;
                var productName = (string)fromDataGridView.SelectedRows[0].Cells[1].Value;
                var Supplier = (string)fromDataGridView.SelectedRows[0].Cells[3].Value;
                var maxQty = getLatestMaxQty(productId, Supplier);
                string qtyInput = Helper.ShowQtyInputDialogBox("Enter Quantity", $"Please enter a quantity (max: {maxQty}):", maxQty);
                if (!string.IsNullOrEmpty(qtyInput))
                {
                    AddOrUpdateRow(productId, productName, int.Parse(qtyInput), Supplier);
                }
            }
            else
            {
                MessageBox.Show("Please select a warehouse to transfer to.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int getLatestMaxQty(int productId, string Supplier)
        {
            // From Qty
            var maxQty = (int)fromDataGridView.SelectedRows[0].Cells[2].Value;
            int alreadyAddedQty = 0;
            foreach (DataGridViewRow row in toDataGridView.Rows)
            {
                if (row.Cells[0].Value is int cellValue && cellValue == productId && row.Cells[3].Value.ToString() == Supplier)
                {
                    // old TO Qty 
                    var oldQty = oldWare2ProductData.Where(o => o.Id == productId && o.Supplier == Supplier).FirstOrDefault()?.Qty ?? 0;

                    var cellQty = (int)row.Cells[2].Value;

                    alreadyAddedQty += cellQty - oldQty;
                }
            }
            return maxQty - alreadyAddedQty;
        }

        private void AddOrUpdateRow(int id, string name, int qtyInput, string Supplier)
        {
            bool found = false;

            foreach (DataGridViewRow row in toDataGridView.Rows)
            {
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
                toDataGridViewData.Add(new ProductOrderDto { Id = id, Name = name, Qty = qtyInput, Supplier = Supplier });
                toDataGridView.DataSource = toDataGridViewData;
                toDataGridView.Refresh();

                // toDataGridView.Rows.Add(id, name, qtyInput, Supplier);
                // MessageBox.Show(id + " " + name + " " + qtyInput + " " + Supplier);
            }
        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            if (toDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Please select a warehouse to transfer to.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                var fromWarehouseId = warehouses.Where(w => w.Name == fromComboBox.SelectedItem?.ToString()).FirstOrDefault().Id;
                var toWarehouseId = warehouses.Where(w => w.Name == toComboBox.SelectedItem?.ToString()).FirstOrDefault().Id;
                var fromDataGridViewData = fromDataGridView.DataSource as List<ProductOrderDto>;
                var toDataGridViewData = toDataGridView.DataSource as BindingList<ProductOrderDto>;
                using (var tranaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        // completed
                        foreach (ProductOrderDto product in toDataGridViewData)
                        {
                            var p = db.supplyOrderDetails.Where(s => s.SupplyOrder.WarehouseId == toWarehouseId && s.ProductId == product.Id && s.Supplier.Name == product.Supplier).FirstOrDefault();
                            if (p != null)
                            {
                                p.Quantity = product.Qty;
                            }
                            else
                            {
                                var productDetailFrom = db.supplyOrderDetails.Select(sod => new { sod.ProductionDate, sod.ExpiryDate, SupplyOrderId = sod.SupplyOrder.Id, WarehouseId = sod.SupplyOrder.WarehouseId, SupplierId = sod.SupplierId, Supplier = sod.Supplier.Name, ProductId=sod.ProductId }).Where(s => s.WarehouseId == fromWarehouseId && s.ProductId == product.Id && s.Supplier == product.Supplier).FirstOrDefault();
                                var toProduct = toDataGridViewData.FirstOrDefault();
                                var SupplyOrderId = db.supplyOrderDetails.Where(s => s.ProductId == toProduct.Id && s.Supplier.Name == toProduct.Supplier).FirstOrDefault()?.SupplyOrderId ?? 0;
                                db.supplyOrderDetails.Add(
                                    new SupplyOrderDetails
                                    {
                                        ProductId = product.Id,
                                        Quantity = product.Qty,
                                        SupplierId = productDetailFrom.SupplierId,
                                        SupplyOrderId = SupplyOrderId,
                                        ProductionDate = productDetailFrom.ProductionDate,
                                        ExpiryDate = productDetailFrom.ExpiryDate,
                                    });
                            }
                            db.SaveChanges();
                        }


                        var updatedProducts = toDataGridViewData
                             .Where(p => fromDataGridViewData.Any(f => f.Id == p.Id && f.Supplier == p.Supplier))
                            .ToList();

                        foreach (ProductOrderDto product in updatedProducts)
                        {
                            var fromProduct = fromDataGridViewData.Where(f => f.Id == product.Id && f.Supplier == product.Supplier).FirstOrDefault();
                            var oldQty = oldWare2ProductData.Where(o => o.Id == product.Id && o.Supplier == product.Supplier).FirstOrDefault()?.Qty ?? 0;
                            var newQty = product.Qty - oldQty;

                            // updateFrom Product 
                            var fromProductDetail = db.supplyOrderDetails.Where(s => s.SupplyOrder.WarehouseId == fromWarehouseId && s.ProductId == product.Id && s.Supplier.Name == product.Supplier).FirstOrDefault();
                            fromProductDetail.Quantity -=  newQty;
                            db.SaveChanges();
                        }


                            //foreach (ProductOrderDto product in fromDataGridViewData)
                            //{
                            //    var p = toDataGridViewData.Where(s => s.Id == product.Id && s.Supplier == product.Supplier).FirstOrDefault();
                            //    if (p != null)
                            //    {
                            //        var oldQty = oldWare2ProductData.Where(o => o.Id == p.Id && o.Supplier == p.Supplier).FirstOrDefault()?.Qty ?? 0;

                            //        MessageBox.Show("product_id " + product.Id.ToString() + " Qty " + oldQty + " SUPPLIER " + product.Supplier);
                            //        var newQty = product.Qty - ((toDataGridViewData.Where(p => p.Id == product.Id && p.Supplier == product.Supplier)
                            //        .FirstOrDefault()?.Qty ?? 0) - oldQty);

                            //        if (newQty == 0)
                            //        {
                            //            toDataGridViewData.Remove(p);
                            //        }
                            //        else
                            //        {
                            //            p.Qty = newQty;
                            //        }
                            //     //   MessageBox.Show("product_id " + product.Id.ToString()+" Qty " +product.Qty + " SUPPLIER " + product.Supplier );
                            //    }
                            //    db.SaveChanges();
                            //}

                            tranaction.Commit();

                        fromComboBox.SelectedIndex = 0;


                    }
                    catch (Exception ex)
                    {
                        tranaction.Rollback();
                        MessageBox.Show("Error : " + ex.Message);
                    }
                }
            }

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
