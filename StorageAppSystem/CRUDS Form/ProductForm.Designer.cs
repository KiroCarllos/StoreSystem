namespace StorageAppSystem
{
    partial class ProductForm
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
            button1 = new Button();
            label6 = new Label();
            barcodeTextBox = new TextBox();
            deleteBtn = new Button();
            editBtn = new Button();
            addBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            nameTextBox = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.Location = new Point(7, 37);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(94, 29);
            backBtn.TabIndex = 0;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(211, 37);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 63;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 153);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 60;
            label6.Text = "Barcode";
            // 
            // barcodeTextBox
            // 
            barcodeTextBox.Location = new Point(95, 153);
            barcodeTextBox.Name = "barcodeTextBox";
            barcodeTextBox.Size = new Size(211, 27);
            barcodeTextBox.TabIndex = 59;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(211, 327);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 51);
            deleteBtn.TabIndex = 57;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(107, 328);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(94, 51);
            editBtn.TabIndex = 56;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(7, 328);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 51);
            addBtn.TabIndex = 55;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 84);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 53;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 41);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 52;
            label1.Text = "Products";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(95, 84);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(210, 27);
            nameTextBox.TabIndex = 50;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(311, 41);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(555, 351);
            dataGridView1.TabIndex = 49;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 402);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(barcodeTextBox);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(addBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nameTextBox);
            Controls.Add(dataGridView1);
            Controls.Add(backBtn);
            Name = "ProductForm";
            Resizable = false;
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backBtn;
        private Button button1;
        private Label label7;
        private TextBox websiteTextBox;
        private Label label6;
        private TextBox barcodeTextBox;
        private TextBox faxTextBox;
        private Button deleteBtn;
        private Button editBtn;
        private Button addBtn;
        private Label label2;
        private Label label1;
        private TextBox nameTextBox;
        private DataGridView dataGridView1;
    }
}