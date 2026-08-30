namespace BudgetBrainDesktop.UserControls.User
{
    partial class ControlUserEntries
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
            label1 = new Label();
            label2 = new Label();
            cbCategorySort = new ComboBox();
            tbSearch = new TextBox();
            btnAdd = new Button();
            label3 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnPrevMonth = new Button();
            btnNextMonth = new Button();
            lblCurrentMonth = new Label();
            panelContent = new Panel();
            panelContentEntries = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(34, 46, 59);
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(cbCategorySort, 1, 1);
            tableLayoutPanel1.Controls.Add(tbSearch, 2, 1);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(btnAdd, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1160, 121);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.FromArgb(246, 247, 247);
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(86, 32);
            label1.TabIndex = 0;
            label1.Text = "Month";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(246, 247, 247);
            label2.Location = new Point(303, 14);
            label2.Name = "label2";
            label2.Size = new Size(110, 32);
            label2.TabIndex = 1;
            label2.Text = "Category";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbCategorySort
            // 
            cbCategorySort.Anchor = AnchorStyles.None;
            cbCategorySort.BackColor = Color.FromArgb(24, 36, 49);
            cbCategorySort.ForeColor = Color.FromArgb(246, 247, 247);
            cbCategorySort.FormattingEnabled = true;
            cbCategorySort.Location = new Point(320, 71);
            cbCategorySort.Margin = new Padding(20, 3, 20, 3);
            cbCategorySort.Name = "cbCategorySort";
            cbCategorySort.Size = new Size(200, 38);
            cbCategorySort.TabIndex = 2;
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbSearch.BackColor = Color.FromArgb(24, 36, 49);
            tbSearch.ForeColor = Color.FromArgb(246, 247, 247);
            tbSearch.Location = new Point(560, 73);
            tbSearch.Margin = new Padding(20, 3, 20, 3);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(380, 35);
            tbSearch.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = Color.FromArgb(36, 182, 110);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 14F);
            btnAdd.ForeColor = Color.FromArgb(246, 247, 247);
            btnAdd.Location = new Point(994, 32);
            btnAdd.Name = "btnAdd";
            tableLayoutPanel1.SetRowSpan(btnAdd, 2);
            btnAdd.Size = new Size(131, 56);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.FromArgb(246, 247, 247);
            label3.Location = new Point(543, 14);
            label3.Name = "label3";
            label3.Size = new Size(85, 32);
            label3.TabIndex = 5;
            label3.Text = "Search";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.Controls.Add(btnPrevMonth, 0, 0);
            tableLayoutPanel2.Controls.Add(btnNextMonth, 2, 0);
            tableLayoutPanel2.Controls.Add(lblCurrentMonth, 1, 0);
            tableLayoutPanel2.Location = new Point(3, 63);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(294, 52);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // btnPrevMonth
            // 
            btnPrevMonth.BackColor = Color.FromArgb(48, 58, 59);
            btnPrevMonth.FlatAppearance.BorderSize = 0;
            btnPrevMonth.FlatStyle = FlatStyle.Flat;
            btnPrevMonth.ForeColor = Color.FromArgb(246, 247, 247);
            btnPrevMonth.Location = new Point(3, 3);
            btnPrevMonth.Name = "btnPrevMonth";
            btnPrevMonth.Size = new Size(34, 40);
            btnPrevMonth.TabIndex = 0;
            btnPrevMonth.Text = "<";
            btnPrevMonth.UseVisualStyleBackColor = false;
            // 
            // btnNextMonth
            // 
            btnNextMonth.BackColor = Color.FromArgb(48, 58, 59);
            btnNextMonth.Dock = DockStyle.Fill;
            btnNextMonth.FlatAppearance.BorderSize = 0;
            btnNextMonth.FlatStyle = FlatStyle.Flat;
            btnNextMonth.ForeColor = Color.FromArgb(246, 247, 247);
            btnNextMonth.Location = new Point(257, 3);
            btnNextMonth.Name = "btnNextMonth";
            btnNextMonth.Size = new Size(34, 46);
            btnNextMonth.TabIndex = 1;
            btnNextMonth.Text = ">";
            btnNextMonth.UseVisualStyleBackColor = false;
            // 
            // lblCurrentMonth
            // 
            lblCurrentMonth.Anchor = AnchorStyles.None;
            lblCurrentMonth.AutoSize = true;
            lblCurrentMonth.Font = new Font("Segoe UI", 10F);
            lblCurrentMonth.ForeColor = Color.FromArgb(246, 247, 247);
            lblCurrentMonth.Location = new Point(108, 10);
            lblCurrentMonth.Name = "lblCurrentMonth";
            lblCurrentMonth.Size = new Size(78, 32);
            lblCurrentMonth.TabIndex = 2;
            lblCurrentMonth.Text = "label4";
            // 
            // panelContent
            // 
            panelContent.Controls.Add(panelContentEntries);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(10, 131);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1160, 612);
            panelContent.TabIndex = 1;
            // 
            // panelContentEntries
            // 
            panelContentEntries.AutoScroll = true;
            panelContentEntries.Dock = DockStyle.Fill;
            panelContentEntries.FlowDirection = FlowDirection.TopDown;
            panelContentEntries.Location = new Point(0, 0);
            panelContentEntries.Name = "panelContentEntries";
            panelContentEntries.Padding = new Padding(0, 24, 0, 0);
            panelContentEntries.Size = new Size(1160, 612);
            panelContentEntries.TabIndex = 0;
            panelContentEntries.WrapContents = false;
            // 
            // ControlUserEntries
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panelContent);
            Controls.Add(tableLayoutPanel1);
            Name = "ControlUserEntries";
            Padding = new Padding(10);
            Size = new Size(1180, 753);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panelContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private ComboBox cbCategorySort;
        private TextBox tbSearch;
        private Button btnAdd;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnPrevMonth;
        private Button btnNextMonth;
        private Label lblCurrentMonth;
        private Panel panelContent;
        private FlowLayoutPanel panelContentEntries;
    }
}
