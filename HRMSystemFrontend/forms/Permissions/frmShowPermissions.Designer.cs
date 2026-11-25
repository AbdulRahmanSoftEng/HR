namespace HRMSystemFrontend.forms.Permissions
{
    partial class frmShowPermissions
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
            dgvPermissions = new DataGridView();
            label1 = new Label();
            lblCount = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPermissions).BeginInit();
            SuspendLayout();
            // 
            // dgvPermissions
            // 
            dgvPermissions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPermissions.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvPermissions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPermissions.Location = new Point(0, 55);
            dgvPermissions.Name = "dgvPermissions";
            dgvPermissions.RightToLeft = RightToLeft.No;
            dgvPermissions.RowHeadersWidth = 51;
            dgvPermissions.Size = new Size(619, 350);
            dgvPermissions.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(27, 91, 255);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(171, 28);
            label1.TabIndex = 15;
            label1.Text = "User Permissions";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCount.Location = new Point(12, 418);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(51, 20);
            lblCount.TabIndex = 16;
            lblCount.Text = "label2";
            // 
            // frmShowPermissions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 450);
            Controls.Add(lblCount);
            Controls.Add(label1);
            Controls.Add(dgvPermissions);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmShowPermissions";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmShowPermissions_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPermissions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPermissions;
        private Label label1;
        private Label lblCount;
    }
}