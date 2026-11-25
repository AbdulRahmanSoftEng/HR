using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystemFrontend.UserControle
{
    public partial class ctrlDashbordStatistics : ctrlOutline
    {
        public ctrlDashbordStatistics()
        {
            InitializeComponent();
        }

        public void SetStatistics(int Total, string Desc, Image image, int r, int g, int b)
        {
            lblNumber.Text = Total.ToString();
            lblDesc.Text = Desc;
            pictureBox1.Image = image;
            SetOutline(r, g, b);
        }
    }
}
