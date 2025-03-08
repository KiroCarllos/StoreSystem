﻿namespace StorageAppSystem.ReportForms
{
    partial class WarehouseReportForm
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
            warehousesDataGridView = new DataGridView();
            fromDateTimePicker = new DateTimePicker();
            toDateTimePicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            wareProductGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)warehousesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wareProductGridView).BeginInit();
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
            // warehousesDataGridView
            // 
            warehousesDataGridView.AllowUserToAddRows = false;
            warehousesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            warehousesDataGridView.Location = new Point(12, 101);
            warehousesDataGridView.MultiSelect = false;
            warehousesDataGridView.Name = "warehousesDataGridView";
            warehousesDataGridView.RowHeadersWidth = 51;
            warehousesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            warehousesDataGridView.Size = new Size(555, 376);
            warehousesDataGridView.TabIndex = 2;
            warehousesDataGridView.MouseClick += this.warehousesDataGridView_MouseClick;
            // 
            // fromDateTimePicker
            // 
            fromDateTimePicker.Location = new Point(99, 58);
            fromDateTimePicker.Name = "fromDateTimePicker";
            fromDateTimePicker.Size = new Size(250, 27);
            fromDateTimePicker.TabIndex = 3;
            // 
            // toDateTimePicker
            // 
            toDateTimePicker.Location = new Point(660, 58);
            toDateTimePicker.Name = "toDateTimePicker";
            toDateTimePicker.Size = new Size(250, 27);
            toDateTimePicker.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 5;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(602, 65);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 6;
            label2.Text = "To";
            // 
            // wareProductGridView
            // 
            wareProductGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            wareProductGridView.Location = new Point(660, 91);
            wareProductGridView.Name = "wareProductGridView";
            wareProductGridView.RowHeadersWidth = 51;
            wareProductGridView.Size = new Size(417, 376);
            wareProductGridView.TabIndex = 7;
            // 
            // WarehouseReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 552);
            Controls.Add(wareProductGridView);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toDateTimePicker);
            Controls.Add(fromDateTimePicker);
            Controls.Add(warehousesDataGridView);
            Controls.Add(backBtn);
            Name = "WarehouseReportForm";
            Text = "WarehouseForm";
            Load += WarehouseForm_Load;
            ((System.ComponentModel.ISupportInitialize)warehousesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)wareProductGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backBtn;
        private DataGridView warehousesDataGridView;
        private DateTimePicker fromDateTimePicker;
        private DateTimePicker toDateTimePicker;
        private Label label1;
        private Label label2;
        private DataGridView wareProductGridView;
    }
}