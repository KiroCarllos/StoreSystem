namespace StorageAppSystem
{
    partial class ClientForm
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
            deleteBtn = new Button();
            editBtn = new Button();
            addBtn = new Button();
            label4 = new Label();
            label2 = new Label();
            emailTextBox = new TextBox();
            nameTextBox = new TextBox();
            dataGridView1 = new DataGridView();
            backBtn = new Button();
            label5 = new Label();
            faxTextBox = new TextBox();
            label6 = new Label();
            phoneTextBox = new TextBox();
            label7 = new Label();
            websiteTextBox = new TextBox();
            button1 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(216, 196, 182);
            deleteBtn.FlatStyle = FlatStyle.Popup;
            deleteBtn.ForeColor = Color.FromArgb(33, 53, 85);
            deleteBtn.Location = new Point(261, 392);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 51);
            deleteBtn.TabIndex = 24;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.FromArgb(216, 196, 182);
            editBtn.FlatStyle = FlatStyle.Popup;
            editBtn.ForeColor = Color.FromArgb(33, 53, 85);
            editBtn.Location = new Point(161, 392);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(94, 51);
            editBtn.TabIndex = 23;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(216, 196, 182);
            addBtn.FlatStyle = FlatStyle.Popup;
            addBtn.ForeColor = Color.FromArgb(33, 53, 85);
            addBtn.Location = new Point(61, 392);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 51);
            addBtn.TabIndex = 22;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 237);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 21;
            label4.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 133);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 19;
            label2.Text = "Name";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(121, 237);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(218, 27);
            emailTextBox.TabIndex = 17;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(121, 133);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(217, 27);
            nameTextBox.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(739, 71);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(555, 351);
            dataGridView1.TabIndex = 14;
            dataGridView1.SelectionChanged += dataGridView1_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(216, 196, 182);
            backBtn.FlatStyle = FlatStyle.Popup;
            backBtn.ForeColor = Color.FromArgb(33, 53, 85);
            backBtn.Location = new Point(12, 9);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(78, 29);
            backBtn.TabIndex = 25;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 289);
            label5.Name = "label5";
            label5.Size = new Size(30, 20);
            label5.TabIndex = 27;
            label5.Text = "Fax";
            // 
            // faxTextBox
            // 
            faxTextBox.Location = new Point(121, 289);
            faxTextBox.Name = "faxTextBox";
            faxTextBox.Size = new Size(217, 27);
            faxTextBox.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 185);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 29;
            label6.Text = "Phone";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(121, 185);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(218, 27);
            phoneTextBox.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 333);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 31;
            label7.Text = "Website";
            // 
            // websiteTextBox
            // 
            websiteTextBox.Location = new Point(121, 333);
            websiteTextBox.Name = "websiteTextBox";
            websiteTextBox.Size = new Size(217, 27);
            websiteTextBox.TabIndex = 30;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(216, 196, 182);
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.FromArgb(33, 53, 85);
            button1.Location = new Point(832, 36);
            button1.Name = "button1";
            button1.Size = new Size(365, 29);
            button1.TabIndex = 32;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            button1.Click += reset_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(359, 14);
            label3.Name = "label3";
            label3.Size = new Size(175, 56);
            label3.TabIndex = 53;
            label3.Text = "Clients";
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 53, 85);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1321, 447);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(websiteTextBox);
            Controls.Add(label6);
            Controls.Add(phoneTextBox);
            Controls.Add(label5);
            Controls.Add(faxTextBox);
            Controls.Add(backBtn);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(addBtn);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(emailTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(dataGridView1);
            ForeColor = Color.Gray;
            Name = "ClientForm";
            Text = "Client";
            Load += ClientForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteBtn;
        private Button editBtn;
        private Button addBtn;
        private Label label4;
        private Label label2;
        private TextBox emailTextBox;
        private TextBox nameTextBox;
        private Button backBtn;
        private Label label5;
        private TextBox faxTextBox;
        private Label label6;
        private TextBox phoneTextBox;
        private Label label7;
        private TextBox websiteTextBox;
        private Button button1;
        private Label label3;
        private DataGridView dataGridView1;
    }
}