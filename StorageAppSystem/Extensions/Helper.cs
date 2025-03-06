using StorageAppSystem.Data;
using StorageAppSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageAppSystem.Extensions
{

    public static class Helper
    {
        public static List<string> GetSuppliers(AppDBContext dbContext)
        {
            return dbContext.suppliers.Select(s=>s.Name).ToList();
        }

        public static string ShowInputDialogBox(string title, string prompt)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();
            ComboBox supplierComboBox = new ComboBox();
            Label supplierLabel = new Label();
            Label productionDateLabel = new Label();
            Label expiryDateLabel = new Label();
            Label qtyLabel = new Label();
            DateTimePicker productionDatePicker = new DateTimePicker();
            DateTimePicker expiryDatePicker = new DateTimePicker();

            // Form settings
            form.Text = title;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ClientSize = new Size(350, 250);

            // Labels
            label.Text = prompt;
            supplierLabel.Text = "Supplier:";
            productionDateLabel.Text = "Production Date:";
            expiryDateLabel.Text = "Expiry Date:";
            qtyLabel.Text = "Qty:";

            // Supplier ComboBox (Example: Load suppliers from DB)
            supplierComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            supplierComboBox.Items.AddRange(GetSuppliers(new AppDBContext()).ToArray());
            textBox.KeyPress += textBox_KeyPress;
            // OK & Cancel Buttons
            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            // Positions
            label.SetBounds(10, 10, 400, 20);
            supplierLabel.SetBounds(10, 40, 100, 20);
            supplierComboBox.SetBounds(120, 40, 200, 20);
            productionDateLabel.SetBounds(10, 70, 100, 20);
            productionDatePicker.SetBounds(120, 70, 200, 20);
            expiryDateLabel.SetBounds(10, 100, 100, 20);
            expiryDatePicker.SetBounds(120, 100, 200, 20);
            qtyLabel.SetBounds(10, 130, 100, 20);
            textBox.SetBounds(120, 130, 200, 20);
            buttonOk.SetBounds(50, 170, 100, 30);
            buttonCancel.SetBounds(180, 170, 100, 30);

            form.Controls.AddRange(new Control[] { label, supplierLabel, supplierComboBox, productionDateLabel, productionDatePicker, expiryDateLabel, expiryDatePicker,qtyLabel, textBox, buttonOk, buttonCancel });

            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            buttonOk.DialogResult = DialogResult.None;  
            buttonCancel.DialogResult = DialogResult.Cancel;

            bool isValid = false;
            buttonOk.Click += (sender, e) =>
            {
                if (supplierComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a supplier.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }else if (string.IsNullOrWhiteSpace(textBox.Text) || !int.TryParse(textBox.Text, out _))
                {
                    MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }else if (productionDatePicker.Value > expiryDatePicker.Value)
                {
                    MessageBox.Show("Production date cannot be after expiry date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    isValid = true;
                }

                form.DialogResult = DialogResult.OK;
                form.Close();
            };

            DialogResult dialogResult = form.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                return $"Supplier: {supplierComboBox.SelectedItem}, " +
                       $"Production Date: {productionDatePicker.Value.ToShortDateString()}, " +
                       $"Expiry Date: {expiryDatePicker.Value.ToShortDateString()}, " +
                       $"Quantity: {textBox.Text}";
            }

            return null;
        }


        public static string ShowQtyInputDialogBox(string title, string prompt, int maxQty)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ClientSize = new Size(300, 150);

            label.Text = prompt;
            label.SetBounds(10, 10, 280, 20);

            textBox.SetBounds(10, 40, 260, 20);
            textBox.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            };

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.SetBounds(40, 80, 100, 30);
            buttonCancel.SetBounds(160, 80, 100, 30);
            buttonOk.DialogResult = DialogResult.None;
            buttonCancel.DialogResult = DialogResult.Cancel;

            buttonOk.Click += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text) || !int.TryParse(textBox.Text, out int qty))
                {
                    MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (qty > maxQty)
                {
                    MessageBox.Show($"Quantity cannot exceed {maxQty}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                form.DialogResult = DialogResult.OK;
                form.Close();
            };

            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();

            return dialogResult == DialogResult.OK ? textBox.Text : null;
        }


        private static void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        public static string GenerateInvoiceNumber()
        {
            Random random = new Random();
            return $"S-{DateTime.Now:yyyyMMdd}-{random.Next()}";
        }
    }
}
