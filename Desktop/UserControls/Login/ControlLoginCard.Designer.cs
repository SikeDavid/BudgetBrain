namespace BudgetBrainDesktop.UserControls.User.Cards.LoginReg
{
    partial class ControlLoginCard
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
            tlpLogin = new TableLayoutPanel();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblError = new Label();
            btnLogin = new Button();
            tlpLogin.SuspendLayout();
            SuspendLayout();
            // 
            // tlpLogin
            // 
            tlpLogin.ColumnCount = 3;
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpLogin.Controls.Add(txtUsername, 1, 0);
            tlpLogin.Controls.Add(txtPassword, 1, 1);
            tlpLogin.Controls.Add(lblError, 0, 2);
            tlpLogin.Controls.Add(btnLogin, 1, 3);
            tlpLogin.Dock = DockStyle.Fill;
            tlpLogin.Location = new Point(0, 0);
            tlpLogin.Name = "tlpLogin";
            tlpLogin.RowCount = 4;
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpLogin.Size = new Size(616, 520);
            tlpLogin.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Bottom;
            txtUsername.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(220, 92);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "username";
            txtUsername.Size = new Size(175, 35);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Bottom;
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(220, 222);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "password";
            txtPassword.Size = new Size(175, 35);
            txtPassword.TabIndex = 1;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.None;
            tlpLogin.SetColumnSpan(lblError, 3);
            lblError.Location = new Point(3, 312);
            lblError.Margin = new Padding(3, 20, 3, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(610, 46);
            lblError.TabIndex = 3;
            lblError.Text = "errormsg";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.Transparent;
            btnLogin.Location = new Point(220, 435);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(175, 40);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // ControlLoginCard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpLogin);
            Name = "ControlLoginCard";
            Size = new Size(616, 520);
            tlpLogin.ResumeLayout(false);
            tlpLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpLogin;
        private Button btnLogin;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblError;
    }
}
