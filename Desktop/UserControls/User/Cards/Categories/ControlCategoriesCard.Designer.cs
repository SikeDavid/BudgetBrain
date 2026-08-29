namespace BudgetBrainDesktop.UserControls.User.Cards.Categories
{
    partial class ControlCategoriesCard
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
            panelCategory = new TableLayoutPanel();
            lblName = new Label();
            lblType = new Label();
            btnDelete = new Button();
            btnModify = new Button();
            panelModify = new TableLayoutPanel();
            btnSave = new Button();
            tbName = new TextBox();
            cbType = new ComboBox();
            panelCategory.SuspendLayout();
            panelModify.SuspendLayout();
            SuspendLayout();
            // 
            // panelCategory
            // 
            panelCategory.ColumnCount = 4;
            panelCategory.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            panelCategory.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            panelCategory.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            panelCategory.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            panelCategory.Controls.Add(lblName, 0, 0);
            panelCategory.Controls.Add(lblType, 1, 0);
            panelCategory.Controls.Add(btnDelete, 3, 0);
            panelCategory.Controls.Add(btnModify, 2, 0);
            panelCategory.Dock = DockStyle.Top;
            panelCategory.Location = new Point(0, 0);
            panelCategory.Name = "panelCategory";
            panelCategory.RowCount = 1;
            panelCategory.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelCategory.Size = new Size(1157, 83);
            panelCategory.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Left;
            lblName.AutoSize = true;
            lblName.ForeColor = Color.FromArgb(246, 247, 247);
            lblName.Location = new Point(3, 26);
            lblName.Name = "lblName";
            lblName.Size = new Size(68, 30);
            lblName.TabIndex = 0;
            lblName.Text = "label1";
            // 
            // lblType
            // 
            lblType.Anchor = AnchorStyles.Left;
            lblType.AutoSize = true;
            lblType.ForeColor = Color.FromArgb(246, 247, 247);
            lblType.Location = new Point(465, 26);
            lblType.Name = "lblType";
            lblType.Size = new Size(68, 30);
            lblType.TabIndex = 1;
            lblType.Text = "label2";
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(1042, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 77);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "del";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            btnModify.Dock = DockStyle.Fill;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Location = new Point(927, 3);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(109, 77);
            btnModify.TabIndex = 4;
            btnModify.Text = "mod";
            btnModify.UseVisualStyleBackColor = true;
            // 
            // panelModify
            // 
            panelModify.ColumnCount = 3;
            panelModify.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            panelModify.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            panelModify.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            panelModify.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            panelModify.Controls.Add(btnSave, 2, 0);
            panelModify.Controls.Add(tbName, 0, 0);
            panelModify.Controls.Add(cbType, 1, 0);
            panelModify.Dock = DockStyle.Bottom;
            panelModify.Location = new Point(0, 83);
            panelModify.Name = "panelModify";
            panelModify.RowCount = 1;
            panelModify.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelModify.Size = new Size(1157, 83);
            panelModify.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(927, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(227, 77);
            btnSave.TabIndex = 3;
            btnSave.Text = "save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Left;
            tbName.Location = new Point(3, 24);
            tbName.Name = "tbName";
            tbName.Size = new Size(310, 35);
            tbName.TabIndex = 0;
            // 
            // cbType
            // 
            cbType.Anchor = AnchorStyles.Left;
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(465, 22);
            cbType.Name = "cbType";
            cbType.Size = new Size(326, 38);
            cbType.TabIndex = 1;
            // 
            // ControlCategoriesCard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 46, 59);
            Controls.Add(panelModify);
            Controls.Add(panelCategory);
            Name = "ControlCategoriesCard";
            Size = new Size(1157, 166);
            panelCategory.ResumeLayout(false);
            panelCategory.PerformLayout();
            panelModify.ResumeLayout(false);
            panelModify.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel panelCategory;
        private Label lblName;
        private Label lblType;
        private Button btnDelete;
        private TableLayoutPanel panelModify;
        private TextBox tbName;
        private ComboBox cbType;
        private Button btnModify;
        private Button btnSave;
    }
}
