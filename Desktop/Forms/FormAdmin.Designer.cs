namespace BudgetBrainDesktop.Forms
{
    partial class FormAdmin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnLogout = new Button();
            btnFeedback = new Button();
            btnStatistic = new Button();
            btnUsers = new Button();
            btnDashBoard = new Button();
            panel1 = new Panel();
            lblPageTitle = new Label();
            panelContent = new Panel();
            panelLogo = new Panel();
            lblLogo2 = new Label();
            llbLogo1 = new Label();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            panelLogo.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(34, 46, 59);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnFeedback);
            panelMenu.Controls.Add(btnStatistic);
            panelMenu.Controls.Add(btnUsers);
            panelMenu.Controls.Add(btnDashBoard);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(24, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(241, 772);
            panelMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F);
            btnLogout.ForeColor = Color.FromArgb(244, 79, 80);
            btnLogout.Location = new Point(0, 692);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(241, 80);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnFeedback
            // 
            btnFeedback.Dock = DockStyle.Top;
            btnFeedback.FlatAppearance.BorderSize = 0;
            btnFeedback.FlatStyle = FlatStyle.Flat;
            btnFeedback.Font = new Font("Segoe UI", 12F);
            btnFeedback.ForeColor = Color.FromArgb(246, 247, 247);
            btnFeedback.Location = new Point(0, 320);
            btnFeedback.Name = "btnFeedback";
            btnFeedback.Size = new Size(241, 80);
            btnFeedback.TabIndex = 4;
            btnFeedback.Text = "  Feedback";
            btnFeedback.UseVisualStyleBackColor = true;
            btnFeedback.Click += btnFeedback_Click;
            // 
            // btnStatistic
            // 
            btnStatistic.Dock = DockStyle.Top;
            btnStatistic.FlatAppearance.BorderSize = 0;
            btnStatistic.FlatStyle = FlatStyle.Flat;
            btnStatistic.Font = new Font("Segoe UI", 12F);
            btnStatistic.ForeColor = Color.FromArgb(246, 247, 247);
            btnStatistic.Location = new Point(0, 240);
            btnStatistic.Name = "btnStatistic";
            btnStatistic.Size = new Size(241, 80);
            btnStatistic.TabIndex = 3;
            btnStatistic.Text = "  Statistic";
            btnStatistic.UseVisualStyleBackColor = true;
            btnStatistic.Click += btnStatistic_Click;
            // 
            // btnUsers
            // 
            btnUsers.Dock = DockStyle.Top;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI", 12F);
            btnUsers.ForeColor = Color.FromArgb(246, 247, 247);
            btnUsers.Location = new Point(0, 160);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(241, 80);
            btnUsers.TabIndex = 2;
            btnUsers.Text = "  Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnDashBoard
            // 
            btnDashBoard.Dock = DockStyle.Top;
            btnDashBoard.FlatAppearance.BorderSize = 0;
            btnDashBoard.FlatStyle = FlatStyle.Flat;
            btnDashBoard.Font = new Font("Segoe UI", 12F);
            btnDashBoard.ForeColor = Color.FromArgb(246, 247, 247);
            btnDashBoard.Location = new Point(0, 80);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new Size(241, 80);
            btnDashBoard.TabIndex = 1;
            btnDashBoard.Text = "  Dashboard";
            btnDashBoard.UseVisualStyleBackColor = true;
            btnDashBoard.Click += btnDashBoard_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 36, 49);
            panel1.Controls.Add(lblPageTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(265, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1359, 80);
            panel1.TabIndex = 1;
            // 
            // lblPageTitle
            // 
            lblPageTitle.Anchor = AnchorStyles.None;
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 15F);
            lblPageTitle.ForeColor = Color.WhiteSmoke;
            lblPageTitle.Location = new Point(657, 27);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(114, 47);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Home";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(24, 36, 49);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(265, 80);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1359, 692);
            panelContent.TabIndex = 2;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(24, 36, 49);
            panelLogo.Controls.Add(lblLogo2);
            panelLogo.Controls.Add(llbLogo1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(241, 80);
            panelLogo.TabIndex = 0;
            // 
            // lblLogo2
            // 
            lblLogo2.AutoSize = true;
            lblLogo2.Font = new Font("Segoe UI", 15F);
            lblLogo2.ForeColor = Color.FromArgb(38, 194, 129);
            lblLogo2.Location = new Point(132, 17);
            lblLogo2.Margin = new Padding(0, 0, 3, 0);
            lblLogo2.Name = "lblLogo2";
            lblLogo2.Size = new Size(98, 47);
            lblLogo2.TabIndex = 1;
            lblLogo2.Text = "Brain";
            // 
            // llbLogo1
            // 
            llbLogo1.AutoSize = true;
            llbLogo1.Font = new Font("Segoe UI", 15F);
            llbLogo1.ForeColor = Color.FromArgb(245, 247, 250);
            llbLogo1.Location = new Point(10, 17);
            llbLogo1.Margin = new Padding(3, 0, 0, 0);
            llbLogo1.Name = "llbLogo1";
            llbLogo1.Size = new Size(132, 47);
            llbLogo1.TabIndex = 2;
            llbLogo1.Text = "Budget";
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 36, 49);
            ClientSize = new Size(1624, 772);
            Controls.Add(panelContent);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Name = "FormAdmin";
            Padding = new Padding(24, 0, 0, 0);
            Text = "FormMain";
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnDashBoard;
        private Button btnFeedback;
        private Button btnStatistic;
        private Button btnUsers;
        private Panel panel1;
        private Label lblPageTitle;
        private Panel panelContent;
        private Button btnLogout;
        private Panel panelLogo;
        private Label lblLogo2;
        private Label llbLogo1;
    }
}