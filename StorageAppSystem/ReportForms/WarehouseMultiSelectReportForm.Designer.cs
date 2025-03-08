namespace StorageAppSystem.ReportForms
{
    partial class WarehouseMultiSelectReportForm
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
            resetBtn = new Button();
            filterBtn = new Button();
            wareProductGridView = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            toDateTimePicker = new DateTimePicker();
            fromDateTimePicker = new DateTimePicker();
            warehousesDataGridView = new DataGridView();
            backBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)wareProductGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)warehousesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(1416, 52);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(94, 29);
            resetBtn.TabIndex = 18;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // filterBtn
            // 
            filterBtn.Location = new Point(1138, 48);
            filterBtn.Name = "filterBtn";
            filterBtn.Size = new Size(94, 29);
            filterBtn.TabIndex = 17;
            filterBtn.Text = "Filter";
            filterBtn.UseVisualStyleBackColor = true;
            filterBtn.Click += filterBtn_Click;
            // 
            // wareProductGridView
            // 
            wareProductGridView.AllowUserToAddRows = false;
            wareProductGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            wareProductGridView.Location = new Point(586, 137);
            wareProductGridView.MultiSelect = false;
            wareProductGridView.Name = "wareProductGridView";
            wareProductGridView.RowHeadersWidth = 51;
            wareProductGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            wareProductGridView.Size = new Size(930, 376);
            wareProductGridView.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(819, 52);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 15;
            label2.Text = "To";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(418, 48);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 14;
            label1.Text = "From";
            // 
            // toDateTimePicker
            // 
            toDateTimePicker.Location = new Point(860, 50);
            toDateTimePicker.Name = "toDateTimePicker";
            toDateTimePicker.Size = new Size(250, 27);
            toDateTimePicker.TabIndex = 13;
            // 
            // fromDateTimePicker
            // 
            fromDateTimePicker.Location = new Point(479, 47);
            fromDateTimePicker.Name = "fromDateTimePicker";
            fromDateTimePicker.Size = new Size(250, 27);
            fromDateTimePicker.TabIndex = 12;
            // 
            // warehousesDataGridView
            // 
            warehousesDataGridView.AllowUserToAddRows = false;
            warehousesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            warehousesDataGridView.Location = new Point(6, 137);
            warehousesDataGridView.Name = "warehousesDataGridView";
            warehousesDataGridView.RowHeadersWidth = 51;
            warehousesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            warehousesDataGridView.Size = new Size(555, 376);
            warehousesDataGridView.TabIndex = 11;
            warehousesDataGridView.MouseClick += warehousesDataGridView_MouseClick;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(6, 48);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(94, 29);
            backBtn.TabIndex = 10;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // WarehouseMultiSelectReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1514, 655);
            Controls.Add(resetBtn);
            Controls.Add(filterBtn);
            Controls.Add(wareProductGridView);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toDateTimePicker);
            Controls.Add(fromDateTimePicker);
            Controls.Add(warehousesDataGridView);
            Controls.Add(backBtn);
            Name = "WarehouseMultiSelectReportForm";
            Text = "WarehouseMultiSelectForm";
            Load += WarehouseMultiSelectReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)wareProductGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)warehousesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button resetBtn;
        private Button filterBtn;
        private DataGridView wareProductGridView;
        private Label label2;
        private Label label1;
        private DateTimePicker toDateTimePicker;
        private DateTimePicker fromDateTimePicker;
        private DataGridView warehousesDataGridView;
        private Button backBtn;
    }
}