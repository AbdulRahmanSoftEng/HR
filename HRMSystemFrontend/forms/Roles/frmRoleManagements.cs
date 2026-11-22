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
namespace HRMSystemFrontend.forms.Roles
{
    public partial class frmRoleManagements : Commons.frmHeader
    {
        public frmRoleManagements(string title, string description)
            : base(title, description)
        {
            InitializeComponent();
        }

        private async void Refrash(object sender, EventArgs e)
        {
            await GetAllRoles();
        }
        private async void frmRoleManagements_Load(object sender, EventArgs e)
        {
            await GetAllRoles();
        }

        private async Task GetAllRoles()
        {
            try
            {
                string baseUrl = ConfigurationManager.AppSettings["Url"];
                string rolesUrl = ConfigurationManager.AppSettings["RolesUrl"];
                string requestUrl = $"{rolesUrl.Trim('/')}/All";

                var response = await Globle.httpClient.GetAsync(requestUrl);
                if (response.IsSuccessStatusCode)
                {
                    var roles = await response.Content.ReadFromJsonAsync<List<RoleDTO>>();
                    ShowAllRoles(roles);
                    ShowCount(roles.Count);
                }
                else
                {
                    Msg.Show("Error Occurred while fetching roles.");
                }
            }
            catch (Exception ex)
            {
                Msg.Show("Exception " + ex.Message, Shared.enTypeIcon.Error);
            }
        }

        private void ShowAllRoles(List<RoleDTO> roles)
        {
            if (roles == null || roles.Count == 0)
            {
                Msg.Show("No roles found.", Shared.enTypeIcon.Information);
                return;
            }
            dgvRoles.DataSource = roles;
        }

        private void ShowCount(int count)
        {
            lblCount.Text = $"Total Roles: {count}";
        }
    }
}
