namespace StorageAppSystem
{
    partial class TransferProductForm
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
            toComboBox = new ComboBox();
            fromComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            fromDataGridView = new DataGridView();
            transferBtn = new Button();
            resetBtn = new Button();
            toDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)fromDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toDataGridView).BeginInit();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(216, 196, 182);
            backBtn.ForeColor = Color.FromArgb(62, 88, 121);
            backBtn.Location = new Point(22, 8);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(94, 29);
            backBtn.TabIndex = 0;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // toComboBox
            // 
            toComboBox.FormattingEnabled = true;
            toComboBox.Location = new Point(736, 67);
            toComboBox.Name = "toComboBox";
            toComboBox.Size = new Size(405, 28);
            toComboBox.TabIndex = 1;
            toComboBox.SelectedIndexChanged += toComboBox_SelectedIndexChanged;
            // 
            // fromComboBox
            // 
            fromComboBox.FormattingEnabled = true;
            fromComboBox.Location = new Point(138, 59);
            fromComboBox.Name = "fromComboBox";
            fromComboBox.Size = new Size(396, 28);
            fromComboBox.TabIndex = 2;
            fromComboBox.SelectedIndexChanged += fromComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 3;
            label1.Text = "Warehouse From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(630, 67);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 4;
            label2.Text = "Warehouse to";
            // 
            // fromDataGridView
            // 
            fromDataGridView.AllowUserToAddRows = false;
            fromDataGridView.BackgroundColor = Color.FromArgb(216, 196, 182);
            fromDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            fromDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            fromDataGridView.Location = new Point(12, 119);
            fromDataGridView.MultiSelect = false;
            fromDataGridView.Name = "fromDataGridView";
            fromDataGridView.RowHeadersWidth = 51;
            fromDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            fromDataGridView.Size = new Size(552, 388);
            fromDataGridView.TabIndex = 5;
            fromDataGridView.Click += fromDataGridView_Click;
            // 
            // transferBtn
            // 
            transferBtn.BackColor = Color.FromArgb(216, 196, 182);
            transferBtn.ForeColor = Color.FromArgb(62, 88, 121);
            transferBtn.Location = new Point(324, 527);
            transferBtn.Name = "transferBtn";
            transferBtn.Size = new Size(523, 29);
            transferBtn.TabIndex = 7;
            transferBtn.Text = "Transfer";
            transferBtn.UseVisualStyleBackColor = false;
            transferBtn.Click += transferBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = Color.FromArgb(216, 196, 182);
            resetBtn.ForeColor = Color.FromArgb(62, 88, 121);
            resetBtn.Location = new Point(1064, 8);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(94, 29);
            resetBtn.TabIndex = 8;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // toDataGridView
            // 
            toDataGridView.AllowUserToAddRows = false;
            toDataGridView.BackgroundColor = Color.FromArgb(216, 196, 182);
            toDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            toDataGridView.Location = new Point(606, 119);
            toDataGridView.Name = "toDataGridView";
            toDataGridView.RowHeadersWidth = 51;
            toDataGridView.Size = new Size(552, 389);
            toDataGridView.TabIndex = 9;
            // 
            // TransferProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 53, 85);
            ClientSize = new Size(1161, 615);
            Controls.Add(toDataGridView);
            Controls.Add(resetBtn);
            Controls.Add(transferBtn);
            Controls.Add(fromDataGridView);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fromComboBox);
            Controls.Add(toComboBox);
            Controls.Add(backBtn);
            ForeColor = Color.Gray;
            Name = "TransferProductForm";
            Load += TransferProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)fromDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)toDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backBtn;
        private ComboBox toComboBox;
        private ComboBox fromComboBox;
        private Label label1;
        private Label label2;
        private DataGridView fromDataGridView;
        private Button transferBtn;
        private Button resetBtn;
        private DataGridView toDataGridView;
    }
}