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

namespace HRMSystemFrontend.forms.Departments
{
    public partial class frmAddEditDep : Form
    {
        private int DepID = -1;

        public delegate void DepartementSavedEventHandler(object sender, EventArgs e);
        public event DepartementSavedEventHandler Dep_Saved;

        public frmAddEditDep()
        {
            InitializeComponent();
        }

        public frmAddEditDep(int depId)
        {
            InitializeComponent();
            DepID = depId;
        }

        

        public DepartmentDTO Dep
        {
            
            get
            {
                return new DepartmentDTO
                {
                    DepartmentName = txtDepartmentName.Text,
                    Description = txtDesc.Text,
                    IsActive = GetStatus()
                };
            }
        }

        private bool GetStatus()
        {
            if (rbActive.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (DepID == -1)
            {
                bool isSaved = await AddNewDep(Dep);
                

                if(isSaved)
                    Dep_Saved?.Invoke(Dep, EventArgs.Empty);
            }
        }

        public async Task<bool> AddNewDep(DepartmentDTO departmentDTO)
        {
            try
            {
                string departmentUrl = ConfigurationManager.AppSettings["DepartmentsUrl"];

                string requestUrl = $"{departmentUrl.Trim('/')}/AddNew";

                var response = await Globle.httpClient.PostAsJsonAsync(requestUrl, Dep);

                if (response.IsSuccessStatusCode)
                {
                    var departmentSaved = response.Content.ReadFromJsonAsync<EmployeeDTO>();

                    if (departmentSaved != null)
                    {
                        Msg.Show("Added new department successfully!");

                        return true;
                    }


                }
                
                   
                Msg.Show("Exception " + response.Content, enTypeIcon.Error);
                    
                return false;
                
            }
            catch (Exception ex)
            {
                Msg.Show("Exception " + ex.Message, enTypeIcon.Error);
                return false;
            }
        }

        private async void frmAddEditDep_Load(object sender, EventArgs e)
        {

         }


    }
}
