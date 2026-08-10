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
            btnFeedback = new Button();
            btnStatistic = new Button();
            btnUsers = new Button();
            btnDashBoard = new Button();
            panelLogo = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            lblPageTitle = new Label();
            panelContent = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnFeedback);
            panelMenu.Controls.Add(btnStatistic);
            panelMenu.Controls.Add(btnUsers);
            panelMenu.Controls.Add(btnDashBoard);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(320, 772);
            panelMenu.TabIndex = 0;
            // 
            // btnFeedback
            // 
            btnFeedback.Dock = DockStyle.Top;
            btnFeedback.FlatAppearance.BorderSize = 0;
            btnFeedback.FlatStyle = FlatStyle.Flat;
            btnFeedback.ForeColor = Color.WhiteSmoke;
            btnFeedback.Location = new Point(0, 365);
            btnFeedback.Name = "btnFeedback";
            btnFeedback.Size = new Size(320, 80);
            btnFeedback.TabIndex = 4;
            btnFeedback.Text = "Feedback";
            btnFeedback.UseVisualStyleBackColor = true;
            btnFeedback.Click += btnFeedback_Click;
            // 
            // btnStatistic
            // 
            btnStatistic.Dock = DockStyle.Top;
            btnStatistic.FlatAppearance.BorderSize = 0;
            btnStatistic.FlatStyle = FlatStyle.Flat;
            btnStatistic.ForeColor = Color.WhiteSmoke;
            btnStatistic.Location = new Point(0, 285);
            btnStatistic.Name = "btnStatistic";
            btnStatistic.Size = new Size(320, 80);
            btnStatistic.TabIndex = 3;
            btnStatistic.Text = "Statistic";
            btnStatistic.UseVisualStyleBackColor = true;
            btnStatistic.Click += btnStatistic_Click;
            // 
            // btnUsers
            // 
            btnUsers.Dock = DockStyle.Top;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.ForeColor = Color.WhiteSmoke;
            btnUsers.Location = new Point(0, 205);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(320, 80);
            btnUsers.TabIndex = 2;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnDashBoard
            // 
            btnDashBoard.Dock = DockStyle.Top;
            btnDashBoard.FlatAppearance.BorderSize = 0;
            btnDashBoard.FlatStyle = FlatStyle.Flat;
            btnDashBoard.ForeColor = Color.WhiteSmoke;
            btnDashBoard.Location = new Point(0, 125);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new Size(320, 80);
            btnDashBoard.TabIndex = 1;
            btnDashBoard.Text = "Dashboard";
            btnDashBoard.UseVisualStyleBackColor = true;
            btnDashBoard.Click += btnDashBoard_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label2);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(320, 125);
            panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(50, 49);
            label2.Name = "label2";
            label2.Size = new Size(210, 47);
            label2.TabIndex = 0;
            label2.Text = "BudgetBrain";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 150, 136);
            panel1.Controls.Add(lblPageTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(320, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1304, 125);
            panel1.TabIndex = 1;
            // 
            // lblPageTitle
            // 
            lblPageTitle.Anchor = AnchorStyles.None;
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 15F);
            lblPageTitle.ForeColor = Color.WhiteSmoke;
            lblPageTitle.Location = new Point(630, 49);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(114, 47);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Home";
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(320, 125);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1304, 647);
            panelContent.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1624, 772);
            Controls.Add(panelContent);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Name = "FormMain";
            Text = "FormMain";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnDashBoard;
        private Button btnFeedback;
        private Button btnStatistic;
        private Button btnUsers;
        private Panel panel1;
        private Label lblPageTitle;
        private Label label2;
        private Panel panelContent;
    }
}