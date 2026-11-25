using HRMSystemFrontend.DTOs;
using HRMSystemFrontend.forms.Commons;
using HRMSystemFrontend.Settings;
using HRMSystemFrontend.UserControle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Net.Http.Json;
using HRMSystemFrontend.DTOs.Attendance;
using HRMSystemFrontend.forms.Attendances.UserControls;

namespace HRMSystemFrontend.forms.Attendances
{
    public partial class frmAttendanceManagements : frmHeader
    {
        private Dictionary<string, int> employeesForAttendance;
        public frmAttendanceManagements(string title, string desc)
            : base(title, desc)
        {
            InitializeComponent();
        }

        private async void frmAttendanceManagements_Load(object sender, EventArgs e)
        {

            await LoadAttendanceStatistics();
            await LoadEmployeesForAttendance();
            await LoadTodayAttendanceRecords(new TodayAttendanceRecordPagination { PageNumber = 1, PagePerNumber = 10 });

        }

        private void ColeringOfAbsentOrPersent(DataGridView dataGridView, string columnName, string presentValue, Color presentColor, Color absentColor)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[columnName].Value != null && row.Cells[columnName].Value.ToString() == presentValue)
                {
                    row.Cells[columnName].Style.BackColor = presentColor;
                }
                else
                {
                    row.Cells[columnName].Style.BackColor = absentColor;
                }
            }
        }

        private async Task LoadEmployeesForAttendance()
        {
            employeesForAttendance = new Dictionary<string, int>();
            try
            {
                string attendancesUrl = ConfigurationManager.AppSettings["AttendancesUrl"];
                string requestUrl = $"{attendancesUrl.Trim('/')}/EmpForAtt";
                var response = await Globle.httpClient.GetAsync(requestUrl);
                var employees = await response.Content.ReadFromJsonAsync<List<EmployeeForAttendanceDTO>>();
                if (employees != null)
                {
                    foreach (var employee in employees)
                    {
                        employeesForAttendance.Add(employee.Name, employee.EmployeeID);
                    }

                    await FillComboBoxEmployeesForAttendance(employeesForAttendance);
                }
            }
            catch (Exception ex)
            {
                Msg.ShowDialog("Error" + ex.Message, Shared.enTypeIcon.Error);
            }
        }

        private async Task FillComboBoxEmployeesForAttendance(Dictionary<string, int> employees)
        {
            foreach (var employee in employees)
            {
                cbAttendanceForAttendance.Items.Add(employee.Key);
            }

            if (cbAttendanceForAttendance.Items.Count > 0)
                cbAttendanceForAttendance.SelectedIndex = 0;
        }

        private async Task LoadAttendanceStatistics()
        {
            try
            {
                string attendancesUrl = ConfigurationManager.AppSettings["AttendancesUrl"];

                string requestUrl = $"{attendancesUrl.Trim('/')}/Statistics";

                var response = await Globle.httpClient.GetAsync(requestUrl);

                var statistics = await response.Content.ReadFromJsonAsync<TodayAttendanceStatisticsDTO>();

                if (statistics != null)
                {
                    ctrlTodayAttendanceStatistices1.SetAttendanceStatistics("Total Employees", statistics.TotalEmployees, Properties.Resources.current_user);
                    ctrlTodayAttendanceStatistices2.SetAttendanceStatistics("Present Today", statistics.PresentToday, Properties.Resources.current_user);
                    ctrlTodayAttendanceStatistices3.SetAttendanceStatistics("Absent Today", statistics.AbsentToday, Properties.Resources.current_user);
                }
            }
            catch (Exception ex)
            {
                Msg.ShowDialog("Error" + ex.Message, Shared.enTypeIcon.Error);
            }
        }

        private async Task LoadTodayAttendanceRecords(TodayAttendanceRecordPagination pagination)
        {
            try
            {
                string attendancesUrl = ConfigurationManager.AppSettings["AttendancesUrl"];
                string requestUrl = $"{attendancesUrl.Trim('/')}/Pagination?pageNumber={pagination.PageNumber}&pagePerNumber={pagination.PagePerNumber}";

                var response = await Globle.httpClient.GetAsync(requestUrl);
                var attendanceRecords = await response.Content.ReadFromJsonAsync<List<TodayAttendanceRecords>>();

                if (attendanceRecords != null)
                {
                    ShowTodayAttendanceRecords(attendanceRecords);
                    ShowTotalAttendanceRecords(attendanceRecords.Count);
                }
            }
            catch (Exception ex)
            {
                Msg.ShowDialog("Error" + ex.Message, Shared.enTypeIcon.Error);
            }

            ColeringOfAbsentOrPersent(dgvEmployees, "Status", "Present", Color.LightGreen, Color.LightCoral);

        }

        private void ShowTodayAttendanceRecords(List<TodayAttendanceRecords> attendanceRecords)
        {
            if (attendanceRecords == null || attendanceRecords.Count == 0)
            {
                Msg.ShowDialog("No attendance records found.", Shared.enTypeIcon.Information);
                return;
            }
            dgvEmployees.DataSource = attendanceRecords;
        }

        private void ShowTotalAttendanceRecords(int count)
        {
            if (count == 0)
            {
                lblCount.Text = "Total Records: 0";
                return;
            }
            lblCount.Text = $"Total Records: {count}";
        }

        private void btnMakAttendance_Click(object sender, EventArgs e)
        {
            MarkAttendance(
                GetEmployeeID(),
                GetSelectedAttendanceType());
        }

        private int GetEmployeeID()
        {
            if (cbAttendanceForAttendance.SelectedItem != null)
            {
                string selectedEmployeeName = cbAttendanceForAttendance.SelectedItem.ToString();
                return employeesForAttendance.ContainsKey(selectedEmployeeName) ? employeesForAttendance[selectedEmployeeName] : -1;
            }
            return -1; // Return -1 or handle the case when no employee is selected
        }

        private string GetSelectedAttendanceType()
        {
            if (rbCheckIn.Checked)
                return "CheckIn";
            else if (rbCheckOut.Checked)
                return "CheckOut";
            else
                return string.Empty; // Return empty or handle the case when no attendance type is selected
        }

        private async void MarkAttendance(int employeeId, string attendanceType)
        {
            if (employeeId == -1 || string.IsNullOrEmpty(attendanceType))
            {
                Msg.ShowDialog("Please select an employee and attendance type.", Shared.enTypeIcon.Warring);
                return;
            }
            try
            {
                string attendancesUrl = ConfigurationManager.AppSettings["AttendancesUrl"];

                string requestUrl = string.Empty;
                if(attendanceType == "CheckIn")
                {
                    requestUrl = $"{attendancesUrl.TrimEnd('/')}/CheckIn?employeeId={employeeId}";

                }
                else if (attendanceType == "CheckOut")
                {
                    requestUrl = $"{attendancesUrl.TrimEnd('/')}/CheckOut?employeeId={employeeId}";
                }
                else
                {
                    Msg.ShowDialog("Invalid attendance type.", Shared.enTypeIcon.Error);
                    return;
                }

                var response = await Globle.httpClient.PostAsync(requestUrl, null);
                if (response.IsSuccessStatusCode)
                {
                    Msg.ShowDialog("Attendance marked successfully.", Shared.enTypeIcon.Success);
                    await LoadTodayAttendanceRecords(new TodayAttendanceRecordPagination { PageNumber = 1, PagePerNumber = 10 });
                    await LoadAttendanceStatistics();
                }
                else
                {
                    Msg.ShowDialog("Error occurred while marking attendance.", Shared.enTypeIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Msg.ShowDialog("Exception: " + ex.Message, Shared.enTypeIcon.Error);
            }
        }
    }
}
