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
namespace HRMSystemFrontend.forms.Attendances
{
    public partial class frmAttendanceManagements : frmHeader
    {
        public frmAttendanceManagements(string title, string desc)
            : base(title, desc)
        {
            InitializeComponent();
        }
    }
}
