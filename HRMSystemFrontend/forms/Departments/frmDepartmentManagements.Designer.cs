namespace HRMSystemFrontend.forms.Departments
{
    partial class frmDepartmentManagements
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
            cbSearch = new ComboBox();
            txtSearch = new TextBox();
            lblCount = new Label();
            dgvDepartements = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showInfoToolStripMenuItem = new ToolStripMenuItem();
            updateInfoToolStripMenuItem = new ToolStripMenuItem();
            deleteUserToolStripMenuItem = new ToolStripMenuItem();
            sendSMSToolStripMenuItem = new ToolStripMenuItem();
            sennEMAILToolStripMenuItem = new ToolStripMenuItem();
            btnAddNewDep = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDepartements).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cbSearch
            // 
            cbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(840, 365);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(267, 28);
            cbSearch.TabIndex = 11;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtSearch.Location = new Point(1119, 365);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(373, 27);
            txtSearch.TabIndex = 9;
            // 
            // lblCount
            // 
            lblCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCount.Location = new Point(1432, 819);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(51, 20);
            lblCount.TabIndex = 8;
            lblCount.Text = "label1";
            // 
            // dgvDepartements
            // 
            dgvDepartements.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDepartements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepartements.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvDepartements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartements.Location = new Point(12, 407);
            dgvDepartements.Name = "dgvDepartements";
            dgvDepartements.RightToLeft = RightToLeft.No;
            dgvDepartements.RowHeadersWidth = 51;
            dgvDepartements.Size = new Size(1480, 400);
            dgvDepartements.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showInfoToolStripMenuItem, updateInfoToolStripMenuItem, deleteUserToolStripMenuItem, sendSMSToolStripMenuItem, sennEMAILToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RightToLeft = RightToLeft.Yes;
            contextMenuStrip1.Size = new Size(178, 124);
            // 
            // showInfoToolStripMenuItem
            // 
            showInfoToolStripMenuItem.Name = "showInfoToolStripMenuItem";
            showInfoToolStripMenuItem.Size = new Size(177, 24);
            showInfoToolStripMenuItem.Text = "Show User Info";
            // 
            // updateInfoToolStripMenuItem
            // 
            updateInfoToolStripMenuItem.Name = "updateInfoToolStripMenuItem";
            updateInfoToolStripMenuItem.Size = new Size(177, 24);
            updateInfoToolStripMenuItem.Text = "Update User";
            // 
            // deleteUserToolStripMenuItem
            // 
            deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            deleteUserToolStripMenuItem.Size = new Size(177, 24);
            deleteUserToolStripMenuItem.Text = "Delete User";
            // 
            // sendSMSToolStripMenuItem
            // 
            sendSMSToolStripMenuItem.Name = "sendSMSToolStripMenuItem";
            sendSMSToolStripMenuItem.Size = new Size(177, 24);
            sendSMSToolStripMenuItem.Text = "Send SMS";
            // 
            // sennEMAILToolStripMenuItem
            // 
            sennEMAILToolStripMenuItem.Name = "sennEMAILToolStripMenuItem";
            sennEMAILToolStripMenuItem.Size = new Size(177, 24);
            sennEMAILToolStripMenuItem.Text = "Senn EMAIL";
            // 
            // btnAddNewDep
            // 
            btnAddNewDep.BackColor = Color.ForestGreen;
            btnAddNewDep.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddNewDep.ForeColor = Color.White;
            btnAddNewDep.Location = new Point(12, 350);
            btnAddNewDep.Name = "btnAddNewDep";
            btnAddNewDep.Size = new Size(192, 44);
            btnAddNewDep.TabIndex = 12;
            btnAddNewDep.Text = "Add";
            btnAddNewDep.UseVisualStyleBackColor = false;
            btnAddNewDep.Click += btnAddNewDepartment_Click;
            // 
            // frmDepartmentManagements
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 872);
            Controls.Add(btnAddNewDep);
            Controls.Add(cbSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblCount);
            Controls.Add(dgvDepartements);
            Name = "frmDepartmentManagements";
            Text = "frmDepartments";
            Load += frmDepartmentManagements_Load;
            Controls.SetChildIndex(dgvDepartements, 0);
            Controls.SetChildIndex(lblCount, 0);
            Controls.SetChildIndex(txtSearch, 0);
            Controls.SetChildIndex(cbSearch, 0);
            Controls.SetChildIndex(btnAddNewDep, 0);
            ((System.ComponentModel.ISupportInitialize)dgvDepartements).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbSearch;
        private TextBox txtSearch;
        private Label lblCount;
        private DataGridView dgvDepartements;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showInfoToolStripMenuItem;
        private ToolStripMenuItem updateInfoToolStripMenuItem;
        private ToolStripMenuItem deleteUserToolStripMenuItem;
        private ToolStripMenuItem sendSMSToolStripMenuItem;
        private ToolStripMenuItem sennEMAILToolStripMenuItem;
        private Button btnAddNewDep;
    }
}