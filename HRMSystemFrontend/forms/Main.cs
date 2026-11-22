using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HRMSystemFrontend.forms.Commons;
using HRMSystemFrontend.forms;
using HRMSystemFrontend.forms.Users;
using HRMSystemFrontend.forms.Attendances;
using HRMSystemFrontend.forms.Dashbord;
using HRMSystemFrontend.forms.Employees;
using HRMSystemFrontend.forms.Roles;
using HRMSystemFrontend.forms.Permissions;
using HRMSystemFrontend.forms.Departments;

namespace HRMSystemFrontend.forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void _CloseAllChildeForm()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void _ShowFormIntro(string Title, string Description)
        {
            _CloseAllChildeForm();

            frmIntro frm = new frmIntro(Title, Description);
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _ShowFormIntro("Welcome Back", "Welcome to the HR Management System");
        }

        // <summary>
        // Handles the click event for the user management menu item.
        // </summary>
        // <param name="sender">The source of the event.</param>
        // <param name="e">The event data.</param>

        // User Management
        private void userManagementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CloseAllChildeForm();

            frmUserManagements frm = new frmUserManagements("Manage Users", "manage users Add, update, search, delete");
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        // Attendance Management
        private void attendancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CloseAllChildeForm();

            frmAttendanceManagements frm = new frmAttendanceManagements("Manage Attendance", "manage attendance Add, update, search, delete");
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void manageDashbordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CloseAllChildeForm();

            frmDashbord frm = new frmDashbord("Manage Dashboard", "manage dashboard and analytics");
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void manageEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CloseAllChildeForm();

            frmEmployeeManagements frm = new frmEmployeeManagements("Manage Employees", "manage employees Add, update, search, delete");
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void manageDepartmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CloseAllChildeForm();

            frmDepartmentManagements frm = new frmDepartmentManagements("Manage Departments", "manage departments Add, update, search, delete");
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void manageRolesAndPermissionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CloseAllChildeForm();

            frmRoleManagements frm = new frmRoleManagements("Manage Roles and Permissions", "manage roles Add, update, search, delete");
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void managePermissionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CloseAllChildeForm();

            frmPermissionManangements frm = new frmPermissionManangements("Manage Permissions", "manage permissions Add, update, search, delete");
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
