namespace HRMSystemFrontend.forms.Permissions
{
    partial class frmPermissionManangements
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
            dgvPermissions = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPermissions).BeginInit();
            SuspendLayout();
            // 
            // btnAddNewDep
            // 
            btnAddNewDep.BackColor = Color.ForestGreen;
            btnAddNewDep.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddNewDep.ForeColor = Color.White;
            btnAddNewDep.Location = new Point(12, 352);
            btnAddNewDep.Name = "btnAddNewDep";
            btnAddNewDep.Size = new Size(192, 44);
            btnAddNewDep.TabIndex = 17;
            btnAddNewDep.Text = "Add";
            btnAddNewDep.UseVisualStyleBackColor = false;
            // 
            // cbSearch
            // 
            cbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(840, 367);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(267, 28);
            cbSearch.TabIndex = 16;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtSearch.Location = new Point(1119, 367);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(373, 27);
            txtSearch.TabIndex = 15;
            // 
            // lblCount
            // 
            lblCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCount.Location = new Point(1432, 821);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(51, 20);
            lblCount.TabIndex = 14;
            lblCount.Text = "label1";
            // 
            // dgvPermissions
            // 
            dgvPermissions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPermissions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPermissions.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvPermissions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPermissions.Location = new Point(12, 409);
            dgvPermissions.Name = "dgvPermissions";
            dgvPermissions.RightToLeft = RightToLeft.No;
            dgvPermissions.RowHeadersWidth = 51;
            dgvPermissions.Size = new Size(1480, 400);
            dgvPermissions.TabIndex = 13;
            // 
            // frmPermissionManangements
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 872);
            Controls.Add(btnAddNewDep);
            Controls.Add(cbSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblCount);
            Controls.Add(dgvPermissions);
            Name = "frmPermissionManangements";
            Text = "frmPermissionManangements";
            Load += frmPermissionManangements_Load;
            Controls.SetChildIndex(dgvPermissions, 0);
            Controls.SetChildIndex(lblCount, 0);
            Controls.SetChildIndex(txtSearch, 0);
            Controls.SetChildIndex(cbSearch, 0);
            Controls.SetChildIndex(btnAddNewDep, 0);
            ((System.ComponentModel.ISupportInitialize)dgvPermissions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddNewDep;
        private ComboBox cbSearch;
        private TextBox txtSearch;
        private Label lblCount;
        private DataGridView dgvPermissions;
    }
}