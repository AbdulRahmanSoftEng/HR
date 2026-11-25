using HRMSystemFrontend.DTOs;
using HRMSystemFrontend.forms.Commons;
using HRMSystemFrontend.forms.Employees;
using HRMSystemFrontend.forms.Users;
using HRMSystemFrontend.Settings;
using HRMSystemFrontend.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystemFrontend.forms.Employees
{
    public partial class frmEmployeeManagements : Commons.frmHeader
    {
        public frmEmployeeManagements(string title, string description)
            : base(title, description)
        {
            InitializeComponent();
        }

        private void updateInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ShowAllEmployees(List<EmployeeDTO> employees)
        {
            if (employees == null || employees.Count == 0)
            {
                Msg.Show("No employees found.", Shared.enTypeIcon.Information);
                return;
            }
            dgvEmployees.DataSource = employees;
        }

        private void ShowCount(int count)
        {
            lblCount.Text = $"Total Employees: {count}";
        }

        private async Task GetAllEmployees()
        {
            try
            {
                string baseUrl = ConfigurationManager.AppSettings["Url"];
                string employeesUrl = ConfigurationManager.AppSettings["EmployeesUrl"];

                string requestUrl = $"{baseUrl.TrimEnd('/')}/{employeesUrl.Trim('/')}/All";

                var response = await Globle.httpClient.GetAsync(requestUrl);
                if (response.IsSuccessStatusCode)
                {
                    var employees = await response.Content.ReadFromJsonAsync<List<EmployeeDTO>>();
                    ShowAllEmployees(employees);
                    ShowCount(employees.Count);
                }
                else
                {
                    Msg.Show("Failed to retrieve employees.", Shared.enTypeIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Msg.Show($"An error occurred: {ex.Message}", Shared.enTypeIcon.Error);
            }
        }

        private async void Employee_Saved(object sender, EventArgs e)
        {
            // Refresh the employee list after a new employee is added
            await GetAllEmployees();
        }
        private void AddEmployee()
        {
            frmAddEditEmployee employee = new frmAddEditEmployee();
            employee.EmployeeSaved += Employee_Saved;
            employee.ShowDialog();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddEmployee();
        }

        private async void frmEmployeeManagements_Load(object sender, EventArgs e)
        {
            await GetAllEmployees();
        }

        private async void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedCells.Count > 0)
            {
                int employeeId = (int)dgvEmployees.CurrentRow.Cells[0].Value;
                frmShowEmployeeInfo showInfoForm = new frmShowEmployeeInfo();
                showInfoForm.ShowEmployeeInfo(employeeId);
                showInfoForm.ShowDialog();

            }
            else
            {
                Msg.ShowDialog("قم بتحديد الموظف المراد تعديل بياناته", enTypeIcon.Information);
            }
        }

    }
}
