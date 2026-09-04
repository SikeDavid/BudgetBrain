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
            btnAdd = new Button();
            panel1 = new Panel();
            panelContentAdd = new Panel();
            panelContent = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panelContentAdd.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(36, 182, 110);
            btnAdd.Dock = DockStyle.Left;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F);
            btnAdd.ForeColor = Color.FromArgb(246, 247, 247);
            btnAdd.Location = new Point(24, 24);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(232, 59);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+ New category";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(24, 24, 0, 24);
            panel1.Size = new Size(1180, 107);
            panel1.TabIndex = 1;
            // 
            // panelContentAdd
            // 
            panelContentAdd.Controls.Add(panelContent);
            panelContentAdd.Dock = DockStyle.Fill;
            panelContentAdd.Location = new Point(0, 107);
            panelContentAdd.Name = "panelContentAdd";
            panelContentAdd.Size = new Size(1180, 646);
            panelContentAdd.TabIndex = 2;
            // 
            // panelContent
            // 
            panelContent.AutoScroll = true;
            panelContent.Dock = DockStyle.Fill;
            panelContent.FlowDirection = FlowDirection.TopDown;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(24);
            panelContent.Size = new Size(1180, 646);
            panelContent.TabIndex = 3;
            panelContent.WrapContents = false;
            // 
            // ControlUserCategories
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panelContentAdd);
            Controls.Add(panel1);
            Name = "ControlUserCategories";
            Size = new Size(1180, 753);
            panel1.ResumeLayout(false);
            panelContentAdd.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdd;
        private Panel panel1;
        private Panel panelContentAdd;
        private FlowLayoutPanel panelContent;
    }
}
