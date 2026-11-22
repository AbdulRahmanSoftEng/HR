namespace HRMSystemFrontend.forms.Roles
{
    partial class frmRoleManagements
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
            btnAddNewDep = new Button();
            cbSearch = new ComboBox();
            txtSearch = new TextBox();
            lblCount = new Label();
            dgvRoles = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            SuspendLayout();
            // 
            // btnAddNewDep
            // 
            btnAddNewDep.BackColor = Color.ForestGreen;
            btnAddNewDep.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddNewDep.ForeColor = Color.White;
            btnAddNewDep.Location = new Point(12, 347);
            btnAddNewDep.Name = "btnAddNewDep";
            btnAddNewDep.Size = new Size(192, 44);
            btnAddNewDep.TabIndex = 22;
            btnAddNewDep.Text = "Add";
            btnAddNewDep.UseVisualStyleBackColor = false;
            // 
            // cbSearch
            // 
            cbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(840, 362);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(267, 28);
            cbSearch.TabIndex = 21;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtSearch.Location = new Point(1119, 362);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(373, 27);
            txtSearch.TabIndex = 20;
            // 
            // lblCount
            // 
            lblCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCount.Location = new Point(1432, 816);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(51, 20);
            lblCount.TabIndex = 19;
            lblCount.Text = "label1";
            // 
            // dgvRoles
            // 
            dgvRoles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoles.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Location = new Point(12, 404);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.RightToLeft = RightToLeft.No;
            dgvRoles.RowHeadersWidth = 51;
            dgvRoles.Size = new Size(1480, 400);
            dgvRoles.TabIndex = 18;
            // 
            // frmRoleManagements
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 872);
            Controls.Add(btnAddNewDep);
            Controls.Add(cbSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblCount);
            Controls.Add(dgvRoles);
            Name = "frmRoleManagements";
            Text = "frmRoleManagements";
            Load += frmRoleManagements_Load;
            Controls.SetChildIndex(dgvRoles, 0);
            Controls.SetChildIndex(lblCount, 0);
            Controls.SetChildIndex(txtSearch, 0);
            Controls.SetChildIndex(cbSearch, 0);
            Controls.SetChildIndex(btnAddNewDep, 0);
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddNewDep;
        private ComboBox cbSearch;
        private TextBox txtSearch;
        private Label lblCount;
        private DataGridView dgvRoles;
    }
}