namespace StorageAppSystem
{
    partial class SaleForm
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
            addBtn = new Button();
            ordersDataGridView = new DataGridView();
            wareProductDataGridView = new DataGridView();
            clientProductDataGridView = new DataGridView();
            saveBtn = new Button();
            wareComboBox = new ComboBox();
            label1 = new Label();
            resetBtn = new Button();
            deleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wareProductDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientProductDataGridView).BeginInit();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.Location = new Point(19, 31);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(94, 29);
            backBtn.TabIndex = 0;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(1123, 31);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // ordersDataGridView
            // 
            ordersDataGridView.AllowUserToAddRows = false;
            ordersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersDataGridView.Location = new Point(542, 66);
            ordersDataGridView.Name = "ordersDataGridView";
            ordersDataGridView.RowHeadersWidth = 51;
            ordersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ordersDataGridView.Size = new Size(675, 240);
            ordersDataGridView.TabIndex = 2;
            ordersDataGridView.Click += orderDataGridView_Click;
            // 
            // wareProductDataGridView
            // 
            wareProductDataGridView.AllowUserToAddRows = false;
            wareProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            wareProductDataGridView.Location = new Point(542, 312);
            wareProductDataGridView.Name = "wareProductDataGridView";
            wareProductDataGridView.RowHeadersWidth = 51;
            wareProductDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            wareProductDataGridView.Size = new Size(675, 359);
            wareProductDataGridView.TabIndex = 6;
            wareProductDataGridView.Click += wareProductDataGridView_Click;
            // 
            // clientProductDataGridView
            // 
            clientProductDataGridView.AllowUserToAddRows = false;
            clientProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientProductDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            clientProductDataGridView.Location = new Point(10, 123);
            clientProductDataGridView.Name = "clientProductDataGridView";
            clientProductDataGridView.RowHeadersWidth = 51;
            clientProductDataGridView.Size = new Size(526, 393);
            clientProductDataGridView.TabIndex = 7;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(10, 522);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(526, 71);
            saveBtn.TabIndex = 8;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // wareComboBox
            // 
            wareComboBox.FormattingEnabled = true;
            wareComboBox.Location = new Point(122, 82);
            wareComboBox.Name = "wareComboBox";
            wareComboBox.Size = new Size(414, 28);
            wareComboBox.TabIndex = 9;
            wareComboBox.SelectedIndexChanged += wareComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 85);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 10;
            label1.Text = "Warehouses";
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(442, 31);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(94, 29);
            resetBtn.TabIndex = 11;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(10, 600);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(526, 71);
            deleteBtn.TabIndex = 12;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 694);
            Controls.Add(deleteBtn);
            Controls.Add(resetBtn);
            Controls.Add(label1);
            Controls.Add(wareComboBox);
            Controls.Add(saveBtn);
            Controls.Add(clientProductDataGridView);
            Controls.Add(wareProductDataGridView);
            Controls.Add(ordersDataGridView);
            Controls.Add(addBtn);
            Controls.Add(backBtn);
            Name = "SaleForm";
            Resizable = false;
            Load += SaleForm_Load;
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)wareProductDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientProductDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backBtn;
        private Button addBtn;
        private DataGridView ordersDataGridView;
        private DataGridView wareProductDataGridView;
        private DataGridView clientProductDataGridView;
        private Button saveBtn;
        private ComboBox wareComboBox;
        private Label label1;
        private Button resetBtn;
        private Button deleteBtn;
    }
}