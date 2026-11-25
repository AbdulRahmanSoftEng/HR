namespace HRMSystemFrontend.forms.Commons
{
    partial class Msg
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblMessageTitle = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pbMessageIcon = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbMessageIcon).BeginInit();
            SuspendLayout();
            // 
            // lblMessageTitle
            // 
            lblMessageTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblMessageTitle.BackColor = Color.White;
            lblMessageTitle.Font = new Font("Segoe UI Semibold", 12.2F, FontStyle.Bold);
            lblMessageTitle.ForeColor = Color.Black;
            lblMessageTitle.Location = new Point(12, 9);
            lblMessageTitle.Name = "lblMessageTitle";
            lblMessageTitle.RightToLeft = RightToLeft.No;
            lblMessageTitle.Size = new Size(450, 76);
            lblMessageTitle.TabIndex = 53;
            lblMessageTitle.Text = "سبحان الله وبحمدة سبحان الله العظيم";
            lblMessageTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pbMessageIcon
            // 
            pbMessageIcon.Image = Properties.Resources.successfully;
            pbMessageIcon.Location = new Point(106, 101);
            pbMessageIcon.Name = "pbMessageIcon";
            pbMessageIcon.Size = new Size(281, 126);
            pbMessageIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbMessageIcon.TabIndex = 54;
            pbMessageIcon.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 94, 213);
            panel1.Location = new Point(-1, 261);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 11);
            panel1.TabIndex = 55;
            // 
            // Msg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(474, 271);
            Controls.Add(panel1);
            Controls.Add(pbMessageIcon);
            Controls.Add(lblMessageTitle);
            Name = "Msg";
            Load += Msg_Load;
            Controls.SetChildIndex(lblMessageTitle, 0);
            Controls.SetChildIndex(pbMessageIcon, 0);
            Controls.SetChildIndex(panel1, 0);
            ((System.ComponentModel.ISupportInitialize)pbMessageIcon).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMessageTitle;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pbMessageIcon;
        private Panel panel1;
    }
}