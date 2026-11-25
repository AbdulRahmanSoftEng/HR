using HRMSystemFrontend.forms.Permissions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystemFrontend.forms.Users
{
    public partial class frmShowUserInfo : Form
    {
        public frmShowUserInfo()
        {
            InitializeComponent();
        }

        public void ShowUserInfo(int empId)
        {
            ctrlEmployeeInfo1.Find(empId);
            ctrlUserInfo1.Find(empId);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int userId = ctrlUserInfo1.UserID;

            if(userId > 0)
            {
                frmShowPermissions frm = new frmShowPermissions(userId);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("User ID is not available.");
            }
        }
    }


}
