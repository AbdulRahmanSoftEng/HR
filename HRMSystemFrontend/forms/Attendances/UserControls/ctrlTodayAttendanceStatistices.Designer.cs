namespace HRMSystemFrontend.forms.Attendances.UserControls
{
    partial class ctrlTodayAttendanceStatistices
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
            pbIcon = new PictureBox();
            lblNumber = new Label();
            lblTitle = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pbIcon);
            panel1.Controls.Add(lblNumber);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 120);
            panel1.TabIndex = 0;
            // 
            // pbIcon
            // 
            pbIcon.Image = Properties.Resources.date;
            pbIcon.Location = new Point(23, 31);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new Size(68, 62);
            pbIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbIcon.TabIndex = 1;
            pbIcon.TabStop = false;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblNumber.ForeColor = Color.Black;
            lblNumber.Location = new Point(106, 56);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(49, 37);
            lblNumber.TabIndex = 0;
            lblNumber.Text = "14";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 90);
            lblTitle.Location = new Point(106, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(123, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Total Employees";
            // 
            // ctrlTodayAttendanceStatistices
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ctrlTodayAttendanceStatistices";
            Size = new Size(250, 120);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbIcon;
        private Label lblTitle;
        private Label lblNumber;
    }
}
