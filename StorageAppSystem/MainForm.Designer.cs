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
            menuStrip1 = new MenuStrip();
            cRUDSToolStripMenuItem = new ToolStripMenuItem();
            warehousesToolStripMenuItem = new ToolStripMenuItem();
            suppliersToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            clientsToolStripMenuItem = new ToolStripMenuItem();
            supplyOrdersToolStripMenuItem = new ToolStripMenuItem();
            clientOrdersToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            warehouseReportToolStripMenuItem = new ToolStripMenuItem();
            productsReportToolStripMenuItem = new ToolStripMenuItem();
            ordersReportToolStripMenuItem = new ToolStripMenuItem();
            expirayReportToolStripMenuItem = new ToolStripMenuItem();
            transferBulkProductsToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(436, 105);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(553, 269);
            dataGridView1.TabIndex = 1;
            // 
            // warehouseComboBox
            // 
            warehouseComboBox.FormattingEnabled = true;
            warehouseComboBox.Location = new Point(149, 134);
            warehouseComboBox.Name = "warehouseComboBox";
            warehouseComboBox.Size = new Size(264, 28);
            warehouseComboBox.TabIndex = 2;
            warehouseComboBox.SelectedIndexChanged += warehouseComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 138);
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
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cRUDSToolStripMenuItem, reportsToolStripMenuItem, transferBulkProductsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1009, 28);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // cRUDSToolStripMenuItem
            // 
            cRUDSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { warehousesToolStripMenuItem, suppliersToolStripMenuItem, productsToolStripMenuItem, clientsToolStripMenuItem, supplyOrdersToolStripMenuItem, clientOrdersToolStripMenuItem });
            cRUDSToolStripMenuItem.Name = "cRUDSToolStripMenuItem";
            cRUDSToolStripMenuItem.Size = new Size(70, 24);
            cRUDSToolStripMenuItem.Text = "CRUDS";
            // 
            // warehousesToolStripMenuItem
            // 
            warehousesToolStripMenuItem.Name = "warehousesToolStripMenuItem";
            warehousesToolStripMenuItem.Size = new Size(185, 26);
            warehousesToolStripMenuItem.Text = "Warehouses";
            warehousesToolStripMenuItem.Click += warehousesBtn_Click;
            // 
            // suppliersToolStripMenuItem
            // 
            suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            suppliersToolStripMenuItem.Size = new Size(185, 26);
            suppliersToolStripMenuItem.Text = "Suppliers";
            suppliersToolStripMenuItem.Click += supplierBtn_Click;
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(185, 26);
            productsToolStripMenuItem.Text = "Products";
            productsToolStripMenuItem.Click += ProductsBtn_Click;
            // 
            // clientsToolStripMenuItem
            // 
            clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            clientsToolStripMenuItem.Size = new Size(185, 26);
            clientsToolStripMenuItem.Text = "Clients";
            clientsToolStripMenuItem.Click += clientsBtn_Click;
            // 
            // supplyOrdersToolStripMenuItem
            // 
            supplyOrdersToolStripMenuItem.Name = "supplyOrdersToolStripMenuItem";
            supplyOrdersToolStripMenuItem.Size = new Size(185, 26);
            supplyOrdersToolStripMenuItem.Text = "Supply Orders";
            supplyOrdersToolStripMenuItem.Click += supplyOrderBtn_Click;
            // 
            // clientOrdersToolStripMenuItem
            // 
            clientOrdersToolStripMenuItem.Name = "clientOrdersToolStripMenuItem";
            clientOrdersToolStripMenuItem.Size = new Size(185, 26);
            clientOrdersToolStripMenuItem.Text = "Client Orders";
            clientOrdersToolStripMenuItem.Click += releaseBtn_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { warehouseReportToolStripMenuItem, productsReportToolStripMenuItem, ordersReportToolStripMenuItem, expirayReportToolStripMenuItem });
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(74, 24);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // warehouseReportToolStripMenuItem
            // 
            warehouseReportToolStripMenuItem.Name = "warehouseReportToolStripMenuItem";
            warehouseReportToolStripMenuItem.Size = new Size(224, 26);
            warehouseReportToolStripMenuItem.Text = "Warehouse Report";
            warehouseReportToolStripMenuItem.Click += warehouseReportToolStripMenuItem_Click;
            // 
            // productsReportToolStripMenuItem
            // 
            productsReportToolStripMenuItem.Name = "productsReportToolStripMenuItem";
            productsReportToolStripMenuItem.Size = new Size(224, 26);
            productsReportToolStripMenuItem.Text = "Products Report";
            productsReportToolStripMenuItem.Click += productsReportToolStripMenuItem_Click;
            // 
            // ordersReportToolStripMenuItem
            // 
            ordersReportToolStripMenuItem.Name = "ordersReportToolStripMenuItem";
            ordersReportToolStripMenuItem.Size = new Size(224, 26);
            ordersReportToolStripMenuItem.Text = "Orders Report";
            ordersReportToolStripMenuItem.Click += ordersReportToolStripMenuItem_Click;
            // 
            // expirayReportToolStripMenuItem
            // 
            expirayReportToolStripMenuItem.Name = "expirayReportToolStripMenuItem";
            expirayReportToolStripMenuItem.Size = new Size(224, 26);
            expirayReportToolStripMenuItem.Text = "Expiry Report";
            expirayReportToolStripMenuItem.Click += expirayReportToolStripMenuItem_Click;
            // 
            // transferBulkProductsToolStripMenuItem
            // 
            transferBulkProductsToolStripMenuItem.Name = "transferBulkProductsToolStripMenuItem";
            transferBulkProductsToolStripMenuItem.Size = new Size(168, 24);
            transferBulkProductsToolStripMenuItem.Text = "Transfer Bulk Products";
            transferBulkProductsToolStripMenuItem.Click += transferProduct_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 387);
            Controls.Add(label1);
            Controls.Add(warehouseComboBox);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private ComboBox warehouseComboBox;
        private Label label1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cRUDSToolStripMenuItem;
        private ToolStripMenuItem warehousesToolStripMenuItem;
        private ToolStripMenuItem suppliersToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem clientsToolStripMenuItem;
        private ToolStripMenuItem supplyOrdersToolStripMenuItem;
        private ToolStripMenuItem clientOrdersToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem transferBulkProductsToolStripMenuItem;
        private ToolStripMenuItem warehouseReportToolStripMenuItem;
        private ToolStripMenuItem productsReportToolStripMenuItem;
        private ToolStripMenuItem ordersReportToolStripMenuItem;
        private ToolStripMenuItem expirayReportToolStripMenuItem;
    }
}
