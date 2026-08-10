namespace BudgetBrainDesktop.UserControls.User
{
    partial class ControlUserDashboard
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
            lblBalance = new Label();
            lblIncome = new Label();
            lblExpense = new Label();
            lblStaticExpense = new Label();
            lblStaticIncome = new Label();
            lblStaticBalance = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            panelContent = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 16F);
            lblBalance.ForeColor = Color.FromArgb(244, 79, 80);
            lblBalance.Location = new Point(23, 86);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(191, 51);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "lblBalance";
            // 
            // lblIncome
            // 
            lblIncome.AutoSize = true;
            lblIncome.Font = new Font("Segoe UI", 16F);
            lblIncome.ForeColor = Color.FromArgb(36, 182, 110);
            lblIncome.Location = new Point(29, 86);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(187, 51);
            lblIncome.TabIndex = 0;
            lblIncome.Text = "lblIncome";
            // 
            // lblExpense
            // 
            lblExpense.AutoSize = true;
            lblExpense.Font = new Font("Segoe UI", 16F);
            lblExpense.ForeColor = Color.FromArgb(244, 79, 80);
            lblExpense.Location = new Point(19, 86);
            lblExpense.Name = "lblExpense";
            lblExpense.Size = new Size(198, 51);
            lblExpense.TabIndex = 0;
            lblExpense.Text = "lblExpense";
            // 
            // lblStaticExpense
            // 
            lblStaticExpense.AutoSize = true;
            lblStaticExpense.Font = new Font("Segoe UI", 12F);
            lblStaticExpense.ForeColor = Color.FromArgb(246, 247, 247);
            lblStaticExpense.Location = new Point(19, 32);
            lblStaticExpense.Name = "lblStaticExpense";
            lblStaticExpense.Size = new Size(118, 38);
            lblStaticExpense.TabIndex = 1;
            lblStaticExpense.Text = "Expense";
            // 
            // lblStaticIncome
            // 
            lblStaticIncome.AutoSize = true;
            lblStaticIncome.Font = new Font("Segoe UI", 12F);
            lblStaticIncome.ForeColor = Color.FromArgb(246, 247, 247);
            lblStaticIncome.Location = new Point(29, 26);
            lblStaticIncome.Name = "lblStaticIncome";
            lblStaticIncome.Size = new Size(108, 38);
            lblStaticIncome.TabIndex = 1;
            lblStaticIncome.Text = "Income";
            // 
            // lblStaticBalance
            // 
            lblStaticBalance.AutoSize = true;
            lblStaticBalance.BackColor = Color.Transparent;
            lblStaticBalance.Font = new Font("Segoe UI", 10F);
            lblStaticBalance.ForeColor = Color.FromArgb(246, 247, 247);
            lblStaticBalance.Location = new Point(23, 32);
            lblStaticBalance.Name = "lblStaticBalance";
            lblStaticBalance.Size = new Size(96, 32);
            lblStaticBalance.TabIndex = 1;
            lblStaticBalance.Text = "Balance";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1180, 219);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(34, 46, 59);
            panel4.Controls.Add(lblStaticIncome);
            panel4.Controls.Add(lblIncome);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(403, 10);
            panel4.Margin = new Padding(10);
            panel4.Name = "panel4";
            panel4.Size = new Size(373, 199);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(34, 46, 59);
            panel3.Controls.Add(lblStaticBalance);
            panel3.Controls.Add(lblBalance);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(10, 10);
            panel3.Margin = new Padding(10);
            panel3.Name = "panel3";
            panel3.Size = new Size(373, 199);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(34, 46, 59);
            panel2.Controls.Add(lblExpense);
            panel2.Controls.Add(lblStaticExpense);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(796, 10);
            panel2.Margin = new Padding(10);
            panel2.Name = "panel2";
            panel2.Size = new Size(374, 199);
            panel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panelContent);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 219);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(1180, 534);
            panel1.TabIndex = 4;
            // 
            // panelContent
            // 
            panelContent.AutoScroll = true;
            panelContent.BackColor = Color.FromArgb(34, 46, 59);
            panelContent.Dock = DockStyle.Fill;
            panelContent.FlowDirection = FlowDirection.TopDown;
            panelContent.Location = new Point(10, 10);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(10);
            panelContent.Size = new Size(1160, 514);
            panelContent.TabIndex = 0;
            panelContent.WrapContents = false;
            // 
            // ControlUserDashboard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Name = "ControlUserDashboard";
            Size = new Size(1180, 753);
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblBalance;
        private Label lblIncome;
        private Label lblExpense;
        private Label lblStaticExpense;
        private Label lblStaticIncome;
        private Label lblStaticBalance;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Panel panel1;
        private FlowLayoutPanel panelContent;
    }
}
