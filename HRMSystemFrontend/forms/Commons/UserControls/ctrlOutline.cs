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
    public partial class ctrlOutline : UserControl
    {
        public ctrlOutline()
        {
            InitializeComponent();
        }

        public void SetOutline(int r, int g, int b)
        {
            panel1.BackColor = Color.FromArgb(r, g, b);
            panel2.BackColor = Color.FromArgb(r, g, b);
            panel3.BackColor = Color.FromArgb(r, g, b);
            panel4.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
