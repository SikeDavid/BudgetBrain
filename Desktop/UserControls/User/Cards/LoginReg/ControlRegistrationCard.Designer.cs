namespace BudgetBrainDesktop.UserControls.User.Cards.LoginReg
{
    partial class ControlRegistrationCard
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
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblRegexChar = new Label();
            lblRegexlow = new Label();
            lblRegexUp = new Label();
            lblRegexNum = new Label();
            lblRegexSpec = new Label();
            txtPassword = new TextBox();
            btnRegistration = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(txtUsername, 1, 0);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Controls.Add(txtPassword, 1, 2);
            tableLayoutPanel1.Controls.Add(btnRegistration, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26F));
            tableLayoutPanel1.Size = new Size(616, 520);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(157, 34);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(302, 35);
            txtUsername.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.BackColor = Color.WhiteSmoke;
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(159, 138);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(297, 35);
            txtEmail.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 3);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Controls.Add(lblRegexChar, 1, 0);
            tableLayoutPanel2.Controls.Add(lblRegexlow, 2, 0);
            tableLayoutPanel2.Controls.Add(lblRegexUp, 3, 0);
            tableLayoutPanel2.Controls.Add(lblRegexNum, 4, 0);
            tableLayoutPanel2.Controls.Add(lblRegexSpec, 5, 0);
            tableLayoutPanel2.Location = new Point(3, 315);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(610, 35);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // lblRegexChar
            // 
            lblRegexChar.AutoSize = true;
            lblRegexChar.Dock = DockStyle.Fill;
            lblRegexChar.Location = new Point(64, 0);
            lblRegexChar.Name = "lblRegexChar";
            lblRegexChar.Size = new Size(91, 35);
            lblRegexChar.TabIndex = 0;
            lblRegexChar.Text = "8char";
            lblRegexChar.TextAlign = ContentAlignment.MiddleCenter;
            lblRegexChar.Visible = false;
            // 
            // lblRegexlow
            // 
            lblRegexlow.AutoSize = true;
            lblRegexlow.Dock = DockStyle.Fill;
            lblRegexlow.Location = new Point(161, 0);
            lblRegexlow.Name = "lblRegexlow";
            lblRegexlow.Size = new Size(91, 35);
            lblRegexlow.TabIndex = 1;
            lblRegexlow.Text = "a-z";
            lblRegexlow.TextAlign = ContentAlignment.MiddleCenter;
            lblRegexlow.Visible = false;
            // 
            // lblRegexUp
            // 
            lblRegexUp.AutoSize = true;
            lblRegexUp.Dock = DockStyle.Fill;
            lblRegexUp.Location = new Point(258, 0);
            lblRegexUp.Name = "lblRegexUp";
            lblRegexUp.Size = new Size(91, 35);
            lblRegexUp.TabIndex = 2;
            lblRegexUp.Text = "A-Z";
            lblRegexUp.TextAlign = ContentAlignment.MiddleCenter;
            lblRegexUp.Visible = false;
            // 
            // lblRegexNum
            // 
            lblRegexNum.AutoSize = true;
            lblRegexNum.Dock = DockStyle.Fill;
            lblRegexNum.Location = new Point(355, 0);
            lblRegexNum.Name = "lblRegexNum";
            lblRegexNum.Size = new Size(91, 35);
            lblRegexNum.TabIndex = 3;
            lblRegexNum.Text = "123";
            lblRegexNum.TextAlign = ContentAlignment.MiddleCenter;
            lblRegexNum.Visible = false;
            // 
            // lblRegexSpec
            // 
            lblRegexSpec.AutoSize = true;
            lblRegexSpec.Dock = DockStyle.Fill;
            lblRegexSpec.Location = new Point(452, 0);
            lblRegexSpec.Name = "lblRegexSpec";
            lblRegexSpec.Size = new Size(91, 35);
            lblRegexSpec.TabIndex = 4;
            lblRegexSpec.Text = "@#$";
            lblRegexSpec.TextAlign = ContentAlignment.MiddleCenter;
            lblRegexSpec.Visible = false;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(157, 242);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "password";
            txtPassword.Size = new Size(302, 35);
            txtPassword.TabIndex = 2;
            // 
            // btnRegistration
            // 
            btnRegistration.Anchor = AnchorStyles.None;
            btnRegistration.BackColor = Color.WhiteSmoke;
            btnRegistration.ForeColor = Color.Black;
            btnRegistration.Location = new Point(242, 432);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(131, 40);
            btnRegistration.TabIndex = 4;
            btnRegistration.Text = "Registration";
            btnRegistration.UseVisualStyleBackColor = false;
            // 
            // ControlRegistrationCard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ControlRegistrationCard";
            Size = new Size(616, 520);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblRegexChar;
        private Label lblRegexlow;
        private Label lblRegexUp;
        private Label lblRegexNum;
        private Label lblRegexSpec;
        private Button btnRegistration;
    }
}
