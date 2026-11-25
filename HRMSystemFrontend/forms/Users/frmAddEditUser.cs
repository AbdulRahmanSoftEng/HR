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
namespace HRMSystemFrontend.forms.Users
{
    public partial class frmAddEditUser : Form
    {
        public enModeCRUD Mode;
        private int UserID;
        private List<EmployeeDTO> employees;
        private List<RoleDTO> roles;
        public delegate void UserSavedEventHandler(object sender, EventArgs e);
        public event UserSavedEventHandler UserSaved;

        public frmAddEditUser(enModeCRUD enModeCRUD = enModeCRUD.Add, int userID = 0)
        {
            InitializeComponent();
            Mode = enModeCRUD;
            UserID = userID;
        }

        public void SetUserData(FullUserDTO user)
        {
            txtUsername.Text = user.Username;

        }

        public UserDTO User
        {
            get
            {
                return new UserDTO
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    EmployeeID = Convert.ToInt32(employees.FirstOrDefault(ob => ob.FullName == cbEmployees.Text).EmployeeID),
                    RoleID = Convert.ToInt32(roles.FirstOrDefault(ob => ob.RoleName == cbRoles.Text).RoleID),
                    IsActive = true
                };
            }
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (Mode == enModeCRUD.Add)
            {
                bool isAdded = await AddNewUser(User);
                if (isAdded)
                {
                    UserSaved?.Invoke(User, EventArgs.Empty);
                }
            }
        }

        private void FillComboBoxRoles(List<RoleDTO> roles)
        {
            this.roles = roles;
            foreach (var role in roles)
            {
                cbRoles.Items.Add(role.RoleName);
            }
        }

        private async Task GetAllRoles()
        {
            try
            {    
                string rolesUrl = ConfigurationManager.AppSettings["RolesUrl"];

                string requestUrl = $"{rolesUrl.Trim('/')}/All";

                var response = await Globle.httpClient.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    roles = await response.Content
                        .ReadFromJsonAsync<List<RoleDTO>>();

                    if (roles == null || roles.Count == 0)
                    {
                        Msg.Show("No roles found.");
                        return;
                    }

                    FillComboBoxRoles(roles);
                }
                else
                {
                    Msg.Show($"Failed to get roles. Status: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Msg.Show("Exception: " + ex.Message);
            }
        }

        private void FillComboBoxEmployees(List<EmployeeDTO> employees)
        {
            this.employees = employees;
            foreach (var employee in employees)
            {
                cbEmployees.Items.Add(employee.FullName);
            }
        }

        private async Task GetAllEmployees()
        {
            try
            {
                string employeesUrl = ConfigurationManager.AppSettings["EmployeesUrl"];

                string requestUrl = $"{employeesUrl.Trim('/')}/All";

                var response = await Globle.httpClient.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    employees = await response.Content
                        .ReadFromJsonAsync<List<EmployeeDTO>>();

                    if (employees == null || employees.Count == 0)
                    {
                        Msg.Show("No employees found.");
                        return;
                    }

                    FillComboBoxEmployees(employees);
                }
                else
                {
                    Msg.Show($"Failed to get employees. Status: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Msg.Show("Exception: " + ex.Message);
            }
        }

        public async Task<bool> AddNewUser(UserDTO user)
        {
            try
            {
                string usersUrl = ConfigurationManager.AppSettings["UsersUrl"];

                string requestUrl = $"{usersUrl.Trim('/')}/AddNew";
                
                var response = await Globle.httpClient.PostAsJsonAsync(requestUrl, user);

                if (response.IsSuccessStatusCode)
                {
                    var addedUser = await response.Content.ReadFromJsonAsync<UserDTO>();

                    if (addedUser != null)
                    {
                        Msg.Show("Added new user successfully!");
                        return true;
                    }
                }

                Msg.Show("Error Occurred", Shared.enTypeIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                Msg.Show("Exception " + ex.Message, Shared.enTypeIcon.Error);
                return false;
            }
        }

        private async void frmAddEditUser_Load(object sender, EventArgs e)
        {
            await GetAllEmployees();
            await GetAllRoles();
        }


    }
}
