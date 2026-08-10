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
            lblDescription = new Label();
            lblAmount = new Label();
            lblDayofMonth = new Label();
            lblType = new Label();
            lblStatus = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnModify = new Button();
            btnDelete = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            tableLayoutPanel1.Controls.Add(lblDescription, 0, 0);
            tableLayoutPanel1.Controls.Add(lblAmount, 1, 0);
            tableLayoutPanel1.Controls.Add(lblDayofMonth, 2, 0);
            tableLayoutPanel1.Controls.Add(lblType, 3, 0);
            tableLayoutPanel1.Controls.Add(lblStatus, 4, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 5, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1045, 132);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Dock = DockStyle.Fill;
            lblDescription.ForeColor = Color.FromArgb(246, 247, 247);
            lblDescription.Location = new Point(3, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Padding = new Padding(10, 0, 0, 0);
            lblDescription.Size = new Size(299, 132);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "description";
            lblDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Dock = DockStyle.Fill;
            lblAmount.ForeColor = Color.FromArgb(246, 247, 247);
            lblAmount.Location = new Point(308, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Padding = new Padding(0, 0, 10, 0);
            lblAmount.Size = new Size(194, 132);
            lblAmount.TabIndex = 1;
            lblAmount.Text = "amount";
            lblAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDayofMonth
            // 
            lblDayofMonth.AutoSize = true;
            lblDayofMonth.Dock = DockStyle.Fill;
            lblDayofMonth.ForeColor = Color.FromArgb(246, 247, 247);
            lblDayofMonth.Location = new Point(508, 0);
            lblDayofMonth.Name = "lblDayofMonth";
            lblDayofMonth.Size = new Size(94, 132);
            lblDayofMonth.TabIndex = 2;
            lblDayofMonth.Text = "dayofmonth";
            lblDayofMonth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Dock = DockStyle.Fill;
            lblType.ForeColor = Color.FromArgb(246, 247, 247);
            lblType.Location = new Point(608, 0);
            lblType.Name = "lblType";
            lblType.Size = new Size(134, 132);
            lblType.TabIndex = 3;
            lblType.Text = "type";
            lblType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.ForeColor = Color.FromArgb(246, 247, 247);
            lblStatus.Location = new Point(748, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(134, 132);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "status";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
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
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblDescription;
        private Label lblAmount;
        private Label lblDayofMonth;
        private Label lblType;
        private Label lblStatus;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnModify;
        private Button btnDelete;
    }
}
