namespace BudgetBrainDesktop.UserControls
{
    partial class ControlFeedback
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
            panelContent = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.IndianRed;
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1327, 105);
            panelHeader.TabIndex = 0;
            // 
            // panelContent
            // 
            panelContent.AutoScroll = true;
            panelContent.Dock = DockStyle.Fill;
            panelContent.FlowDirection = FlowDirection.TopDown;
            panelContent.Location = new Point(0, 105);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1327, 676);
            panelContent.TabIndex = 1;
            panelContent.WrapContents = false;
            // 
            // ControlFeedback
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Name = "ControlFeedback";
            Size = new Size(1327, 781);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private FlowLayoutPanel panelContent;
    }
}
