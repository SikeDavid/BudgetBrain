namespace BudgetBrainDesktop.UserControls.User
{
    partial class ControlUserCategories
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
            button1 = new Button();
            panel1 = new Panel();
            panelContent = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(36, 182, 110);
            button1.Dock = DockStyle.Left;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = Color.FromArgb(246, 247, 247);
            button1.Location = new Point(24, 24);
            button1.Name = "button1";
            button1.Size = new Size(232, 59);
            button1.TabIndex = 0;
            button1.Text = "+ New category";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(24, 24, 0, 24);
            panel1.Size = new Size(1180, 107);
            panel1.TabIndex = 1;
            // 
            // panelContent
            // 
            panelContent.AutoScroll = true;
            panelContent.Dock = DockStyle.Fill;
            panelContent.FlowDirection = FlowDirection.TopDown;
            panelContent.Location = new Point(0, 107);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(24);
            panelContent.Size = new Size(1180, 646);
            panelContent.TabIndex = 2;
            panelContent.WrapContents = false;
            // 
            // ControlUserCategories
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panelContent);
            Controls.Add(panel1);
            Name = "ControlUserCategories";
            Size = new Size(1180, 753);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Panel panel1;
        private FlowLayoutPanel panelContent;
    }
}
