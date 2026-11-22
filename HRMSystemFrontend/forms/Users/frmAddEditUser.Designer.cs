namespace HRMSystemFrontend.forms.Users
{
    partial class frmAddEditUser
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
        private async Task InitializeComponent()
        {
            lblTitle = new Label();
            btnSave = new Button();
            panel1 = new Panel();
            rdUnActive = new RadioButton();
            rdActive = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            cbRoles = new ComboBox();
            cbEmployees = new ComboBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(7, 94, 213);
            lblTitle.Location = new Point(37, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(147, 28);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Add New User";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 296);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 39);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(rdUnActive);
            panel1.Controls.Add(rdActive);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbRoles);
            panel1.Controls.Add(cbEmployees);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Location = new Point(12, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(659, 205);
            panel1.TabIndex = 6;
            // 
            // rdUnActive
            // 
            rdUnActive.AutoSize = true;
            rdUnActive.Location = new Point(131, 153);
            rdUnActive.Name = "rdUnActive";
            rdUnActive.Size = new Size(93, 24);
            rdUnActive.TabIndex = 11;
            rdUnActive.TabStop = true;
            rdUnActive.Text = "Un Active";
            rdUnActive.UseVisualStyleBackColor = true;
            // 
            // rdActive
            // 
            rdActive.AutoSize = true;
            rdActive.Location = new Point(36, 153);
            rdActive.Name = "rdActive";
            rdActive.Size = new Size(71, 24);
            rdActive.TabIndex = 12;
            rdActive.TabStop = true;
            rdActive.Tag = "1";
            rdActive.Text = "Active";
            rdActive.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 28);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 8;
            label4.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 85);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 9;
            label3.Tag = "p";
            label3.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(363, 31);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 10;
            label5.Text = "Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 85);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 10;
            label2.Text = "Role";
            // 
            // cbRoles
            // 
            cbRoles.AccessibleDescription = "";
            cbRoles.FormattingEnabled = true;
            cbRoles.Location = new Point(363, 108);
            cbRoles.Name = "cbRoles";
            cbRoles.RightToLeft = RightToLeft.Yes;
            cbRoles.Size = new Size(269, 28);
            cbRoles.TabIndex = 6;
            // 
            // cbEmployees
            // 
            cbEmployees.FormattingEnabled = true;
            cbEmployees.Location = new Point(363, 54);
            cbEmployees.Name = "cbEmployees";
            cbEmployees.RightToLeft = RightToLeft.Yes;
            cbEmployees.Size = new Size(269, 28);
            cbEmployees.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(27, 108);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(269, 27);
            txtPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(27, 51);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(269, 27);
            txtUsername.TabIndex = 5;
            // 
            // frmAddEditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 347);
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmAddEditUser";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmAddEditUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private Button btnSave;
        private Panel panel1;
        private RadioButton rdUnActive;
        private RadioButton rdActive;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label2;
        private ComboBox cbRoles;
        private ComboBox cbEmployees;
        private TextBox txtPassword;
        private TextBox txtUsername;
    }
}