namespace HRMSystemFrontend.forms.Attendances
{
    partial class frmAttendanceManagements
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
            ctrlTodayAttendanceStatistices1 = new HRMSystemFrontend.forms.Attendances.UserControls.ctrlTodayAttendanceStatistices();
            ctrlTodayAttendanceStatistices2 = new HRMSystemFrontend.forms.Attendances.UserControls.ctrlTodayAttendanceStatistices();
            ctrlTodayAttendanceStatistices3 = new HRMSystemFrontend.forms.Attendances.UserControls.ctrlTodayAttendanceStatistices();
            cbAttendanceForAttendance = new ComboBox();
            lblCount = new Label();
            rbCheckOut = new RadioButton();
            groupBox1 = new GroupBox();
            pictureBox3 = new PictureBox();
            btnMakAttendance = new Button();
            rbCheckIn = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            cbFilterTypes = new ComboBox();
            groupBox2 = new GroupBox();
            dgvEmployees = new DataGridView();
            txtSearch = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // ctrlTodayAttendanceStatistices1
            // 
            ctrlTodayAttendanceStatistices1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ctrlTodayAttendanceStatistices1.Location = new Point(1119, 127);
            ctrlTodayAttendanceStatistices1.Name = "ctrlTodayAttendanceStatistices1";
            ctrlTodayAttendanceStatistices1.Size = new Size(312, 119);
            ctrlTodayAttendanceStatistices1.TabIndex = 2;
            // 
            // ctrlTodayAttendanceStatistices2
            // 
            ctrlTodayAttendanceStatistices2.Anchor = AnchorStyles.Top;
            ctrlTodayAttendanceStatistices2.Location = new Point(584, 127);
            ctrlTodayAttendanceStatistices2.Name = "ctrlTodayAttendanceStatistices2";
            ctrlTodayAttendanceStatistices2.Size = new Size(312, 119);
            ctrlTodayAttendanceStatistices2.TabIndex = 2;
            // 
            // ctrlTodayAttendanceStatistices3
            // 
            ctrlTodayAttendanceStatistices3.Location = new Point(72, 127);
            ctrlTodayAttendanceStatistices3.Name = "ctrlTodayAttendanceStatistices3";
            ctrlTodayAttendanceStatistices3.Size = new Size(312, 119);
            ctrlTodayAttendanceStatistices3.TabIndex = 2;
            // 
            // cbAttendanceForAttendance
            // 
            cbAttendanceForAttendance.FormattingEnabled = true;
            cbAttendanceForAttendance.Location = new Point(416, 45);
            cbAttendanceForAttendance.Name = "cbAttendanceForAttendance";
            cbAttendanceForAttendance.Size = new Size(370, 28);
            cbAttendanceForAttendance.TabIndex = 3;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCount.Location = new Point(29, 396);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(149, 20);
            lblCount.TabIndex = 4;
            lblCount.Text = "Total Employees: 22";
            // 
            // rbCheckOut
            // 
            rbCheckOut.AutoSize = true;
            rbCheckOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbCheckOut.ForeColor = Color.FromArgb(64, 64, 64);
            rbCheckOut.Location = new Point(560, 96);
            rbCheckOut.Name = "rbCheckOut";
            rbCheckOut.Size = new Size(101, 24);
            rbCheckOut.TabIndex = 5;
            rbCheckOut.Text = "Check Out";
            rbCheckOut.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(btnMakAttendance);
            groupBox1.Controls.Add(rbCheckIn);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbAttendanceForAttendance);
            groupBox1.Controls.Add(rbCheckOut);
            groupBox1.Location = new Point(12, 271);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(1478, 149);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mark Attendance";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.human_resources;
            pictureBox3.Location = new Point(56, 45);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(102, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // btnMakAttendance
            // 
            btnMakAttendance.BackColor = Color.FromArgb(7, 94, 213);
            btnMakAttendance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMakAttendance.ForeColor = Color.White;
            btnMakAttendance.Location = new Point(911, 45);
            btnMakAttendance.Name = "btnMakAttendance";
            btnMakAttendance.Size = new Size(218, 47);
            btnMakAttendance.TabIndex = 0;
            btnMakAttendance.Text = "Mark Attendance";
            btnMakAttendance.UseVisualStyleBackColor = false;
            btnMakAttendance.Click += btnMakAttendance_Click;
            // 
            // rbCheckIn
            // 
            rbCheckIn.AutoSize = true;
            rbCheckIn.Checked = true;
            rbCheckIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbCheckIn.ForeColor = Color.FromArgb(64, 64, 64);
            rbCheckIn.Location = new Point(416, 96);
            rbCheckIn.Name = "rbCheckIn";
            rbCheckIn.Size = new Size(89, 24);
            rbCheckIn.TabIndex = 5;
            rbCheckIn.TabStop = true;
            rbCheckIn.Text = "Check In";
            rbCheckIn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(227, 98);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 4;
            label2.Text = "Attendance Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(227, 48);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 4;
            label3.Text = "Employee ID:";
            // 
            // cbFilterTypes
            // 
            cbFilterTypes.FormattingEnabled = true;
            cbFilterTypes.Location = new Point(489, 45);
            cbFilterTypes.Name = "cbFilterTypes";
            cbFilterTypes.RightToLeft = RightToLeft.Yes;
            cbFilterTypes.Size = new Size(370, 28);
            cbFilterTypes.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dgvEmployees);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(lblCount);
            groupBox2.Controls.Add(cbFilterTypes);
            groupBox2.Location = new Point(12, 426);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.No;
            groupBox2.Size = new Size(1478, 424);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Attendance Records";
            // 
            // dgvEmployees
            // 
            dgvEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(29, 85);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RightToLeft = RightToLeft.No;
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.Size = new Size(1418, 304);
            dgvEmployees.TabIndex = 17;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(29, 45);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(443, 27);
            txtSearch.TabIndex = 16;
            // 
            // frmAttendanceManagements
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 872);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(ctrlTodayAttendanceStatistices3);
            Controls.Add(ctrlTodayAttendanceStatistices2);
            Controls.Add(ctrlTodayAttendanceStatistices1);
            Name = "frmAttendanceManagements";
            RightToLeft = RightToLeft.No;
            Text = "frmAttendanceManagements";
            Load += frmAttendanceManagements_Load;
            Controls.SetChildIndex(ctrlTodayAttendanceStatistices1, 0);
            Controls.SetChildIndex(ctrlTodayAttendanceStatistices2, 0);
            Controls.SetChildIndex(ctrlTodayAttendanceStatistices3, 0);
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(groupBox2, 0);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private UserControls.ctrlTodayAttendanceStatistices ctrlTodayAttendanceStatistices1;
        private UserControls.ctrlTodayAttendanceStatistices ctrlTodayAttendanceStatistices2;
        private UserControls.ctrlTodayAttendanceStatistices ctrlTodayAttendanceStatistices3;
        private ComboBox cbAttendanceForAttendance;
        private Label lblCount;
        private RadioButton rbCheckOut;
        private GroupBox groupBox1;
        private Button btnMakAttendance;
        private RadioButton rbCheckIn;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox3;
        private ComboBox cbFilterTypes;
        private GroupBox groupBox2;
        private DataGridView dgvEmployees;
        private TextBox txtSearch;
    }
}