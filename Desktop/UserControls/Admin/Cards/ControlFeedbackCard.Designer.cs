namespace BudgetBrainDesktop.UserControls.Admin.Cards
{
    partial class ControlFeedbackCard
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
            btnExpand = new Button();
            cbReaded = new CheckBox();
            lblTitle = new Label();
            lblId = new Label();
            panelContent = new Panel();
            rtbMessage = new RichTextBox();
            panelBase = new Panel();
            lblUser = new Label();
            panelContent.SuspendLayout();
            panelBase.SuspendLayout();
            SuspendLayout();
            // 
            // btnExpand
            // 
            btnExpand.Location = new Point(1066, 40);
            btnExpand.Name = "btnExpand";
            btnExpand.Size = new Size(131, 40);
            btnExpand.TabIndex = 3;
            btnExpand.Text = "ˇ";
            btnExpand.UseVisualStyleBackColor = true;
            // 
            // cbReaded
            // 
            cbReaded.AutoSize = true;
            cbReaded.Location = new Point(923, 44);
            cbReaded.Name = "cbReaded";
            cbReaded.Size = new Size(108, 34);
            cbReaded.TabIndex = 2;
            cbReaded.Text = "Readed";
            cbReaded.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(137, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(52, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title";
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Left;
            lblId.AutoSize = true;
            lblId.Location = new Point(69, 45);
            lblId.Name = "lblId";
            lblId.Size = new Size(31, 30);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // panelContent
            // 
            panelContent.Controls.Add(rtbMessage);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 100);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(40);
            panelContent.Size = new Size(1300, 300);
            panelContent.TabIndex = 3;
            // 
            // rtbMessage
            // 
            rtbMessage.Dock = DockStyle.Fill;
            rtbMessage.Location = new Point(40, 40);
            rtbMessage.Name = "rtbMessage";
            rtbMessage.Size = new Size(1220, 220);
            rtbMessage.TabIndex = 0;
            rtbMessage.Text = "";
            // 
            // panelBase
            // 
            panelBase.Controls.Add(lblUser);
            panelBase.Controls.Add(btnExpand);
            panelBase.Controls.Add(cbReaded);
            panelBase.Controls.Add(lblTitle);
            panelBase.Controls.Add(lblId);
            panelBase.Dock = DockStyle.Top;
            panelBase.Location = new Point(0, 0);
            panelBase.Name = "panelBase";
            panelBase.Size = new Size(1300, 100);
            panelBase.TabIndex = 2;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(710, 48);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(68, 30);
            lblUser.TabIndex = 4;
            lblUser.Text = "label1";
            // 
            // ControlFeedbackCard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContent);
            Controls.Add(panelBase);
            Name = "ControlFeedbackCard";
            Size = new Size(1300, 400);
            panelContent.ResumeLayout(false);
            panelBase.ResumeLayout(false);
            panelBase.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExpand;
        private CheckBox cbReaded;
        private Label lblTitle;
        private Label lblId;
        private Panel panelContent;
        private RichTextBox rtbMessage;
        private Panel panelBase;
        private Label lblUser;
    }
}
