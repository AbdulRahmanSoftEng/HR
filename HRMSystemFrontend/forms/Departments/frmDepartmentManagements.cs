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
using HRMSystemFrontend.forms.Commons;
using HRMSystemFrontend.Settings;
using System.Net.Http.Json;
using HRMSystemFrontend.DTOs;
namespace HRMSystemFrontend.forms.Departments
{
    public partial class frmDepartmentManagements : Commons.frmHeader
    {
        public frmDepartmentManagements(string title, string description)
            : base(title, description)
        {
            InitializeComponent();
        }

        private async void Refrash(object sender, EventArgs e)
        {
            await GetAllDepartments();
        }
        private async void frmDepartmentManagements_Load(object sender, EventArgs e)
        {
            await GetAllDepartments();
        }

        private async Task GetAllDepartments()
        {
            try
            {
                string baseUrl = ConfigurationManager.AppSettings["Url"];
                string departmentsUrl = ConfigurationManager.AppSettings["DepartmentsUrl"];
                string requestUrl = $"{departmentsUrl.Trim('/')}/All";

                var response = await Globle.httpClient.GetAsync(requestUrl);
                if (response.IsSuccessStatusCode)
                {
                    var departments = await response.Content.ReadFromJsonAsync<List<DepartmentDTO>>();
                    ShowAllDepartments(departments);
                    ShowCount(departments.Count);
                }
                else
                {
                    Msg.Show("Error Occurred while fetching departments.");
                }
            }
            catch (Exception ex)
            {
                Msg.Show("Exception " + ex.Message);
            }
        }

        private void ShowAllDepartments(List<DepartmentDTO> departments)
        {
            if (departments == null || departments.Count == 0)
            {
                Msg.Show("No departments found.", Shared.enTypeIcon.Information);
                return;
            }
            dgvDepartements.DataSource = departments;
        }

        private void ShowCount(int count)
        {
            lblCount.Text = $"Total Departments: {count}";
        }

        private void btnAddNewDepartment_Click(object sender, EventArgs e)
        {
            frmAddEditDep frmAddEditDep = new frmAddEditDep();
            frmAddEditDep.Dep_Saved += Refrash;
            frmAddEditDep.ShowDialog();
        }
    }
}
