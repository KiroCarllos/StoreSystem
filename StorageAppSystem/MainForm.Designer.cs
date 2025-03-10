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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            warehouseMultiReportToolStripMenuItem = new ToolStripMenuItem();
            transferBulkProductsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(216, 196, 182);
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
            cRUDSToolStripMenuItem.BackColor = Color.FromArgb(216, 196, 182);
            cRUDSToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            cRUDSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { warehousesToolStripMenuItem, suppliersToolStripMenuItem, productsToolStripMenuItem, clientsToolStripMenuItem, supplyOrdersToolStripMenuItem, clientOrdersToolStripMenuItem });
            cRUDSToolStripMenuItem.ForeColor = Color.FromArgb(62, 88, 121);
            cRUDSToolStripMenuItem.Name = "cRUDSToolStripMenuItem";
            cRUDSToolStripMenuItem.Size = new Size(70, 24);
            cRUDSToolStripMenuItem.Text = "CRUDS";
            // 
            // warehousesToolStripMenuItem
            // 
            warehousesToolStripMenuItem.BackColor = Color.FromArgb(216, 196, 182);
            warehousesToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            warehousesToolStripMenuItem.ForeColor = Color.FromArgb(62, 88, 121);
            warehousesToolStripMenuItem.Name = "warehousesToolStripMenuItem";
            warehousesToolStripMenuItem.Size = new Size(185, 26);
            warehousesToolStripMenuItem.Text = "Warehouses";
            warehousesToolStripMenuItem.Click += warehousesBtn_Click;
            // 
            // suppliersToolStripMenuItem
            // 
            suppliersToolStripMenuItem.BackColor = Color.FromArgb(216, 196, 182);
            suppliersToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            suppliersToolStripMenuItem.ForeColor = Color.FromArgb(62, 88, 121);
            suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            suppliersToolStripMenuItem.Size = new Size(185, 26);
            suppliersToolStripMenuItem.Text = "Suppliers";
            suppliersToolStripMenuItem.Click += supplierBtn_Click;
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.BackColor = Color.FromArgb(216, 196, 182);
            productsToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            productsToolStripMenuItem.ForeColor = Color.FromArgb(62, 88, 121);
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(185, 26);
            productsToolStripMenuItem.Text = "Products";
            productsToolStripMenuItem.Click += ProductsBtn_Click;
            // 
            // clientsToolStripMenuItem
            // 
            clientsToolStripMenuItem.BackColor = Color.FromArgb(216, 196, 182);
            clientsToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            clientsToolStripMenuItem.ForeColor = Color.FromArgb(62, 88, 121);
            clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            clientsToolStripMenuItem.Size = new Size(185, 26);
            clientsToolStripMenuItem.Text = "Clients";
            clientsToolStripMenuItem.Click += clientsBtn_Click;
            // 
            // supplyOrdersToolStripMenuItem
            // 
            supplyOrdersToolStripMenuItem.BackColor = Color.FromArgb(216, 196, 182);
            supplyOrdersToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            supplyOrdersToolStripMenuItem.ForeColor = Color.FromArgb(62, 88, 121);
            supplyOrdersToolStripMenuItem.Name = "supplyOrdersToolStripMenuItem";
            supplyOrdersToolStripMenuItem.Size = new Size(185, 26);
            supplyOrdersToolStripMenuItem.Text = "Supply Orders";
            supplyOrdersToolStripMenuItem.Click += supplyOrderBtn_Click;
            // 
            // clientOrdersToolStripMenuItem
            // 
            clientOrdersToolStripMenuItem.BackColor = Color.FromArgb(216, 196, 182);
            clientOrdersToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            clientOrdersToolStripMenuItem.ForeColor = Color.FromArgb(62, 88, 121);
            clientOrdersToolStripMenuItem.Name = "clientOrdersToolStripMenuItem";
            clientOrdersToolStripMenuItem.Size = new Size(185, 26);
            clientOrdersToolStripMenuItem.Text = "Client Orders";
            clientOrdersToolStripMenuItem.Click += releaseBtn_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.BackColor = Color.FromArgb(216, 196, 182);
            reportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { warehouseReportToolStripMenuItem, productsReportToolStripMenuItem, ordersReportToolStripMenuItem, expirayReportToolStripMenuItem, warehouseMultiReportToolStripMenuItem });
            reportsToolStripMenuItem.ForeColor = Color.FromArgb(62, 88, 121);
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(74, 24);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // warehouseReportToolStripMenuItem
            // 
            warehouseReportToolStripMenuItem.BackColor = Color.FromArgb(216, 196, 182);
            warehouseReportToolStripMenuItem.ForeColor = Color.FromArgb(62, 88, 121);
            warehouseReportToolStripMenuItem.Name = "warehouseReportToolStripMenuItem";
            warehouseReportToolStripMenuItem.Size = new Size(248, 26);
            warehouseReportToolStripMenuItem.Text = "Warehouse Report";
            warehouseReportToolStripMenuItem.Click += warehouseReportToolStripMenuItem_Click;
            // 
            // productsReportToolStripMenuItem
            // 
            productsReportToolStripMenuItem.BackColor = Color.FromArgb(216, 196, 182);
            productsReportToolStripMenuItem.ForeColor = Color.FromArgb(62, 88, 121);
            productsReportToolStripMenuItem.Name = "productsReportToolStripMenuItem";
            productsReportToolStripMenuItem.Size = new Size(248, 26);
            productsReportToolStripMenuItem.Text = "Products Report";
            productsReportToolStripMenuItem.Click += productsReportToolStripMenuItem_Click;
            // 
            // ordersReportToolStripMenuItem
            // 
            ordersReportToolStripMenuItem.BackColor = Color.FromArgb(216, 196, 182);
            ordersReportToolStripMenuItem.ForeColor = Color.FromArgb(62, 88, 121);
            ordersReportToolStripMenuItem.Name = "ordersReportToolStripMenuItem";
            ordersReportToolStripMenuItem.Size = new Size(248, 26);
            ordersReportToolStripMenuItem.Text = "Orders Report";
            ordersReportToolStripMenuItem.Click += ordersReportToolStripMenuItem_Click;
            // 
            // expirayReportToolStripMenuItem
            // 
            expirayReportToolStripMenuItem.BackColor = Color.FromArgb(216, 196, 182);
            expirayReportToolStripMenuItem.ForeColor = Color.FromArgb(62, 88, 121);
            expirayReportToolStripMenuItem.Name = "expirayReportToolStripMenuItem";
            expirayReportToolStripMenuItem.Size = new Size(248, 26);
            expirayReportToolStripMenuItem.Text = "Expiry Report";
            expirayReportToolStripMenuItem.Click += expirayReportToolStripMenuItem_Click;
            // 
            // warehouseMultiReportToolStripMenuItem
            // 
            warehouseMultiReportToolStripMenuItem.BackColor = Color.FromArgb(216, 196, 182);
            warehouseMultiReportToolStripMenuItem.ForeColor = Color.FromArgb(62, 88, 121);
            warehouseMultiReportToolStripMenuItem.Name = "warehouseMultiReportToolStripMenuItem";
            warehouseMultiReportToolStripMenuItem.Size = new Size(248, 26);
            warehouseMultiReportToolStripMenuItem.Text = "WarehouseMulti Report";
            warehouseMultiReportToolStripMenuItem.Click += warehouseMultiReportToolStripMenuItem_Click;
            // 
            // transferBulkProductsToolStripMenuItem
            // 
            transferBulkProductsToolStripMenuItem.BackColor = Color.FromArgb(216, 196, 182);
            transferBulkProductsToolStripMenuItem.ForeColor = Color.FromArgb(62, 88, 121);
            transferBulkProductsToolStripMenuItem.Name = "transferBulkProductsToolStripMenuItem";
            transferBulkProductsToolStripMenuItem.Size = new Size(168, 24);
            transferBulkProductsToolStripMenuItem.Text = "Transfer Bulk Products";
            transferBulkProductsToolStripMenuItem.Click += transferProduct_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 53, 85);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1009, 573);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            ForeColor = Color.FromArgb(245, 239, 231);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private ToolStripMenuItem warehouseMultiReportToolStripMenuItem;
    }
}
