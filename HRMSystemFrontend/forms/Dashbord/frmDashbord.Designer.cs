namespace HRMSystemFrontend.forms.Dashbord
{
    partial class frmDashbord
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            ctrlDashbordStatistics1 = new HRMSystemFrontend.UserControle.ctrlDashbordStatistics();
            ctrlDashbordStatistics2 = new HRMSystemFrontend.UserControle.ctrlDashbordStatistics();
            ctrlDashbordStatistics3 = new HRMSystemFrontend.UserControle.ctrlDashbordStatistics();
            ctrlDashbordStatistics4 = new HRMSystemFrontend.UserControle.ctrlDashbordStatistics();
            dgvAttendances = new DataGridView();
            label1 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAttendances).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // ctrlDashbordStatistics1
            // 
            ctrlDashbordStatistics1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ctrlDashbordStatistics1.BackColor = Color.White;
            ctrlDashbordStatistics1.Location = new Point(1115, 151);
            ctrlDashbordStatistics1.Name = "ctrlDashbordStatistics1";
            ctrlDashbordStatistics1.Size = new Size(305, 142);
            ctrlDashbordStatistics1.TabIndex = 2;
            // 
            // ctrlDashbordStatistics2
            // 
            ctrlDashbordStatistics2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ctrlDashbordStatistics2.BackColor = Color.White;
            ctrlDashbordStatistics2.Location = new Point(802, 151);
            ctrlDashbordStatistics2.Name = "ctrlDashbordStatistics2";
            ctrlDashbordStatistics2.Size = new Size(305, 142);
            ctrlDashbordStatistics2.TabIndex = 2;
            // 
            // ctrlDashbordStatistics3
            // 
            ctrlDashbordStatistics3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ctrlDashbordStatistics3.BackColor = Color.White;
            ctrlDashbordStatistics3.Location = new Point(491, 151);
            ctrlDashbordStatistics3.Name = "ctrlDashbordStatistics3";
            ctrlDashbordStatistics3.Size = new Size(305, 142);
            ctrlDashbordStatistics3.TabIndex = 2;
            // 
            // ctrlDashbordStatistics4
            // 
            ctrlDashbordStatistics4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ctrlDashbordStatistics4.BackColor = Color.White;
            ctrlDashbordStatistics4.Location = new Point(171, 151);
            ctrlDashbordStatistics4.Name = "ctrlDashbordStatistics4";
            ctrlDashbordStatistics4.Size = new Size(305, 142);
            ctrlDashbordStatistics4.TabIndex = 2;
            // 
            // dgvAttendances
            // 
            dgvAttendances.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAttendances.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendances.BackgroundColor = Color.White;
            dgvAttendances.BorderStyle = BorderStyle.None;
            dgvAttendances.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendances.GridColor = SystemColors.Control;
            dgvAttendances.Location = new Point(74, 367);
            dgvAttendances.Name = "dgvAttendances";
            dgvAttendances.RightToLeft = RightToLeft.No;
            dgvAttendances.RowHeadersWidth = 51;
            dgvAttendances.Size = new Size(661, 445);
            dgvAttendances.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(534, 328);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(201, 28);
            label1.TabIndex = 9;
            label1.Text = "Recent Attendances";
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(759, 367);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(661, 445);
            chart1.TabIndex = 10;
            chart1.Text = "chart1";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1203, 328);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(217, 28);
            label2.TabIndex = 9;
            label2.Text = "Attendance Overview";
            // 
            // frmDashbord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 872);
            Controls.Add(chart1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvAttendances);
            Controls.Add(ctrlDashbordStatistics4);
            Controls.Add(ctrlDashbordStatistics3);
            Controls.Add(ctrlDashbordStatistics2);
            Controls.Add(ctrlDashbordStatistics1);
            Name = "frmDashbord";
            Text = "frmDashbord";
            Load += frmDashbord_Load;
            Controls.SetChildIndex(ctrlDashbordStatistics1, 0);
            Controls.SetChildIndex(ctrlDashbordStatistics2, 0);
            Controls.SetChildIndex(ctrlDashbordStatistics3, 0);
            Controls.SetChildIndex(ctrlDashbordStatistics4, 0);
            Controls.SetChildIndex(dgvAttendances, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(chart1, 0);
            ((System.ComponentModel.ISupportInitialize)dgvAttendances).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UserControle.ctrlDashbordStatistics ctrlDashbordStatistics1;
        private UserControle.ctrlDashbordStatistics ctrlDashbordStatistics2;
        private UserControle.ctrlDashbordStatistics ctrlDashbordStatistics3;
        private UserControle.ctrlDashbordStatistics ctrlDashbordStatistics4;
        private DataGridView dgvAttendances;
        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label2;
    }
}