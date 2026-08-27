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
            lblTitle = new Label();
            lblId = new Label();
            panelContent = new Panel();
            rtbMessage = new RichTextBox();
            panelBase = new Panel();
            tlpButtons = new TableLayoutPanel();
            btnDelete = new Button();
            btnRead = new Button();
            btnExpand = new Button();
            lblUser = new Label();
            panelContent.SuspendLayout();
            panelBase.SuspendLayout();
            tlpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.ForeColor = Color.FromArgb(246, 247, 247);
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
            lblId.ForeColor = Color.FromArgb(246, 247, 247);
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
            panelBase.Controls.Add(tlpButtons);
            panelBase.Controls.Add(lblUser);
            panelBase.Controls.Add(lblTitle);
            panelBase.Controls.Add(lblId);
            panelBase.Dock = DockStyle.Top;
            panelBase.Location = new Point(0, 0);
            panelBase.Name = "panelBase";
            panelBase.Size = new Size(1300, 100);
            panelBase.TabIndex = 2;
            // 
            // tlpButtons
            // 
            tlpButtons.ColumnCount = 3;
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpButtons.Controls.Add(btnDelete, 1, 0);
            tlpButtons.Controls.Add(btnRead, 0, 0);
            tlpButtons.Controls.Add(btnExpand, 2, 0);
            tlpButtons.Location = new Point(849, 28);
            tlpButtons.Name = "tlpButtons";
            tlpButtons.RowCount = 1;
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpButtons.Size = new Size(389, 66);
            tlpButtons.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(34, 46, 59);
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.FromArgb(246, 247, 247);
            btnDelete.Location = new Point(197, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(91, 60);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "button2";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnRead
            // 
            btnRead.BackColor = Color.FromArgb(34, 46, 59);
            btnRead.Dock = DockStyle.Fill;
            btnRead.FlatStyle = FlatStyle.Flat;
            btnRead.ForeColor = Color.FromArgb(246, 247, 247);
            btnRead.Location = new Point(3, 3);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(188, 60);
            btnRead.TabIndex = 0;
            btnRead.Text = "button1";
            btnRead.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRead.UseVisualStyleBackColor = false;
            // 
            // btnExpand
            // 
            btnExpand.BackColor = Color.FromArgb(34, 46, 59);
            btnExpand.Dock = DockStyle.Fill;
            btnExpand.FlatStyle = FlatStyle.Flat;
            btnExpand.ForeColor = Color.FromArgb(246, 247, 247);
            btnExpand.Location = new Point(294, 3);
            btnExpand.Name = "btnExpand";
            btnExpand.Size = new Size(92, 60);
            btnExpand.TabIndex = 1;
            btnExpand.Text = "button2";
            btnExpand.UseVisualStyleBackColor = false;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.ForeColor = Color.FromArgb(246, 247, 247);
            lblUser.Location = new Point(453, 45);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(68, 30);
            lblUser.TabIndex = 4;
            lblUser.Text = "label1";
            // 
            // ControlFeedbackCard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 46, 59);
            Controls.Add(panelContent);
            Controls.Add(panelBase);
            Name = "ControlFeedbackCard";
            Size = new Size(1300, 400);
            panelContent.ResumeLayout(false);
            panelBase.ResumeLayout(false);
            panelBase.PerformLayout();
            tlpButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblTitle;
        private Label lblId;
        private Panel panelContent;
        private RichTextBox rtbMessage;
        private Panel panelBase;
        private Label lblUser;
        private TableLayoutPanel tlpButtons;
        private Button btnRead;
        private Button btnExpand;
        private Button btnDelete;
    }
}
