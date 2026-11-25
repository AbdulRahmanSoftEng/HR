using System.Net.NetworkInformation;

namespace HRMSystemFrontend.forms.Commons
{
    partial class frmHeader
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
            panel1 = new Panel();
            lblTimeShared = new Label();
            lblDateShared = new Label();
            lblTitleForm = new Label();
            s = new Label();
            pictureBox7 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox6 = new PictureBox();
            lblCurrentUser = new Label();
            pictureBox2 = new PictureBox();
            lblDescForm = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblTimeShared);
            panel1.Controls.Add(lblDateShared);
            panel1.Controls.Add(lblTitleForm);
            panel1.Controls.Add(s);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(lblCurrentUser);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lblDescForm);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1478, 80);
            panel1.TabIndex = 0;
            // 
            // lblTimeShared
            // 
            lblTimeShared.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblTimeShared.BackColor = Color.Transparent;
            lblTimeShared.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTimeShared.ForeColor = Color.FromArgb(7, 94, 213);
            lblTimeShared.Location = new Point(1313, 13);
            lblTimeShared.Name = "lblTimeShared";
            lblTimeShared.RightToLeft = RightToLeft.No;
            lblTimeShared.Size = new Size(120, 58);
            lblTimeShared.TabIndex = 0;
            lblTimeShared.Text = "10:55:21";
            lblTimeShared.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDateShared
            // 
            lblDateShared.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblDateShared.BackColor = Color.Transparent;
            lblDateShared.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDateShared.ForeColor = Color.FromArgb(7, 94, 213);
            lblDateShared.Location = new Point(1123, 13);
            lblDateShared.Name = "lblDateShared";
            lblDateShared.RightToLeft = RightToLeft.No;
            lblDateShared.Size = new Size(145, 58);
            lblDateShared.TabIndex = 0;
            lblDateShared.Text = "2024 - 12 - 11";
            lblDateShared.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitleForm
            // 
            lblTitleForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitleForm.BackColor = Color.Transparent;
            lblTitleForm.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitleForm.Location = new Point(397, 0);
            lblTitleForm.Name = "lblTitleForm";
            lblTitleForm.Size = new Size(422, 42);
            lblTitleForm.TabIndex = 9;
            lblTitleForm.Text = "Dashbord";
            lblTitleForm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // s
            // 
            s.AutoSize = true;
            s.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            s.Location = new Point(73, 27);
            s.Name = "s";
            s.Size = new Size(277, 31);
            s.TabIndex = 9;
            s.Text = "HR Management System";
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox7.Image = Properties.Resources.time;
            pictureBox7.Location = new Point(1274, 29);
            pictureBox7.Margin = new Padding(3, 5, 3, 5);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(33, 27);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 7;
            pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox4.Image = Properties.Resources.date;
            pictureBox4.Location = new Point(1084, 29);
            pictureBox4.Margin = new Padding(3, 5, 3, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(33, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DodgerBlue;
            panel3.Location = new Point(70, 17);
            panel3.Margin = new Padding(3, 10, 3, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(2, 50);
            panel3.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.human_resources;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Margin = new Padding(3, 10, 3, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Glossy_Blue_Ribbon_Wave;
            pictureBox6.Location = new Point(-20, -105);
            pictureBox6.Margin = new Padding(3, 19, 3, 19);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(358, 234);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblCurrentUser.BackColor = Color.Transparent;
            lblCurrentUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentUser.ForeColor = Color.FromArgb(128, 128, 255);
            lblCurrentUser.Location = new Point(875, 20);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.RightToLeft = RightToLeft.No;
            lblCurrentUser.Size = new Size(203, 45);
            lblCurrentUser.TabIndex = 0;
            lblCurrentUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.current_user;
            pictureBox2.Location = new Point(840, 25);
            pictureBox2.Margin = new Padding(3, 8, 3, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // lblDescForm
            // 
            lblDescForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDescForm.BackColor = Color.Transparent;
            lblDescForm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescForm.ForeColor = SystemColors.AppWorkspace;
            lblDescForm.Location = new Point(397, 42);
            lblDescForm.Name = "lblDescForm";
            lblDescForm.Size = new Size(422, 39);
            lblDescForm.TabIndex = 9;
            lblDescForm.Text = "HR Management System";
            lblDescForm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(7, 94, 213);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 860);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1478, 15);
            panel2.TabIndex = 1;
            // 
            // frmHeader
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 875);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmHeader";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Header";
            Load += frmHeader_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTimeShared;
        private System.Windows.Forms.Label lblDateShared;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Panel panel3;
        private Label s;
        private PictureBox pictureBox6;
        private Label lblDescForm;
        private Label lblTitleForm;
        private PictureBox pictureBox7;
    }
}