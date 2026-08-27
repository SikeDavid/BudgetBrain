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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblName = new Label();
            lblType = new Label();
            btnSave = new Button();
            btnDelete = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(lblName, 0, 0);
            tableLayoutPanel1.Controls.Add(lblType, 1, 0);
            tableLayoutPanel1.Controls.Add(btnSave, 2, 0);
            tableLayoutPanel1.Controls.Add(btnDelete, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1157, 83);
            tableLayoutPanel1.TabIndex = 0;
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
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(927, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 77);
            btnSave.TabIndex = 2;
            btnSave.Text = "save";
            btnSave.UseVisualStyleBackColor = true;
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
            // ControlCategoriesCard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 46, 59);
            Controls.Add(tableLayoutPanel1);
            Name = "ControlCategoriesCard";
            Size = new Size(1157, 83);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblName;
        private Label lblType;
        private Button btnSave;
        private Button btnDelete;
    }
}
