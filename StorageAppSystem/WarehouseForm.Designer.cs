namespace StorageAppSystem
{
    partial class WarehouseForm
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
            nameTextBox = new TextBox();
            addressTextBox = new TextBox();
            managerTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            addBtn = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.Location = new Point(23, 27);
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
            dataGridView1.Location = new Point(312, 31);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(555, 351);
            dataGridView1.TabIndex = 2;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(107, 83);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(199, 27);
            nameTextBox.TabIndex = 3;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(107, 156);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(199, 27);
            addressTextBox.TabIndex = 4;
            // 
            // managerTextBox
            // 
            managerTextBox.Location = new Point(107, 237);
            managerTextBox.Name = "managerTextBox";
            managerTextBox.Size = new Size(199, 27);
            managerTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 31);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 7;
            label1.Text = "Warehouses";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 86);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 8;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 157);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 9;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 241);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 10;
            label4.Text = "Manager";
            // 
            // addBtn
            // 
            addBtn.Location = new Point(8, 318);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 51);
            addBtn.TabIndex = 11;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(108, 318);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(94, 51);
            editBtn.TabIndex = 12;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(212, 317);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 51);
            deleteBtn.TabIndex = 13;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // WarehouseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 391);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(addBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(managerTextBox);
            Controls.Add(addressTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(dataGridView1);
            Controls.Add(backBtn);
            Name = "WarehouseForm";
            Load += WarehouseForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backBtn;
        private DataGridView dataGridView1;
        private TextBox nameTextBox;
        private TextBox addressTextBox;
        private TextBox managerTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button addBtn;
        private Button editBtn;
        private Button deleteBtn;
    }
}