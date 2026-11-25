namespace HRMSystemFrontend.UserControle
{
    partial class ctrlDashbordStatistics
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lblNumber = new Label();
            lblDesc = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.date;
            pictureBox1.Location = new Point(25, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(7, 94, 213);
            panel1.Location = new Point(102, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 66);
            panel1.TabIndex = 1;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblNumber.ForeColor = Color.Black;
            lblNumber.Location = new Point(126, 32);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(49, 37);
            lblNumber.TabIndex = 2;
            lblNumber.Text = "14";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDesc.ForeColor = Color.FromArgb(64, 64, 64);
            lblDesc.Location = new Point(126, 78);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(132, 20);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Active Employees";
            // 
            // ctrlDashbordStatistics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblDesc);
            Controls.Add(lblNumber);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "ctrlDashbordStatistics";
            Size = new Size(305, 135);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lblNumber;
        private Label lblDesc;
    }
}
