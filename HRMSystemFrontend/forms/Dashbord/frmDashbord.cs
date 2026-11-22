using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystemFrontend.forms.Dashbord
{
    public partial class frmDashbord : Commons.frmHeader
    {
        public frmDashbord(string title, string description)
            : base(title, description)
        {
            InitializeComponent();
        }
    }
}
