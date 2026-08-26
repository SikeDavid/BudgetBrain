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
            tbSearch = new TextBox();
            label1 = new Label();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.IndianRed;
            panelHeader.Controls.Add(tbSearch);
            panelHeader.Controls.Add(label1);
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
            // tbSearch
            // 
            tbSearch.Location = new Point(164, 40);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(556, 35);
            tbSearch.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 40);
            label1.Name = "label1";
            label1.Size = new Size(80, 30);
            label1.TabIndex = 2;
            label1.Text = "Search:";
            // 
            // ControlFeedback
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Name = "ControlFeedback";
            Size = new Size(1327, 781);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private FlowLayoutPanel panelContent;
        private TextBox tbSearch;
        private Label label1;
    }
}
