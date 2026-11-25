namespace HRMSystemFrontend.forms.Users
{
    partial class frmUserManagements
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
            dgvUsers = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showInfoToolStripMenuItem = new ToolStripMenuItem();
            updateInfoToolStripMenuItem = new ToolStripMenuItem();
            deleteUserToolStripMenuItem = new ToolStripMenuItem();
            sendSMSToolStripMenuItem = new ToolStripMenuItem();
            sennEMAILToolStripMenuItem = new ToolStripMenuItem();
            addUserToolStripMenuItem = new ToolStripMenuItem();
            lblCount = new Label();
            textBox1 = new TextBox();
            btnAddNew = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.ContextMenuStrip = contextMenuStrip1;
            dgvUsers.Location = new Point(12, 408);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RightToLeft = RightToLeft.No;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(1480, 400);
            dgvUsers.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showInfoToolStripMenuItem, updateInfoToolStripMenuItem, deleteUserToolStripMenuItem, sendSMSToolStripMenuItem, sennEMAILToolStripMenuItem, addUserToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RightToLeft = RightToLeft.Yes;
            contextMenuStrip1.Size = new Size(211, 176);
            // 
            // showInfoToolStripMenuItem
            // 
            showInfoToolStripMenuItem.Name = "showInfoToolStripMenuItem";
            showInfoToolStripMenuItem.Size = new Size(210, 24);
            showInfoToolStripMenuItem.Text = "Show User Info";
            showInfoToolStripMenuItem.Click += showInfoToolStripMenuItem_Click;
            // 
            // updateInfoToolStripMenuItem
            // 
            updateInfoToolStripMenuItem.Name = "updateInfoToolStripMenuItem";
            updateInfoToolStripMenuItem.Size = new Size(210, 24);
            updateInfoToolStripMenuItem.Text = "Update User";
            updateInfoToolStripMenuItem.Click += updateInfoToolStripMenuItem_Click;
            // 
            // deleteUserToolStripMenuItem
            // 
            deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            deleteUserToolStripMenuItem.Size = new Size(210, 24);
            deleteUserToolStripMenuItem.Text = "Delete User";
            // 
            // sendSMSToolStripMenuItem
            // 
            sendSMSToolStripMenuItem.Name = "sendSMSToolStripMenuItem";
            sendSMSToolStripMenuItem.Size = new Size(210, 24);
            sendSMSToolStripMenuItem.Text = "Send SMS";
            // 
            // sennEMAILToolStripMenuItem
            // 
            sennEMAILToolStripMenuItem.Name = "sennEMAILToolStripMenuItem";
            sennEMAILToolStripMenuItem.Size = new Size(210, 24);
            sennEMAILToolStripMenuItem.Text = "Senn EMAIL";
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(210, 24);
            addUserToolStripMenuItem.Text = "Add User";
            addUserToolStripMenuItem.Click += addUserToolStripMenuItem_Click;
            // 
            // lblCount
            // 
            lblCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCount.Location = new Point(1432, 820);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(51, 20);
            lblCount.TabIndex = 3;
            lblCount.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.Location = new Point(1119, 366);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(373, 27);
            textBox1.TabIndex = 4;
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.ForestGreen;
            btnAddNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddNew.ForeColor = Color.White;
            btnAddNew.Location = new Point(12, 350);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(248, 43);
            btnAddNew.TabIndex = 5;
            btnAddNew.Text = "Add User";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(840, 366);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(267, 28);
            comboBox1.TabIndex = 6;
            // 
            // frmUserManagements
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 872);
            Controls.Add(comboBox1);
            Controls.Add(btnAddNew);
            Controls.Add(textBox1);
            Controls.Add(lblCount);
            Controls.Add(dgvUsers);
            Name = "frmUserManagements";
            Text = "frmUserManagements";
            Load += frmUserManagements_Load;
            Controls.SetChildIndex(dgvUsers, 0);
            Controls.SetChildIndex(lblCount, 0);
            Controls.SetChildIndex(textBox1, 0);
            Controls.SetChildIndex(btnAddNew, 0);
            Controls.SetChildIndex(comboBox1, 0);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsers;
        private Label lblCount;
        private TextBox textBox1;
        private Button btnAddNew;
        private ComboBox comboBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showInfoToolStripMenuItem;
        private ToolStripMenuItem updateInfoToolStripMenuItem;
        private ToolStripMenuItem deleteUserToolStripMenuItem;
        private ToolStripMenuItem sendSMSToolStripMenuItem;
        private ToolStripMenuItem sennEMAILToolStripMenuItem;
        private ToolStripMenuItem addUserToolStripMenuItem;
    }
}