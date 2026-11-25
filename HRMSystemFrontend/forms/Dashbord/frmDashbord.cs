using HRMSystemFrontend.DTOs.Attendance;
using HRMSystemFrontend.DTOs.Dashbord;
using HRMSystemFrontend.forms.Commons;
using HRMSystemFrontend.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace HRMSystemFrontend.forms.Dashbord
{
    public partial class frmDashbord : Commons.frmHeader
    {
        public frmDashbord(string title, string description)
            : base(title, description)
        {
            InitializeComponent();
        }

        private async void frmDashbord_Load(object sender, EventArgs e)
        {
            await LoadStatistics();
            await LoadRecentAttendances();
        }

        private async Task LoadStatistics()
        {
            try
            {
                string dashboardUrl = ConfigurationManager.AppSettings["DashboardUrl"];

                string requestUrl = $"{dashboardUrl.Trim('/')}/Statistics";

                var response = await Globle.httpClient.GetAsync(requestUrl);

                var statistics = await response.Content.ReadFromJsonAsync<DashboardDTO>();

                if (statistics != null)
                {
                    ctrlDashbordStatistics1.SetStatistics(statistics.ActiveEmployees, "Active Employees", Properties.Resources.current_user, 6, 66, 255);
                    ctrlDashbordStatistics2.SetStatistics(statistics.ActiveDepartments, "Active Departments", Properties.Resources.current_user, 52, 99, 150);
                    ctrlDashbordStatistics3.SetStatistics(statistics.TodayAttendance, "Today's Attendance", Properties.Resources.current_user, 44, 78, 66);
                    ctrlDashbordStatistics4.SetStatistics(statistics.TodayAbsence, "Today's Absence", Properties.Resources.current_user, 174, 99, 100);

                    ShowChart(statistics);
                }
            }
            catch (Exception ex)
            {
                Msg.ShowDialog("Error"+ex.Message, Shared.enTypeIcon.Error);
            }
        }

        private async Task LoadRecentAttendances()
        {
            try
            {
                string dashboardUrl = ConfigurationManager.AppSettings["DashboardUrl"];
                string requestUrl = $"{dashboardUrl.Trim('/')}/RecentAttendances";

                var response = await Globle.httpClient.GetAsync(requestUrl);
                var attendances = await response.Content.ReadFromJsonAsync<List<AttendanceDTO>>();
                if (attendances != null)
                {
                    dgvAttendances.DataSource = attendances;
                }
            }
            catch (Exception ex)
            {
                Msg.ShowDialog("Error" + ex.Message, Shared.enTypeIcon.Error);
            }
        }


        public void ShowChart(DashboardDTO statistics)
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Legends.Clear();
            chart1.Titles.Clear();

            // Create Chart Area
            ChartArea area = new ChartArea("MainArea");

            area.AxisX.Title = "Attendance Status";
            area.AxisY.Title = "Number of Employees";

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;

            chart1.ChartAreas.Add(area);

            // Create Series
            Series series = new Series("Attendance");

            series.ChartType = SeriesChartType.Doughnut;
            series.IsValueShownAsLabel = true;
            series.Label = "#VALX: #VALY";

            series.Points.AddXY(
                "Present",
                statistics.TodayAttendance
            );

            series.Points.AddXY(
                "Absent",
                statistics.TodayAbsence
            );

            chart1.Series.Add(series);

            // Chart Title
            chart1.Titles.Add("Today's Attendance");

            // Legend
            chart1.Legends.Add(new Legend("MainLegend"));
        }

    }
}
