namespace StorageAppSystem
{
    partial class SupplyOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backBtn = new Button();
            button2 = new Button();
            orderDataGridView = new DataGridView();
            editBtn = new Button();
            productdataGridView = new DataGridView();
            warehouseCombobox = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            resetBtn = new Button();
            allProductDataGridView = new DataGridView();
            label2 = new Label();
            deleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)orderDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productdataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allProductDataGridView).BeginInit();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.Location = new Point(23, 30);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(94, 29);
            backBtn.TabIndex = 0;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1155, 30);
            button2.Name = "button2";
            button2.Size = new Size(101, 29);
            button2.TabIndex = 2;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // orderDataGridView
            // 
            orderDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDataGridView.Location = new Point(830, 77);
            orderDataGridView.Name = "orderDataGridView";
            orderDataGridView.RowHeadersWidth = 51;
            orderDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderDataGridView.Size = new Size(426, 425);
            orderDataGridView.TabIndex = 3;
            orderDataGridView.Click += orderDataGridView_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(13, 737);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(391, 69);
            editBtn.TabIndex = 12;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // productdataGridView
            // 
            productdataGridView.AllowUserToAddRows = false;
            productdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productdataGridView.Location = new Point(13, 162);
            productdataGridView.Name = "productdataGridView";
            productdataGridView.RowHeadersWidth = 51;
            productdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productdataGridView.Size = new Size(811, 569);
            productdataGridView.TabIndex = 11;
            productdataGridView.KeyDown += productdataGridView_KeyDown;
            // 
            // warehouseCombobox
            // 
            warehouseCombobox.FormattingEnabled = true;
            warehouseCombobox.Location = new Point(129, 116);
            warehouseCombobox.Name = "warehouseCombobox";
            warehouseCombobox.Size = new Size(695, 28);
            warehouseCombobox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 116);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 13;
            label1.Text = "Warehouse";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(507, 30);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 15;
            label3.Text = "Supply Orders";
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(590, 77);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(234, 29);
            resetBtn.TabIndex = 16;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // allProductDataGridView
            // 
            allProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allProductDataGridView.Location = new Point(831, 547);
            allProductDataGridView.Name = "allProductDataGridView";
            allProductDataGridView.RowHeadersWidth = 51;
            allProductDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            allProductDataGridView.Size = new Size(425, 259);
            allProductDataGridView.TabIndex = 17;
            allProductDataGridView.MouseClick += allProductDataGridView_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(831, 514);
            label2.Name = "label2";
            label2.Size = new Size(211, 20);
            label2.TabIndex = 18;
            label2.Text = "can Select Additional Products";
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(433, 737);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(391, 69);
            deleteBtn.TabIndex = 19;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // SupplyOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 808);
            Controls.Add(deleteBtn);
            Controls.Add(label2);
            Controls.Add(allProductDataGridView);
            Controls.Add(resetBtn);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(editBtn);
            Controls.Add(productdataGridView);
            Controls.Add(warehouseCombobox);
            Controls.Add(orderDataGridView);
            Controls.Add(button2);
            Controls.Add(backBtn);
            Name = "SupplyOrderForm";
            Resizable = false;
            Load += SupplyOrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)orderDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productdataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)allProductDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backBtn;
        private Button button2;
        private DataGridView orderDataGridView;
        private Button editBtn;
        private DataGridView productdataGridView;
        private ComboBox supplierComboBox;
        private ComboBox warehouseCombobox;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button resetBtn;
        private DataGridView allProductDataGridView;
        private Button deleteBtn;
    }
}