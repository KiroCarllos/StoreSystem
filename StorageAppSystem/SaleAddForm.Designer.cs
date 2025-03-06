﻿namespace StorageAppSystem
{
    partial class SaleAddForm
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
            wareProductDataGridView = new DataGridView();
            warehouseComboBox = new ComboBox();
            label1 = new Label();
            clientProductDataGridView = new DataGridView();
            client = new Label();
            clientComboBox = new ComboBox();
            addBtn = new Button();
            resetBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)wareProductDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientProductDataGridView).BeginInit();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.Location = new Point(23, 33);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(94, 29);
            backBtn.TabIndex = 1;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // wareProductDataGridView
            // 
            wareProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            wareProductDataGridView.Location = new Point(582, 33);
            wareProductDataGridView.Name = "wareProductDataGridView";
            wareProductDataGridView.RowHeadersWidth = 51;
            wareProductDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            wareProductDataGridView.Size = new Size(568, 573);
            wareProductDataGridView.TabIndex = 2;
            wareProductDataGridView.Click += wareProductDataGridView_Click;
            // 
            // warehouseComboBox
            // 
            warehouseComboBox.FormattingEnabled = true;
            warehouseComboBox.Location = new Point(211, 91);
            warehouseComboBox.Name = "warehouseComboBox";
            warehouseComboBox.Size = new Size(354, 28);
            warehouseComboBox.TabIndex = 3;
            warehouseComboBox.SelectedIndexChanged += warehouseComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 95);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 4;
            label1.Text = "Warehouse";
            // 
            // clientProductDataGridView
            // 
            clientProductDataGridView.AllowUserToAddRows = false;
            clientProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientProductDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            clientProductDataGridView.Location = new Point(23, 216);
            clientProductDataGridView.Name = "clientProductDataGridView";
            clientProductDataGridView.RowHeadersWidth = 51;
            clientProductDataGridView.Size = new Size(553, 325);
            clientProductDataGridView.TabIndex = 5;
            // 
            // client
            // 
            client.AutoSize = true;
            client.Location = new Point(23, 135);
            client.Name = "client";
            client.Size = new Size(47, 20);
            client.TabIndex = 6;
            client.Text = "Client";
            // 
            // clientComboBox
            // 
            clientComboBox.FormattingEnabled = true;
            clientComboBox.Location = new Point(211, 131);
            clientComboBox.Name = "clientComboBox";
            clientComboBox.Size = new Size(354, 28);
            clientComboBox.TabIndex = 7;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(23, 547);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(553, 59);
            addBtn.TabIndex = 8;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(482, 33);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(94, 29);
            resetBtn.TabIndex = 9;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 610);
            Controls.Add(resetBtn);
            Controls.Add(addBtn);
            Controls.Add(clientComboBox);
            Controls.Add(client);
            Controls.Add(clientProductDataGridView);
            Controls.Add(label1);
            Controls.Add(warehouseComboBox);
            Controls.Add(wareProductDataGridView);
            Controls.Add(backBtn);
            Name = "SaleForm";
            Load += SaleForm_Load;
            ((System.ComponentModel.ISupportInitialize)wareProductDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientProductDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backBtn;
        private DataGridView wareProductDataGridView;
        private ComboBox warehouseComboBox;
        private Label label1;
        private DataGridView clientProductDataGridView;
        private Label client;
        private ComboBox clientComboBox;
        private Button addBtn;
        private Button resetBtn;
    }
}