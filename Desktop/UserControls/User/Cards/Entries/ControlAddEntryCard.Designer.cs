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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            comboBox1 = new ComboBox();
            cbCategory = new ComboBox();
            tbAmount = new TextBox();
            dtpDate = new DateTimePicker();
            tbDescription = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(43, 40);
            label1.Name = "label1";
            label1.Size = new Size(154, 38);
            label1.TabIndex = 0;
            label1.Text = "New entry";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(689, 40);
            label2.Name = "label2";
            label2.Size = new Size(35, 38);
            label2.TabIndex = 1;
            label2.Text = "X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 138);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 0, 0, 20);
            label3.Size = new Size(56, 50);
            label3.TabIndex = 2;
            label3.Text = "Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(446, 138);
            label4.Name = "label4";
            label4.Size = new Size(96, 30);
            label4.TabIndex = 3;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 268);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 0, 0, 10);
            label5.Size = new Size(88, 40);
            label5.TabIndex = 4;
            label5.Text = "Amount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(446, 268);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 0, 0, 10);
            label6.Size = new Size(57, 40);
            label6.TabIndex = 5;
            label6.Text = "Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 386);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 0, 0, 10);
            label7.Size = new Size(118, 40);
            label7.TabIndex = 6;
            label7.Text = "Description";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(626, 497);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 40);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(442, 497);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(131, 40);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(43, 191);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(315, 38);
            comboBox1.TabIndex = 9;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(442, 191);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(315, 38);
            cbCategory.TabIndex = 9;
            // 
            // tbAmount
            // 
            tbAmount.Location = new Point(43, 311);
            tbAmount.Name = "tbAmount";
            tbAmount.Size = new Size(315, 35);
            tbAmount.TabIndex = 10;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(442, 311);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(315, 35);
            dtpDate.TabIndex = 11;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(43, 429);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(714, 35);
            tbDescription.TabIndex = 12;
            // 
            // ControlAddEntryCard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 247, 247);
            Controls.Add(tbDescription);
            Controls.Add(dtpDate);
            Controls.Add(tbAmount);
            Controls.Add(cbCategory);
            Controls.Add(comboBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ControlAddEntryCard";
            Padding = new Padding(40);
            Size = new Size(800, 580);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox comboBox1;
        private ComboBox cbCategory;
        private TextBox tbAmount;
        private DateTimePicker dtpDate;
        private TextBox tbDescription;
    }
}
