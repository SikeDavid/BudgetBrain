namespace BudgetBrainDesktop.UserControls.User.Cards.Settings
{
    partial class ControlProfileCard
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(24, 24);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(24);
            panel1.Size = new Size(1222, 698);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(246, 247, 247);
            label1.Location = new Point(27, 106);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 12);
            label1.Size = new Size(91, 50);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.FromArgb(246, 247, 247);
            label2.Location = new Point(27, 226);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 12, 0, 12);
            label2.Size = new Size(91, 62);
            label2.TabIndex = 0;
            label2.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.FromArgb(246, 247, 247);
            label3.Location = new Point(27, 372);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 12, 0, 12);
            label3.Size = new Size(91, 62);
            label3.TabIndex = 0;
            label3.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(349, 35);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 291);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(349, 35);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(27, 437);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(349, 35);
            textBox3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.FromArgb(246, 247, 247);
            label4.Location = new Point(27, 24);
            label4.Name = "label4";
            label4.Size = new Size(263, 45);
            label4.TabIndex = 2;
            label4.Text = "User information";
            // 
            // ControlProfileCard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Name = "ControlProfileCard";
            Padding = new Padding(24);
            Size = new Size(1270, 746);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
