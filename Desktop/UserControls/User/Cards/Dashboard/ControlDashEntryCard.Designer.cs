namespace BudgetBrainDesktop.UserControls.User.Cards
{
    partial class ControlDashEntryCard
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
            lblDate = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblDescription = new Label();
            lblAmount = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Left;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 10F);
            lblDate.ForeColor = Color.FromArgb(246, 247, 247);
            lblDate.Location = new Point(3, 36);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(61, 32);
            lblDate.TabIndex = 7;
            lblDate.Text = "date";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Controls.Add(lblDate, 0, 0);
            tableLayoutPanel1.Controls.Add(lblDescription, 1, 0);
            tableLayoutPanel1.Controls.Add(lblAmount, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1010, 104);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Dock = DockStyle.Fill;
            lblDescription.Font = new Font("Segoe UI", 10F);
            lblDescription.ForeColor = Color.FromArgb(246, 247, 247);
            lblDescription.Location = new Point(70, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Padding = new Padding(20, 0, 0, 0);
            lblDescription.Size = new Size(779, 104);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "label1";
            lblDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAmount
            // 
            lblAmount.Anchor = AnchorStyles.Right;
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAmount.ForeColor = Color.FromArgb(246, 247, 247);
            lblAmount.Location = new Point(924, 36);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(83, 32);
            lblAmount.TabIndex = 9;
            lblAmount.Text = "label2";
            // 
            // ControlEntryCard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(tableLayoutPanel1);
            Name = "ControlEntryCard";
            Size = new Size(1010, 104);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblDate;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblDescription;
        private Label lblAmount;
    }
}
