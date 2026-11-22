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

namespace HRMSystemFrontend.forms.Commons
{
    public partial class frmHeader : Form
    {
        private string _Title;
        private string _Description;

        public frmHeader() : this("", "")
        {
        }

        public frmHeader(string Title, string Description)
        {

            InitializeComponent();

            this._Title = Title;
            this._Description = Description;

        }


        private void _ShowTitle(string title, string description)
        {
            lblTitleForm.Text = title;
            lblDescForm.Text = description;

        }



        private void _ShowDate(string CurrentDate)
        {
            lblDateShared.Text = CurrentDate;
        }

        private void _ShowCurrentUser(string CurrentUser)
        {
            lblCurrentUser.Text = CurrentUser;
        }

        private void _ShowCurrentTime(string CurrentTime)
        {
            lblTimeShared.Text = CurrentTime;
        }



        private void _LaodForm()
        {
            _ShowDate(_GetDateNow());
            _ShowTitle(_Title, _Description);

            if(clsCurrentLogin.currentUser != null)
                _ShowCurrentUser(clsCurrentLogin.currentUser.FullName);
            else
                _ShowCurrentUser("Administrator");
        }

        private string _GetDateNow()
        {
            return (string)DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string CurrentTime = DateTime.Now.ToString("hh:mm:ss tt");
            _ShowCurrentTime(CurrentTime);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void frmHeader_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            
            _LaodForm();
            
            timer1.Start();
        }
    }
}
