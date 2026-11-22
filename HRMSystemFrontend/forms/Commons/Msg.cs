using HRMSystemFrontend.Properties;
using HRMSystemFrontend.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystemFrontend.forms.Commons
{
    public partial class Msg :frmSharedOutLine
    {

        public enTypeIcon TypeIcon { get; set; }

    public string MessageTitle { get; set; }
    public byte TimeShowMessage { get; set; }


    public Msg(string MessageTitle, enTypeIcon TypeIcon, byte TimeShowMessage)
    {

        InitializeComponent();

        this.MessageTitle = MessageTitle;
        this.TypeIcon = TypeIcon;
        this.TimeShowMessage = TimeShowMessage;
    }

    short Counter = 2;
    private void timer1_Tick(object sender, EventArgs e)
    {
        if (Counter == TimeShowMessage)
        {
            Counter = 0;
            timer1.Stop();
            this.Close();
        }
        Counter++;
    }

    public void ShowMessage(string Title, enTypeIcon Icon)
    {
        lblMessageTitle.Text = Title;

        switch (Icon)
        {
            case enTypeIcon.Success:
                pbMessageIcon.Image = Resources.successfully;
                break;

            case enTypeIcon.Information:
                pbMessageIcon.Image = Resources.information;
                break;

            case enTypeIcon.Warring:
                pbMessageIcon.Image = Resources.warring;
                break;

            case enTypeIcon.Error:
                pbMessageIcon.Image = Resources.close;
                break;
        }
    }

    public void _Loadding()
    {
        timer1.Start();
        ShowMessage(MessageTitle, TypeIcon);
    }

    private void Msg_Load(object sender, EventArgs e)
    {
        _Loadding();
    }

    public static void Show(string Msg, enTypeIcon Type = enTypeIcon.Success, byte DurationTime = 3)
    {
        new Msg(Msg, Type, DurationTime).Show();
    }

    public static void ShowDialog(string Msg, enTypeIcon Type = enTypeIcon.Success, byte DurationTime = 3)
    {
        new Msg(Msg, Type, DurationTime).ShowDialog();
    }

    private void pbClose_Click(object sender, EventArgs e)
    {
        timer1.Stop();
        this.Close();
    }
}
}
