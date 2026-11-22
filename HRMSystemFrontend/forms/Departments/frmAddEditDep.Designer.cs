namespace HRMSystemFrontend.forms.Departments
{
    partial class frmAddEditDep
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
            label1 = new Label();
            label4p = new Label();
            txtDesc = new TextBox();
            txtDepartmentName = new TextBox();
            rbActive = new RadioButton();
            rbUnActive = new RadioButton();
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
            lblTitle.Size = new Size(197, 28);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Add New Employee";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 320);
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
            panel1.Controls.Add(rbUnActive);
            panel1.Controls.Add(rbActive);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4p);
            panel1.Controls.Add(txtDesc);
            panel1.Controls.Add(txtDepartmentName);
            panel1.Location = new Point(12, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(659, 228);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 93);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 8;
            label1.Text = "Description";
            // 
            // label4p
            // 
            label4p.AutoSize = true;
            label4p.Location = new Point(27, 28);
            label4p.Name = "label4p";
            label4p.Size = new Size(133, 20);
            label4p.TabIndex = 8;
            label4p.Text = "Department Name";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(27, 116);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(597, 27);
            txtDesc.TabIndex = 5;
            // 
            // txtDepartmentName
            // 
            txtDepartmentName.Location = new Point(27, 51);
            txtDepartmentName.Name = "txtDepartmentName";
            txtDepartmentName.Size = new Size(597, 27);
            txtDepartmentName.TabIndex = 5;
            // 
            // rbActive
            // 
            rbActive.AutoSize = true;
            rbActive.Location = new Point(27, 172);
            rbActive.Name = "rbActive";
            rbActive.Size = new Size(71, 24);
            rbActive.TabIndex = 0;
            rbActive.TabStop = true;
            rbActive.Text = "Active";
            rbActive.UseVisualStyleBackColor = true;
            // 
            // rbUnActive
            // 
            rbUnActive.AutoSize = true;
            rbUnActive.Location = new Point(150, 172);
            rbUnActive.Name = "rbUnActive";
            rbUnActive.Size = new Size(93, 24);
            rbUnActive.TabIndex = 0;
            rbUnActive.TabStop = true;
            rbUnActive.Text = "Un Active";
            rbUnActive.UseVisualStyleBackColor = true;
            // 
            // frmAddEditDep
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 371);
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmAddEditDep";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmAddEditDep_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private Label lblTitle;
        private Button btnSave;
        private Panel panel1;
   
        private Label label4p;
        private TextBox txtDepartmentName;
        private Label label1;
        private TextBox txtDesc;
        private RadioButton rbUnActive;
        private RadioButton rbActive;
    }
}