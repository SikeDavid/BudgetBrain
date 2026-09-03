namespace BudgetBrainDesktop.UserControls.User
{
    partial class ControlUserPlanner
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
            panel1 = new Panel();
            cbActive = new CheckBox();
            btnAddPlan = new Button();
            panelContent = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbActive);
            panel1.Controls.Add(btnAddPlan);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(24, 24, 0, 24);
            panel1.Size = new Size(1180, 107);
            panel1.TabIndex = 0;
            // 
            // cbActive
            // 
            cbActive.AutoSize = true;
            cbActive.Dock = DockStyle.Left;
            cbActive.ForeColor = Color.FromArgb(246, 247, 247);
            cbActive.Location = new Point(256, 24);
            cbActive.Name = "cbActive";
            cbActive.Padding = new Padding(20, 0, 0, 0);
            cbActive.Size = new Size(162, 59);
            cbActive.TabIndex = 2;
            cbActive.Text = "Only active";
            cbActive.UseVisualStyleBackColor = true;
            // 
            // btnAddPlan
            // 
            btnAddPlan.BackColor = Color.FromArgb(36, 182, 110);
            btnAddPlan.Dock = DockStyle.Left;
            btnAddPlan.FlatAppearance.BorderSize = 0;
            btnAddPlan.FlatStyle = FlatStyle.Flat;
            btnAddPlan.Font = new Font("Segoe UI", 10F);
            btnAddPlan.ForeColor = Color.FromArgb(246, 247, 247);
            btnAddPlan.Location = new Point(24, 24);
            btnAddPlan.Name = "btnAddPlan";
            btnAddPlan.Size = new Size(232, 59);
            btnAddPlan.TabIndex = 0;
            btnAddPlan.Text = "+ New plan";
            btnAddPlan.UseVisualStyleBackColor = false;
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
            panelContent.TabIndex = 1;
            panelContent.WrapContents = false;
            // 
            // ControlUserPlanner
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panelContent);
            Controls.Add(panel1);
            Name = "ControlUserPlanner";
            Size = new Size(1180, 753);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAddPlan;
        private FlowLayoutPanel panelContent;
        private CheckBox cbActive;
    }
}
