namespace StorageAppSystem.ReportForms
{
    partial class ExpiryForm
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
            resetBtn = new Button();
            filterBtn = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
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
            dataGridView1.BackgroundColor = Color.Black;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1135, 396);
            dataGridView1.TabIndex = 2;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = Color.FromArgb(216, 196, 182);
            resetBtn.FlatStyle = FlatStyle.Popup;
            resetBtn.ForeColor = Color.FromArgb(62, 88, 121);
            resetBtn.Location = new Point(820, 22);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(94, 29);
            resetBtn.TabIndex = 8;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // filterBtn
            // 
            filterBtn.BackColor = Color.FromArgb(216, 196, 182);
            filterBtn.FlatStyle = FlatStyle.Popup;
            filterBtn.ForeColor = Color.FromArgb(62, 88, 121);
            filterBtn.Location = new Point(934, 22);
            filterBtn.Name = "filterBtn";
            filterBtn.Size = new Size(94, 29);
            filterBtn.TabIndex = 7;
            filterBtn.Text = "Filter";
            filterBtn.UseVisualStyleBackColor = false;
            filterBtn.Click += filterBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(216, 196, 182);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(resetBtn);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(filterBtn);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.ForeColor = Color.FromArgb(62, 88, 121);
            groupBox1.Location = new Point(121, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1050, 63);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 17;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 32);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 18;
            label2.Text = "To";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarMonthBackground = Color.FromArgb(33, 53, 85);
            dateTimePicker2.CalendarTitleBackColor = Color.FromArgb(216, 196, 182);
            dateTimePicker2.CalendarTitleForeColor = Color.FromArgb(245, 239, 231);
            dateTimePicker2.Location = new Point(406, 28);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(33, 53, 85);
            dateTimePicker1.CalendarTitleBackColor = Color.FromArgb(216, 196, 182);
            dateTimePicker1.CalendarTitleForeColor = Color.FromArgb(245, 239, 231);
            dateTimePicker1.Location = new Point(68, 28);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1046, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(919, 87);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 19;
            label3.Text = "Remain Days";
            // 
            // ExpiryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 53, 85);
            ClientSize = new Size(1200, 533);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(backBtn);
            ForeColor = Color.Gray;
            Name = "ExpiryForm";
            Text = "ExpiryForm";
            Load += ExpiryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backBtn;
        private DataGridView dataGridView1;
        private Button resetBtn;
        private Button filterBtn;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label3;
    }
}