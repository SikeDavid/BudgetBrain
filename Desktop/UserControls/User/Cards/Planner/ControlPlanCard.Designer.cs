namespace BudgetBrainDesktop.UserControls.User.Cards.Planner
{
    partial class ControlPlanCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnModify = new Button();
            btnDelete = new Button();
            panelDescription = new Panel();
            tbDescription = new TextBox();
            lblDescription = new Label();
            panelAmount = new Panel();
            tbAmount = new TextBox();
            lblAmount = new Label();
            panelDay = new Panel();
            nudDay = new NumericUpDown();
            lblDayofMonth = new Label();
            panelType = new Panel();
            cbCategory = new ComboBox();
            lblType = new Label();
            panelStatus = new Panel();
            lblStatus = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panelDescription.SuspendLayout();
            panelAmount.SuspendLayout();
            panelDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDay).BeginInit();
            panelType.SuspendLayout();
            panelStatus.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(34, 46, 59);
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 5, 0);
            tableLayoutPanel1.Controls.Add(panelDescription, 0, 0);
            tableLayoutPanel1.Controls.Add(panelAmount, 1, 0);
            tableLayoutPanel1.Controls.Add(panelDay, 2, 0);
            tableLayoutPanel1.Controls.Add(panelType, 3, 0);
            tableLayoutPanel1.Controls.Add(panelStatus, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1045, 132);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnModify, 0, 0);
            tableLayoutPanel2.Controls.Add(btnDelete, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(888, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(0, 30, 0, 30);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(154, 126);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // btnModify
            // 
            btnModify.Dock = DockStyle.Fill;
            btnModify.FlatAppearance.BorderSize = 0;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Location = new Point(10, 33);
            btnModify.Margin = new Padding(10, 3, 10, 3);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(57, 60);
            btnModify.TabIndex = 0;
            btnModify.Text = "M";
            btnModify.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(87, 33);
            btnDelete.Margin = new Padding(10, 3, 10, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(57, 60);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "D";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // panelDescription
            // 
            panelDescription.Controls.Add(tbDescription);
            panelDescription.Controls.Add(lblDescription);
            panelDescription.Location = new Point(3, 3);
            panelDescription.Name = "panelDescription";
            panelDescription.Size = new Size(299, 126);
            panelDescription.TabIndex = 6;
            // 
            // tbDescription
            // 
            tbDescription.Anchor = AnchorStyles.Left;
            tbDescription.Location = new Point(3, 45);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(270, 35);
            tbDescription.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.Dock = DockStyle.Fill;
            lblDescription.ForeColor = Color.FromArgb(246, 247, 247);
            lblDescription.ImageAlign = ContentAlignment.MiddleLeft;
            lblDescription.Location = new Point(0, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Padding = new Padding(10, 0, 0, 0);
            lblDescription.Size = new Size(299, 126);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "description";
            lblDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelAmount
            // 
            panelAmount.Controls.Add(tbAmount);
            panelAmount.Controls.Add(lblAmount);
            panelAmount.Location = new Point(308, 3);
            panelAmount.Name = "panelAmount";
            panelAmount.Size = new Size(194, 126);
            panelAmount.TabIndex = 7;
            // 
            // tbAmount
            // 
            tbAmount.Location = new Point(22, 45);
            tbAmount.Name = "tbAmount";
            tbAmount.Size = new Size(169, 35);
            tbAmount.TabIndex = 3;
            // 
            // lblAmount
            // 
            lblAmount.Dock = DockStyle.Fill;
            lblAmount.ForeColor = Color.FromArgb(246, 247, 247);
            lblAmount.Location = new Point(0, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Padding = new Padding(0, 0, 10, 0);
            lblAmount.Size = new Size(194, 126);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "amount";
            lblAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelDay
            // 
            panelDay.Controls.Add(nudDay);
            panelDay.Controls.Add(lblDayofMonth);
            panelDay.Location = new Point(508, 3);
            panelDay.Name = "panelDay";
            panelDay.Size = new Size(94, 126);
            panelDay.TabIndex = 8;
            // 
            // nudDay
            // 
            nudDay.Location = new Point(14, 46);
            nudDay.Name = "nudDay";
            nudDay.Size = new Size(77, 35);
            nudDay.TabIndex = 4;
            // 
            // lblDayofMonth
            // 
            lblDayofMonth.Dock = DockStyle.Fill;
            lblDayofMonth.ForeColor = Color.FromArgb(246, 247, 247);
            lblDayofMonth.Location = new Point(0, 0);
            lblDayofMonth.Name = "lblDayofMonth";
            lblDayofMonth.Size = new Size(94, 126);
            lblDayofMonth.TabIndex = 3;
            lblDayofMonth.Text = "dayofmonth";
            lblDayofMonth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelType
            // 
            panelType.Controls.Add(cbCategory);
            panelType.Controls.Add(lblType);
            panelType.Location = new Point(608, 3);
            panelType.Name = "panelType";
            panelType.Size = new Size(134, 126);
            panelType.TabIndex = 9;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(-3, 43);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(137, 38);
            cbCategory.TabIndex = 5;
            // 
            // lblType
            // 
            lblType.Dock = DockStyle.Fill;
            lblType.ForeColor = Color.FromArgb(246, 247, 247);
            lblType.Location = new Point(0, 0);
            lblType.Name = "lblType";
            lblType.Size = new Size(134, 126);
            lblType.TabIndex = 4;
            lblType.Text = "type";
            lblType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelStatus
            // 
            panelStatus.Controls.Add(lblStatus);
            panelStatus.Location = new Point(748, 3);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new Size(134, 126);
            panelStatus.TabIndex = 10;
            // 
            // lblStatus
            // 
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.ForeColor = Color.FromArgb(246, 247, 247);
            lblStatus.Location = new Point(0, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(134, 126);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "status";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ControlPlanCard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(tableLayoutPanel1);
            Name = "ControlPlanCard";
            Padding = new Padding(0, 4, 0, 4);
            Size = new Size(1045, 140);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panelDescription.ResumeLayout(false);
            panelDescription.PerformLayout();
            panelAmount.ResumeLayout(false);
            panelAmount.PerformLayout();
            panelDay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudDay).EndInit();
            panelType.ResumeLayout(false);
            panelStatus.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnModify;
        private Button btnDelete;
        private Panel panelDescription;
        private Label lblDescription;
        private Panel panelAmount;
        private Label lblAmount;
        private Panel panelDay;
        private Label lblDayofMonth;
        private Panel panelType;
        private TextBox tbDescription;
        private TextBox tbAmount;
        private NumericUpDown nudDay;
        private ComboBox cbCategory;
        private Label lblType;
        private Panel panelStatus;
        private Label lblStatus;
    }
}
