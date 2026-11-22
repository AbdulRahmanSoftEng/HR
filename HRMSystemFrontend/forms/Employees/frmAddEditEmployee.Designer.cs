namespace HRMSystemFrontend.forms.Employees
{
    partial class frmAddEditEmployee
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
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            this.cbDepartment = new ComboBox();
            this.txtEmpCode = new TextBox();
            txtPhone = new TextBox();
            label1 = new Label();
            txtFullName = new TextBox();
            txtJobTitle = new TextBox();
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
            lblTitle.Text = "Add New Employee";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 311);
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
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(this.cbDepartment);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtJobTitle);
            panel1.Controls.Add(this.txtEmpCode);
            panel1.Controls.Add(txtFullName);
            panel1.Location = new Point(12, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(659, 232);
            panel1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 28);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 8;
            label4.Text = "Full Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 85);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 9;
            label3.Tag = "p";
            label3.Text = "Emp Code";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(355, 147);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 10;
            label5.Text = "Department";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 90);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 10;
            label2.Text = "Jobe Title";
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new Point(355, 170);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.RightToLeft = RightToLeft.Yes;
            this.cbDepartment.Size = new Size(269, 28);
            this.cbDepartment.TabIndex = 7;
            // 
            // txtEmpCode
            // 
            this.txtEmpCode.Location = new Point(27, 108);
            this.txtEmpCode.Name = "txtEmpCode";
            this.txtEmpCode.Size = new Size(269, 27);
            this.txtEmpCode.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(27, 170);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(269, 27);
            txtPhone.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 147);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 9;
            label1.Tag = "p";
            label1.Text = "Phone";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(27, 51);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(597, 27);
            txtFullName.TabIndex = 5;
            // 
            // txtJobTitle
            // 
            txtJobTitle.Location = new Point(355, 108);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.Size = new Size(269, 27);
            txtJobTitle.TabIndex = 4;
            // 
            // frmAddEditEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 367);
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmAddEditEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmAddEditEmployee_Load;
            panel1.PerformLayout();
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private Button btnSave;
        private Panel panel1;
   
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label2;
        private ComboBox cbDepartment;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label1;
        private TextBox txtEmpCode;
        private TextBox txtPhone;
        private TextBox txtJobTitle;
        private TextBox txtFullName;
    }
}