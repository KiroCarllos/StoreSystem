namespace StorageAppSystem
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            warehouseComboBox = new ComboBox();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            warehousesBtn = new Button();
            clientsBtn = new Button();
            supplierBtn = new Button();
            ProductsBtn = new Button();
            reportsBtn = new Button();
            supplyOrderBtn = new Button();
            releaseBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(450, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(553, 610);
            dataGridView1.TabIndex = 1;
            // 
            // warehouseComboBox
            // 
            warehouseComboBox.FormattingEnabled = true;
            warehouseComboBox.Location = new Point(151, 27);
            warehouseComboBox.Name = "warehouseComboBox";
            warehouseComboBox.Size = new Size(264, 28);
            warehouseComboBox.TabIndex = 2;
            warehouseComboBox.SelectedIndexChanged += warehouseComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 31);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 3;
            label1.Text = "Warehouses";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // warehousesBtn
            // 
            warehousesBtn.Location = new Point(9, 85);
            warehousesBtn.Name = "warehousesBtn";
            warehousesBtn.Size = new Size(432, 66);
            warehousesBtn.TabIndex = 4;
            warehousesBtn.Text = "Warehouses";
            warehousesBtn.UseVisualStyleBackColor = true;
            warehousesBtn.Click += warehousesBtn_Click;
            // 
            // clientsBtn
            // 
            clientsBtn.Location = new Point(9, 165);
            clientsBtn.Name = "clientsBtn";
            clientsBtn.Size = new Size(432, 66);
            clientsBtn.TabIndex = 5;
            clientsBtn.Text = "Clients";
            clientsBtn.UseVisualStyleBackColor = true;
            clientsBtn.Click += clientsBtn_Click;
            // 
            // supplierBtn
            // 
            supplierBtn.Location = new Point(9, 245);
            supplierBtn.Name = "supplierBtn";
            supplierBtn.Size = new Size(432, 66);
            supplierBtn.TabIndex = 6;
            supplierBtn.Text = "Suppliers";
            supplierBtn.UseVisualStyleBackColor = true;
            supplierBtn.Click += supplierBtn_Click;
            // 
            // ProductsBtn
            // 
            ProductsBtn.Location = new Point(9, 325);
            ProductsBtn.Name = "ProductsBtn";
            ProductsBtn.Size = new Size(432, 66);
            ProductsBtn.TabIndex = 7;
            ProductsBtn.Text = "Products";
            ProductsBtn.UseVisualStyleBackColor = true;
            ProductsBtn.Click += ProductsBtn_Click;
            // 
            // reportsBtn
            // 
            reportsBtn.Location = new Point(9, 545);
            reportsBtn.Name = "reportsBtn";
            reportsBtn.Size = new Size(432, 66);
            reportsBtn.TabIndex = 8;
            reportsBtn.Text = "Reports";
            reportsBtn.UseVisualStyleBackColor = true;
            reportsBtn.Click += reportsBtn_Click;
            // 
            // supplyOrderBtn
            // 
            supplyOrderBtn.Location = new Point(9, 397);
            supplyOrderBtn.Name = "supplyOrderBtn";
            supplyOrderBtn.Size = new Size(432, 66);
            supplyOrderBtn.TabIndex = 9;
            supplyOrderBtn.Text = "Supply Order";
            supplyOrderBtn.UseVisualStyleBackColor = true;
            supplyOrderBtn.Click += supplyOrderBtn_Click;
            // 
            // releaseBtn
            // 
            releaseBtn.Location = new Point(9, 473);
            releaseBtn.Name = "releaseBtn";
            releaseBtn.Size = new Size(432, 66);
            releaseBtn.TabIndex = 10;
            releaseBtn.Text = "Point Of Sale";
            releaseBtn.UseVisualStyleBackColor = true;
            releaseBtn.Click += releaseBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 634);
            Controls.Add(releaseBtn);
            Controls.Add(supplyOrderBtn);
            Controls.Add(reportsBtn);
            Controls.Add(ProductsBtn);
            Controls.Add(supplierBtn);
            Controls.Add(clientsBtn);
            Controls.Add(warehousesBtn);
            Controls.Add(label1);
            Controls.Add(warehouseComboBox);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            Resizable = false;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private ComboBox warehouseComboBox;
        private Label label1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button warehousesBtn;
        private Button clientsBtn;
        private Button supplierBtn;
        private Button ProductsBtn;
        private Button reportsBtn;
        private Button supplyOrderBtn;
        private Button releaseBtn;
    }
}
