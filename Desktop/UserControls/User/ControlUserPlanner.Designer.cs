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
            panelHeader = new Panel();
            cbActive = new CheckBox();
            btnAddPlan = new Button();
            panelContentAdd = new Panel();
            panelContent = new FlowLayoutPanel();
            panelHeader.SuspendLayout();
            panelContentAdd.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(cbActive);
            panelHeader.Controls.Add(btnAddPlan);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(24, 24, 0, 24);
            panelHeader.Size = new Size(1180, 107);
            panelHeader.TabIndex = 0;
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
            // panelContentAdd
            // 
            panelContentAdd.Controls.Add(panelContent);
            panelContentAdd.Dock = DockStyle.Fill;
            panelContentAdd.Location = new Point(0, 107);
            panelContentAdd.Name = "panelContentAdd";
            panelContentAdd.Size = new Size(1180, 646);
            panelContentAdd.TabIndex = 1;
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
            panelContent.TabIndex = 2;
            panelContent.WrapContents = false;
            // 
            // ControlUserPlanner
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panelContentAdd);
            Controls.Add(panelHeader);
            Name = "ControlUserPlanner";
            Size = new Size(1180, 753);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContentAdd.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Button btnAddPlan;
        private CheckBox cbActive;
        private Panel panelContentAdd;
        private FlowLayoutPanel panelContent;
    }
}
