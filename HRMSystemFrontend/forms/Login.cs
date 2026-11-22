using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
using HRMSystemFrontend.Shared;
namespace HRMSystemFrontend.forms
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                Msg.Show("Please enter both username and password.", enTypeIcon.Warring, 3);
                return;
            }

            LoginByUsernameAndPassword(txtUsername.Text, txtPassword.Text);           
        }

        private async Task LoginByUsernameAndPassword(string username, string password)
        {
            // Implement your logic to check the username and password
            // For example, you can call an API or check against a database
            // Return true if valid, false otherwise
            try
            {
                string usersUrl = ConfigurationManager.AppSettings["UsersUrl"];

                string requestUrl = $"{usersUrl.Trim('/')}/Login/{username}/{password}";

                var response = await Globle.httpClient.GetAsync(requestUrl);

                if(response.IsSuccessStatusCode)
                {
                    var user = await response.Content.ReadFromJsonAsync<FullUserDTO>();
                    if(user == null)
                    {
                        Msg.ShowDialog("Invalid username or password.", enTypeIcon.Error);
                        return;
                    }
                    SetCurrentUser(user); // Store the logged-in user information
                    // Login successful
                    Msg.ShowDialog("Login successful!");
                    this.Hide();
                    Main mainForm = new Main();
                    mainForm.ShowDialog();
                    this.Close();
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    // Invalid credentials
                    Msg.ShowDialog("Invalid username or password.", enTypeIcon.Error);
                }
                else
                {
                    // Other error
                    Msg.ShowDialog("An error occurred while trying to log in.", enTypeIcon.Error);
                }
            }
            catch(Exception ex)
            {
                //Msg.Show(ex.Message);
            }
        }

        private void SetCurrentUser(FullUserDTO user)
        {
            // Store the logged-in user information in a global variable or a singleton class
            Shared.clsCurrentLogin.currentUser = new FullUserDTO
            {
                UserID = user.UserID,
                EmployeeID = user.EmployeeID,
                EmployeeCode = user.EmployeeCode,
                FullName = user.FullName,
                Username = user.Username,
                RoleID = user.RoleID,
                RoleName = user.RoleName,
                IsActive = user.IsActive,
                EmployeeIsActive = user.EmployeeIsActive,
                CreatedAt = user.CreatedAt

            };
        }
    }
}
