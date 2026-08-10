namespace BudgetBrainDesktop.UserControls
{
    partial class ControlUsers
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
            panelUserContent = new FlowLayoutPanel();
            panelHeader = new Panel();
            label1 = new Label();
            tbSearch = new TextBox();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelUserContent
            // 
            panelUserContent.AutoScroll = true;
            panelUserContent.Dock = DockStyle.Fill;
            panelUserContent.FlowDirection = FlowDirection.TopDown;
            panelUserContent.Location = new Point(0, 105);
            panelUserContent.Name = "panelUserContent";
            panelUserContent.Size = new Size(1327, 676);
            panelUserContent.TabIndex = 1;
            panelUserContent.WrapContents = false;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 38);
            label1.Name = "label1";
            label1.Size = new Size(80, 30);
            label1.TabIndex = 0;
            label1.Text = "Search:";
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(191, 38);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(556, 35);
            tbSearch.TabIndex = 1;
            // 
            // ControlUsers
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelUserContent);
            Controls.Add(panelHeader);
            Name = "ControlUsers";
            Size = new Size(1327, 781);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panelUserContent;
        private Panel panelHeader;
        private Label label1;
        private TextBox tbSearch;
    }
}
