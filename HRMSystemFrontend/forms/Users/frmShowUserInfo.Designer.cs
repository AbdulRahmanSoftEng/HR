namespace HRMSystemFrontend.forms.Users
{
    partial class frmShowUserInfo
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
            ctrlEmployeeInfo1 = new HRMSystemFrontend.UserControle.ctrlEmployeeInfo();
            ctrlUserInfo1 = new HRMSystemFrontend.forms.Users.UserControls.ctrlUserInfo();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // ctrlEmployeeInfo1
            // 
            ctrlEmployeeInfo1.Location = new Point(0, 67);
            ctrlEmployeeInfo1.Name = "ctrlEmployeeInfo1";
            ctrlEmployeeInfo1.Size = new Size(581, 397);
            ctrlEmployeeInfo1.TabIndex = 0;
            // 
            // ctrlUserInfo1
            // 
            ctrlUserInfo1.Location = new Point(0, 470);
            ctrlUserInfo1.Name = "ctrlUserInfo1";
            ctrlUserInfo1.Size = new Size(581, 190);
            ctrlUserInfo1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(21, 91, 255);
            label1.Location = new Point(195, 23);
            label1.Name = "label1";
            label1.Size = new Size(173, 28);
            label1.TabIndex = 2;
            label1.Text = "User Information";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            linkLabel1.Location = new Point(19, 669);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(93, 20);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Permissions";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // frmShowIUserInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 706);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(ctrlUserInfo1);
            Controls.Add(ctrlEmployeeInfo1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmShowIUserInfo";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UserControle.ctrlEmployeeInfo ctrlEmployeeInfo1;
        private UserControls.ctrlUserInfo ctrlUserInfo1;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}