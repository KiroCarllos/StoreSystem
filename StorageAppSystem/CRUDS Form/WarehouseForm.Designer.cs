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
            backBtn.BackColor = Color.FromArgb(216, 196, 182);
            backBtn.FlatStyle = FlatStyle.Popup;
            backBtn.ForeColor = Color.FromArgb(62, 88, 121);
            backBtn.Location = new Point(12, 12);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(94, 29);
            backBtn.TabIndex = 1;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(216, 196, 182);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(635, 132);
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
            nameTextBox.Location = new Point(145, 175);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(199, 27);
            nameTextBox.TabIndex = 3;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(145, 248);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(199, 27);
            addressTextBox.TabIndex = 4;
            // 
            // managerTextBox
            // 
            managerTextBox.Location = new Point(145, 329);
            managerTextBox.Name = "managerTextBox";
            managerTextBox.Size = new Size(199, 27);
            managerTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(387, 9);
            label1.Name = "label1";
            label1.Size = new Size(279, 57);
            label1.TabIndex = 7;
            label1.Text = "Warehouses";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 178);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 8;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 249);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 9;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 333);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 10;
            label4.Text = "Manager";
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(216, 196, 182);
            addBtn.FlatStyle = FlatStyle.Popup;
            addBtn.ForeColor = Color.FromArgb(62, 88, 121);
            addBtn.Location = new Point(46, 410);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 51);
            addBtn.TabIndex = 11;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.FromArgb(216, 196, 182);
            editBtn.FlatStyle = FlatStyle.Popup;
            editBtn.ForeColor = Color.FromArgb(62, 88, 121);
            editBtn.Location = new Point(146, 410);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(94, 51);
            editBtn.TabIndex = 12;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(216, 196, 182);
            deleteBtn.FlatStyle = FlatStyle.Popup;
            deleteBtn.ForeColor = Color.FromArgb(62, 88, 121);
            deleteBtn.Location = new Point(250, 409);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 51);
            deleteBtn.TabIndex = 13;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // WarehouseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 53, 85);
            ClientSize = new Size(1241, 579);
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
            ForeColor = Color.Gray;
            Name = "WarehouseForm";
            Text = "Warehouses";
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