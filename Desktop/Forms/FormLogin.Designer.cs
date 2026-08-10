namespace BudgetBrainDesktop
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lbPageTitle = new Label();
            panelContent = new Panel();
            btnSwitch = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 39, 58);
            panel1.Controls.Add(lbPageTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(616, 124);
            panel1.TabIndex = 4;
            // 
            // lbPageTitle
            // 
            lbPageTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbPageTitle.AutoSize = true;
            lbPageTitle.Font = new Font("Segoe UI", 20F);
            lbPageTitle.ForeColor = Color.WhiteSmoke;
            lbPageTitle.Location = new Point(229, 35);
            lbPageTitle.Name = "lbPageTitle";
            lbPageTitle.Size = new Size(143, 62);
            lbPageTitle.TabIndex = 0;
            lbPageTitle.Text = "Login";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.Transparent;
            panelContent.Dock = DockStyle.Top;
            panelContent.Location = new Point(0, 124);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(616, 520);
            panelContent.TabIndex = 5;
            // 
            // btnSwitch
            // 
            btnSwitch.Anchor = AnchorStyles.None;
            btnSwitch.Location = new Point(94, 24);
            btnSwitch.Margin = new Padding(3, 3, 3, 40);
            btnSwitch.Name = "btnSwitch";
            btnSwitch.Size = new Size(424, 40);
            btnSwitch.TabIndex = 0;
            btnSwitch.Text = "button1";
            btnSwitch.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSwitch);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 644);
            panel2.Name = "panel2";
            panel2.Size = new Size(616, 92);
            panel2.TabIndex = 6;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(616, 736);
            Controls.Add(panel2);
            Controls.Add(panelContent);
            Controls.Add(panel1);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label lbPageTitle;
        private Panel panelContent;
        private Button btnSwitch;
        private Panel panel2;
    }
}
