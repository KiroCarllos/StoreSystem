namespace StorageAppSystem
{
    partial class SupplierForm
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
            label7 = new Label();
            websiteTextBox = new TextBox();
            label6 = new Label();
            phoneTextBox = new TextBox();
            label5 = new Label();
            faxTextBox = new TextBox();
            deleteBtn = new Button();
            editBtn = new Button();
            addBtn = new Button();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            emailTextBox = new TextBox();
            nameTextBox = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.Location = new Point(11, 32);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(94, 29);
            backBtn.TabIndex = 1;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(204, 32);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 48;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 287);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 47;
            label7.Text = "Website";
            // 
            // websiteTextBox
            // 
            websiteTextBox.Location = new Point(81, 287);
            websiteTextBox.Name = "websiteTextBox";
            websiteTextBox.Size = new Size(217, 27);
            websiteTextBox.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 131);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 45;
            label6.Text = "Phone";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(81, 131);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(218, 27);
            phoneTextBox.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 235);
            label5.Name = "label5";
            label5.Size = new Size(30, 20);
            label5.TabIndex = 43;
            label5.Text = "Fax";
            // 
            // faxTextBox
            // 
            faxTextBox.Location = new Point(81, 235);
            faxTextBox.Name = "faxTextBox";
            faxTextBox.Size = new Size(217, 27);
            faxTextBox.TabIndex = 42;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(204, 322);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 51);
            deleteBtn.TabIndex = 41;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(100, 323);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(94, 51);
            editBtn.TabIndex = 40;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(0, 323);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 51);
            addBtn.TabIndex = 39;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 183);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 38;
            label4.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 79);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 37;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 36);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 36;
            label1.Text = "Suppliers";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(81, 183);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(218, 27);
            emailTextBox.TabIndex = 35;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(81, 79);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(217, 27);
            nameTextBox.TabIndex = 34;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(304, 36);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(555, 351);
            dataGridView1.TabIndex = 33;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 402);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(websiteTextBox);
            Controls.Add(label6);
            Controls.Add(phoneTextBox);
            Controls.Add(label5);
            Controls.Add(faxTextBox);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(addBtn);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(emailTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(dataGridView1);
            Controls.Add(backBtn);
            Name = "SupplierForm";
            Resizable = false;
            Load += SupplierForm_Load;
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
        private TextBox phoneTextBox;
        private Label label5;
        private TextBox faxTextBox;
        private Button deleteBtn;
        private Button editBtn;
        private Button addBtn;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox emailTextBox;
        private TextBox nameTextBox;
        private DataGridView dataGridView1;
    }
}