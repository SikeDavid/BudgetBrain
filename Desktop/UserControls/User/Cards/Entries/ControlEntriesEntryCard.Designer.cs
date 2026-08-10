namespace BudgetBrainDesktop.UserControls.User.Cards
{
    partial class ControlEntriesEntryCard
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
            lblType = new Label();
            lblDate = new Label();
            lblCategory = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            lblAmount = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblDescription, 2, 0);
            tableLayoutPanel1.Controls.Add(lblType, 1, 0);
            tableLayoutPanel1.Controls.Add(lblDate, 0, 0);
            tableLayoutPanel1.Controls.Add(lblCategory, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(703, 166);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.None;
            lblDescription.AutoSize = true;
            lblDescription.ForeColor = Color.FromArgb(246, 247, 247);
            lblDescription.Location = new Point(454, 26);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(115, 30);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "description";
            // 
            // lblType
            // 
            lblType.Anchor = AnchorStyles.None;
            lblType.AutoSize = true;
            lblType.ForeColor = Color.FromArgb(246, 247, 247);
            lblType.Location = new Point(233, 26);
            lblType.Name = "lblType";
            lblType.Size = new Size(53, 30);
            lblType.TabIndex = 1;
            lblType.Text = "type";
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.None;
            lblDate.AutoSize = true;
            lblDate.ForeColor = Color.FromArgb(246, 247, 247);
            lblDate.Location = new Point(73, 26);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(54, 30);
            lblDate.TabIndex = 2;
            lblDate.Text = "date";
            // 
            // lblCategory
            // 
            lblCategory.Anchor = AnchorStyles.None;
            lblCategory.AutoSize = true;
            lblCategory.ForeColor = Color.FromArgb(246, 247, 247);
            lblCategory.Location = new Point(465, 109);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(93, 30);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "category";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Controls.Add(button2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Right;
            tableLayoutPanel2.Location = new Point(964, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(193, 166);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(48, 58, 59);
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(246, 247, 247);
            button1.Location = new Point(6, 6);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(181, 71);
            button1.TabIndex = 0;
            button1.Text = "Modify";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(48, 58, 59);
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(246, 247, 247);
            button2.Location = new Point(6, 89);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(181, 71);
            button2.TabIndex = 1;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblAmount);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(703, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 166);
            panel1.TabIndex = 2;
            // 
            // lblAmount
            // 
            lblAmount.Anchor = AnchorStyles.Right;
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 16F);
            lblAmount.ForeColor = Color.FromArgb(246, 247, 247);
            lblAmount.Location = new Point(49, 58);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(153, 51);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "amount";
            // 
            // ControlEntriesEntryCard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 46, 59);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "ControlEntriesEntryCard";
            Size = new Size(1157, 166);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblDescription;
        private Label lblType;
        private Label lblDate;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Label lblAmount;
        private Label lblCategory;
    }
}
