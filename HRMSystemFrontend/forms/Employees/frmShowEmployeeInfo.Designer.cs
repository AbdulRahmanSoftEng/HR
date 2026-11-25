namespace HRMSystemFrontend.forms.Employees
{
    partial class frmShowEmployeeInfo
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
            label1 = new Label();
            SuspendLayout();
            // 
            // ctrlEmployeeInfo1
            // 
            ctrlEmployeeInfo1.Location = new Point(12, 106);
            ctrlEmployeeInfo1.Name = "ctrlEmployeeInfo1";
            ctrlEmployeeInfo1.Size = new Size(553, 393);
            ctrlEmployeeInfo1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(21, 91, 255);
            label1.Location = new Point(160, 35);
            label1.Name = "label1";
            label1.Size = new Size(223, 28);
            label1.TabIndex = 1;
            label1.Text = "Employee Information";
            // 
            // frmShowEmployeeInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 511);
            Controls.Add(label1);
            Controls.Add(ctrlEmployeeInfo1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmShowEmployeeInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmShowInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UserControle.ctrlEmployeeInfo ctrlEmployeeInfo1;
        private Label label1;
    }
}