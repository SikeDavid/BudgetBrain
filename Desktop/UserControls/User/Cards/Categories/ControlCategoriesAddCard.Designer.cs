namespace BudgetBrainDesktop.UserControls.User.Cards.Categories
{
    partial class ControlCategoriesAddCard
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
            btnSave = new Button();
            label2 = new Label();
            label3 = new Label();
            tbDescription = new TextBox();
            cbType = new ComboBox();
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
            tableLayoutPanel1.Controls.Add(btnSave, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 1, 1);
            tableLayoutPanel1.Controls.Add(tbDescription, 0, 2);
            tableLayoutPanel1.Controls.Add(cbType, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(40, 40);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.3731346F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9402981F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.3134346F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.3731346F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(720, 380);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(246, 247, 247);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 30);
            label1.TabIndex = 2;
            label1.Text = "New Category";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.BackColor = Color.FromArgb(36, 182, 110);
            tableLayoutPanel1.SetColumnSpan(btnSave, 2);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(75, 299);
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
            label2.Location = new Point(121, 103);
            label2.Name = "label2";
            label2.Size = new Size(118, 30);
            label2.TabIndex = 7;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(246, 247, 247);
            label3.Location = new Point(512, 103);
            label3.Name = "label3";
            label3.Size = new Size(56, 30);
            label3.TabIndex = 8;
            label3.Text = "Type";
            // 
            // tbDescription
            // 
            tbDescription.Anchor = AnchorStyles.None;
            tbDescription.Location = new Point(26, 194);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(308, 35);
            tbDescription.TabIndex = 3;
            // 
            // cbType
            // 
            cbType.Anchor = AnchorStyles.None;
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(434, 192);
            cbType.Name = "cbType";
            cbType.Size = new Size(212, 38);
            cbType.TabIndex = 4;
            // 
            // ControlCategoriesAddCard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(tableLayoutPanel1);
            Name = "ControlCategoriesAddCard";
            Padding = new Padding(40);
            Size = new Size(800, 460);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox tbDescription;
        private ComboBox cbType;
        private Button btnSave;
        private Label label2;
        private Label label3;
    }
}
