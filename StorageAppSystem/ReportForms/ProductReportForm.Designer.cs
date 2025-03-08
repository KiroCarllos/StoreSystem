namespace StorageAppSystem.ReportForms
{
    partial class ProductReportForm
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
            fromDateTimePicker = new DateTimePicker();
            toDateTimePicker = new DateTimePicker();
            nameTextBox = new TextBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            searchBtn = new Button();
            label2 = new Label();
            resetBtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.Location = new Point(12, 12);
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
            dataGridView1.Location = new Point(-3, 241);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(806, 312);
            dataGridView1.TabIndex = 2;
            // 
            // fromDateTimePicker
            // 
            fromDateTimePicker.Location = new Point(84, 100);
            fromDateTimePicker.Name = "fromDateTimePicker";
            fromDateTimePicker.Size = new Size(291, 27);
            fromDateTimePicker.TabIndex = 3;
            // 
            // toDateTimePicker
            // 
            toDateTimePicker.Location = new Point(528, 93);
            toDateTimePicker.Name = "toDateTimePicker";
            toDateTimePicker.Size = new Size(250, 27);
            toDateTimePicker.TabIndex = 4;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(84, 38);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(694, 27);
            nameTextBox.TabIndex = 5;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(searchBtn);
            groupBox1.Controls.Add(toDateTimePicker);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(resetBtn);
            groupBox1.Controls.Add(fromDateTimePicker);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Location = new Point(12, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(791, 164);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "search Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 95);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 7;
            label3.Text = "To";
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(684, 129);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(94, 29);
            searchBtn.TabIndex = 8;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 100);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 6;
            label2.Text = "From";
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(569, 129);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(94, 29);
            resetBtn.TabIndex = 9;
            resetBtn.Text = "reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 41);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // ProductReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 565);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(backBtn);
            Name = "ProductReportForm";
            Text = "ProductForm";
            Load += ProductReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button backBtn;
        private DataGridView dataGridView1;
        private DateTimePicker fromDateTimePicker;
        private DateTimePicker toDateTimePicker;
        private TextBox nameTextBox;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button searchBtn;
        private Button resetBtn;
    }
}