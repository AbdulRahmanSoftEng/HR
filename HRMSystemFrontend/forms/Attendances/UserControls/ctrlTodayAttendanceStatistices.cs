using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystemFrontend.forms.Attendances.UserControls
{
    public partial class ctrlTodayAttendanceStatistices : UserControl
    {
        public ctrlTodayAttendanceStatistices()
        {
            InitializeComponent();
        }

        public void SetAttendanceStatistics(string title, int number, Image image)
        {
            lblTitle.Text = title.ToString();
            lblNumber.Text = number.ToString();
            pbIcon.Image = image;
        }
    }
}
