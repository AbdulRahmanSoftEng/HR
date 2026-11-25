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
using HRMSystemFrontend.Settings;
using System.Net.Http.Json;
using HRMSystemFrontend.DTOs;
using HRMSystemFrontend.forms.Commons;

namespace HRMSystemFrontend.UserControle
{
    public partial class ctrlEmployeeInfo : UserControl
    {
        public ctrlEmployeeInfo()
        {
            InitializeComponent();
        }

        public async void Find(int employeeID)
        {
            LoadEmployeeInfo(employeeID);
        }

        private async void LoadEmployeeInfo(int employeeID)
        {
            try
            {
                var employeeUrl = ConfigurationManager.AppSettings["EmployeesUrl"];
                var requestUrl = $"{employeeUrl.Trim('/')}/ById/{employeeID}";

                var response = await Globle.httpClient.GetAsync(requestUrl);
                if (response.IsSuccessStatusCode)
                {
                    var employee = await response.Content.ReadFromJsonAsync<EmployeeDTO>();
                    if (employee != null)
                    {
                        ShowInfo(employee);
                    }
                }
                else
                {
                    Msg.ShowDialog("Failed to load employee information.", Shared.enTypeIcon.Error);
                }
            }catch(Exception ex)
            {
                Msg.ShowDialog("Error: " + ex.Message, Shared.enTypeIcon.Error);
            }
        }

        public void ShowInfo(EmployeeDTO employee)
        {
            lblEmpID.Text = employee.EmployeeID.ToString();
            lblEmpFullName.Text = employee.FullName;
            lblEmpCode.Text = employee.EmployeeCode;
            lblEmpJobTitle.Text = employee.JobTitle;
            lblEmpPhone.Text = employee.Phone;
            lblEmpIsActive.Text = employee.IsActive ? "Yes" : "No";
            lblEmpCreatedAt.Text = employee.CreatedAt.ToString("yyyy-MM-dd");

            lblDepName.Text = employee.DepartmentName;
            lblDepID.Text = employee.DepartmentID.ToString();
        }
    }
}
