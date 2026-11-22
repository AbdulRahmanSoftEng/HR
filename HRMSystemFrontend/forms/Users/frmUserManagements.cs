using HRMSystemFrontend.DTOs;
using HRMSystemFrontend.Settings;
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
using HRMSystemFrontend.Shared;

namespace HRMSystemFrontend.forms.Users
{
    public partial class frmUserManagements : Commons.frmHeader
    {
        public enModeCRUD Mode;
        private string Url = string.Empty;
        public frmUserManagements(string title, string description) :
            base(title, description)
        {
            InitializeComponent();
        }

        private async void frmUserManagements_Load(object sender, EventArgs e)
        {
            await GetAllUsers();
        }

        private async Task GetAllUsers()
        {
            try
            {
                string usersUrl = ConfigurationManager.AppSettings["UsersUrl"];

                string requestUrl = $"{usersUrl.Trim('/')}/All";

                var response = await Globle.httpClient.GetAsync(requestUrl);
                if (response.IsSuccessStatusCode)
                {
                    var users = await response.Content.ReadFromJsonAsync<List<FullUserDTO>>();
                    ShowAllUsers(users);
                    ShowCount(users.Count);
                }
                else
                {
                    Msg.Show("Failed to retrieve users.", Shared.enTypeIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Msg.Show($"An error occurred: {ex.Message}", Shared.enTypeIcon.Error);
            }
        }



        private void ShowAllUsers(List<FullUserDTO> users)
        {
            if (users == null || users.Count == 0)
            {
                Msg.Show("No users found.", Shared.enTypeIcon.Information);
                return;
            }
            dgvUsers.DataSource = users;
        }

        private void ShowCount(int count)
        {
            lblCount.Text = $"Total Users: {count}";
        }

        private void AddUser()
        {
            frmAddEditUser user = new frmAddEditUser();
            user.UserSaved += User_Saved;
            user.ShowDialog();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        public async void User_Saved(object s, EventArgs e)
        {
            await GetAllUsers();
        }

        private void updateInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser user = new frmAddEditUser(enModeCRUD.Update);
            user.UserSaved += User_Saved;
            user.ShowDialog();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser();
        }
    }
}
