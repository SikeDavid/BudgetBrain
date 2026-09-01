namespace BudgetBrainDesktop.UserControls.User.Cards
{
    partial class ControlAddEntryCard
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
            tbDescription = new TextBox();
            cbCategory = new ComboBox();
            dtpDate = new DateTimePicker();
            tbAmount = new TextBox();
            btnSave = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(34, 46, 59);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tbDescription, 1, 4);
            tableLayoutPanel1.Controls.Add(cbCategory, 0, 4);
            tableLayoutPanel1.Controls.Add(dtpDate, 0, 2);
            tableLayoutPanel1.Controls.Add(tbAmount, 1, 2);
            tableLayoutPanel1.Controls.Add(btnSave, 0, 5);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(40, 40);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            tableLayoutPanel1.Size = new Size(720, 500);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(246, 247, 247);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 30);
            label1.TabIndex = 2;
            label1.Text = "New Entry";
            // 
            // tbDescription
            // 
            tbDescription.Anchor = AnchorStyles.None;
            tbDescription.Location = new Point(386, 335);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(308, 35);
            tbDescription.TabIndex = 3;
            // 
            // cbCategory
            // 
            cbCategory.Anchor = AnchorStyles.None;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(74, 333);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(212, 38);
            cbCategory.TabIndex = 4;
            // 
            // dtpDate
            // 
            dtpDate.Anchor = AnchorStyles.None;
            dtpDate.Location = new Point(5, 170);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(350, 35);
            dtpDate.TabIndex = 5;
            // 
            // tbAmount
            // 
            tbAmount.Anchor = AnchorStyles.None;
            tbAmount.Location = new Point(452, 170);
            tbAmount.Name = "tbAmount";
            tbAmount.Size = new Size(175, 35);
            tbAmount.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.BackColor = Color.FromArgb(36, 182, 110);
            tableLayoutPanel1.SetColumnSpan(btnSave, 2);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(75, 425);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(569, 64);
            btnSave.TabIndex = 1;
            btnSave.Text = "button2";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(246, 247, 247);
            label2.Location = new Point(151, 90);
            label2.Name = "label2";
            label2.Size = new Size(57, 30);
            label2.TabIndex = 7;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(246, 247, 247);
            label3.Location = new Point(496, 90);
            label3.Name = "label3";
            label3.Size = new Size(88, 30);
            label3.TabIndex = 8;
            label3.Text = "Amount";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(246, 247, 247);
            label4.Location = new Point(132, 255);
            label4.Name = "label4";
            label4.Size = new Size(96, 30);
            label4.TabIndex = 9;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(246, 247, 247);
            label5.Location = new Point(481, 255);
            label5.Name = "label5";
            label5.Size = new Size(118, 30);
            label5.TabIndex = 10;
            label5.Text = "Description";
            // 
            // ControlAddEntryCard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 10, 3, 3);
            Name = "ControlAddEntryCard";
            Padding = new Padding(40);
            Size = new Size(800, 580);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSave;
        private Label label1;
        private TextBox tbDescription;
        private ComboBox cbCategory;
        private DateTimePicker dtpDate;
        private TextBox tbAmount;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
