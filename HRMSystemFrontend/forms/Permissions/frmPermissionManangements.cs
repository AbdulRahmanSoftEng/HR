using HRMSystemFrontend.DTOs;
using HRMSystemFrontend.forms.Commons;
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
namespace HRMSystemFrontend.forms.Permissions
{
    public partial class frmPermissionManangements : Commons.frmHeader
    {
        public frmPermissionManangements(string title, string description)
            : base(title, description)
        {
            InitializeComponent();
        }

        private async void Refrash(object sender, EventArgs e)
        {
            await GetAllPermissions();
        }
        private async void frmPermissionManangements_Load(object sender, EventArgs e)
        {
            await GetAllPermissions();
        }

        private async Task GetAllPermissions()
        {
            try
            {
                string permissionsUrl = ConfigurationManager.AppSettings["PermissionsUrl"];
                string requestUrl = $"{permissionsUrl.Trim('/')}/All";

                var response = await Globle.httpClient.GetAsync(requestUrl);
                if (response.IsSuccessStatusCode)
                {
                    var permissions = await response.Content.ReadFromJsonAsync<List<PermissionDTO>>();
                    ShowAllPermissions(permissions);
                    ShowCount(permissions.Count);
                }
                else
                {
                    Msg.Show("Error Occurred while fetching permissions.");
                }
            }
            catch (Exception ex)
            {
                Msg.Show("Exception " + ex.Message, Shared.enTypeIcon.Error);
            }
        }

        private void ShowAllPermissions(List<PermissionDTO> permissions)
        {
            if (permissions == null || permissions.Count == 0)
            {
                Msg.Show("No permissions found.", Shared.enTypeIcon.Information);
                return;
            }
            dgvPermissions.DataSource = permissions;
        }

        private void ShowCount(int count)
        {
            lblCount.Text = $"Total Permissions: {count}";
        }
 
    }
}
