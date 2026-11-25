using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystemFrontend.forms.Employees
{
    public partial class frmShowEmployeeInfo : Form
    {
        public frmShowEmployeeInfo()
        {
            InitializeComponent();
        }

        public void ShowEmployeeInfo(int id)
        {
            ctrlEmployeeInfo1.Find(id);
        }

        private void frmShowInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
