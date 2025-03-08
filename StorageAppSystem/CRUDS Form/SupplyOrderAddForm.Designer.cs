namespace StorageAppSystem
{
    partial class SupplyOrderAddForm
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
            dataGridView1 = new DataGridView();
            warehouseCombobox = new ComboBox();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.Location = new Point(5, 27);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(94, 29);
            backBtn.TabIndex = 1;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 100);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(297, 260);
            dataGridView1.TabIndex = 2;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // warehouseCombobox
            // 
            warehouseCombobox.FormattingEnabled = true;
            warehouseCombobox.Location = new Point(108, 387);
            warehouseCombobox.Name = "warehouseCombobox";
            warehouseCombobox.Size = new Size(194, 28);
            warehouseCombobox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 390);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 4;
            label1.Text = "Warehouse";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(308, 63);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(799, 410);
            dataGridView2.TabIndex = 7;
            dataGridView2.KeyDown += dataGridView2_KeyDown;
            // 
            // button1
            // 
            button1.Location = new Point(5, 425);
            button1.Name = "button1";
            button1.Size = new Size(297, 48);
            button1.TabIndex = 8;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 63);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 9;
            label3.Text = "Select Products";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(329, 36);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 10;
            label4.Text = "Selected Products";
            // 
            // SupplyOrderAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 476);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(warehouseCombobox);
            Controls.Add(dataGridView1);
            Controls.Add(backBtn);
            Name = "SupplyOrderAddForm";
            Resizable = false;
            Load += SupplyOrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backBtn;
        private DataGridView dataGridView1;
        private ComboBox warehouseCombobox;
        private Label label1;
        private DataGridView dataGridView2;
        private Button button1;
        private Label label3;
        private Label label4;
    }
}