using HRMSystemFrontend.DTOs;
using HRMSystemFrontend.forms.Commons;
using HRMSystemFrontend.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace HRMSystemFrontend.forms.Users.UserControls
{
    public partial class ctrlUserInfo : UserControl
    {
        public ctrlUserInfo()
        {
            InitializeComponent();
        }


        public void Find(int empId)
        {
            LoadUserInfo(empId);
        }

        private async void LoadUserInfo(int empId)
        {
            // Implementation for loading user info

            try
            {
                var employeeUrl = ConfigurationManager.AppSettings["UsersUrl"];
                var requestUrl = $"{employeeUrl.Trim('/')}/ByEmpID/{empId}";

                var response = await Globle.httpClient.GetAsync(requestUrl);
                if (response.IsSuccessStatusCode)
                {
                    var employee = await response.Content.ReadFromJsonAsync<UserWithRoleDTO>();
                    if (employee != null)
                    {
                        ShowInfo(employee);
                    }
                }
                else
                {
                    Msg.ShowDialog("Failed to load user information.", Shared.enTypeIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Msg.ShowDialog("Error: " + ex.Message, Shared.enTypeIcon.Error);
            }
        }

        public void ShowInfo(UserWithRoleDTO employee)
        {
            lblUserID.Text = employee.UserID.ToString();
            lblUsername.Text = employee.Username;
            lblRoleID.Text = employee.RoleID.ToString();
            lblRoleName.Text = employee.RoleName;
            lblUserIsActive.Text = employee.UserIsActive ? "Yes" : "No";
            lblCreatedAt.Text = employee.CreatedAt.ToString("yyyy-MM-dd");

        }

        public int UserID
        {
            get { return int.Parse(lblUserID.Text); }
        }
    }
}