namespace BudgetBrainDesktop.UserControls
{
    partial class ControlDashboard
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
            lbaccess = new Label();
            lbrefresh = new Label();
            SuspendLayout();
            // 
            // lbaccess
            // 
            lbaccess.AutoSize = true;
            lbaccess.Location = new Point(71, 115);
            lbaccess.Name = "lbaccess";
            lbaccess.Size = new Size(68, 30);
            lbaccess.TabIndex = 0;
            lbaccess.Text = "label1";
            // 
            // lbrefresh
            // 
            lbrefresh.AutoSize = true;
            lbrefresh.Location = new Point(71, 220);
            lbrefresh.Name = "lbrefresh";
            lbrefresh.Size = new Size(68, 30);
            lbrefresh.TabIndex = 0;
            lbrefresh.Text = "label1";
            // 
            // ControlDashboard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbrefresh);
            Controls.Add(lbaccess);
            Name = "ControlDashboard";
            Size = new Size(1180, 753);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbaccess;
        private Label lbrefresh;
    }
}
