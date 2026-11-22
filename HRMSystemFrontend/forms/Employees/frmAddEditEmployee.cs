using HRMSystemFrontend.DTOs;
using HRMSystemFrontend.Settings;
using HRMSystemFrontend.Shared;
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
using HRMSystemFrontend.forms.Commons;

namespace HRMSystemFrontend.forms.Employees
{
    public partial class frmAddEditEmployee : Form
    {
        private int UserID = -1;

        private List<DepartmentDTO> departments;
        public delegate void EmployeeSavedEventHandler(object sender, EventArgs e);
        public event EmployeeSavedEventHandler EmployeeSaved;

        public frmAddEditEmployee()
        {
            InitializeComponent();
        }

        public frmAddEditEmployee(int userID)
        {
            InitializeComponent();
            UserID = userID;
        }

        public void SetUserData(FullUserDTO user)
        {
            txtUsername.Text = user.Username;

        }

        public EmployeeDTO Employee
        {
            
            get
            {
                return new EmployeeDTO
                {   
                    FullName = txtFullName.Text,
                    EmployeeCode = txtEmpCode.Text,
                    Phone = txtPhone.Text,
                    JobTitle = txtJobTitle.Text,
                    DepartmentID = Convert.ToInt32(departments.FirstOrDefault(ob => ob.DepartmentName == cbDepartment.Text).DepartmentID),
                };
            }
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (UserID == -1)
            {
                bool isSaved = await AddNewEmployee(Employee);
                

                if(isSaved)
                    EmployeeSaved?.Invoke(Employee, EventArgs.Empty);
            }
        }

        private void FillComboBoxDepartments(List<DepartmentDTO> departments)
        {
            this.departments = departments;
            foreach (var department in departments)
            {
                cbDepartment.Items.Add(department.DepartmentName);
            }
        }

        private async Task GetAllDepartments()
        {
            try
            {
                string departmentsUrl = ConfigurationManager.AppSettings["DepartmentsUrl"];

                string requestUrl = $"{departmentsUrl.Trim('/')}/All";

                var response = await Globle.httpClient.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    departments = await response.Content
                        .ReadFromJsonAsync<List<DepartmentDTO>>();

                    if (departments == null || departments.Count == 0)
                    {
                        Msg.Show("No departments found.");
                        return;
                    }

                    FillComboBoxDepartments(departments);
                }
                else
                {
                    Msg.Show($"Failed to get departments. Status: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Msg.Show("Exception: " + ex.Message);
            }
        }

        public async Task<bool> AddNewEmployee(EmployeeDTO newEmployee)
        {
            try
            {
                string employeesUrl = ConfigurationManager.AppSettings["EmployeesUrl"];

                string requestUrl = $"{employeesUrl.Trim('/')}/AddNew";

                var response = await Globle.httpClient.PostAsJsonAsync(requestUrl, newEmployee);

                if (response.IsSuccessStatusCode)
                {
                    var employee = response.Content.ReadFromJsonAsync<EmployeeDTO>();

                    if (employee != null)
                    {
                        Msg.Show("Added new employee successfully!");

                        return true;
                    }


                }
                
                   
                Msg.Show("Exception " + response.Content);
                    
                return false;
                
            }
            catch (Exception ex)
            {
                Msg.Show("Exception " + ex.Message);
                return false;
            }
        }

        private async void frmAddEditEmployee_Load(object sender, EventArgs e)
        {
            await GetAllDepartments();
        }


    }
}
