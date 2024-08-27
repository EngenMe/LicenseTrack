using LicenseTrack.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseTrack.Classes
{
    public class DynamicControlService : IDynamicControlService
    {
        private readonly string _dateTimeFormat;
        private readonly string _username;

        public DynamicControlService(string dateTimeFormat, string username)
        {
            _dateTimeFormat = dateTimeFormat;
            _username = username;
        }

        public void UpdateCurrentWindowName(Button btnClicked, Label lblWindowName)
        {
            if (btnClicked != null)
            {
                lblWindowName.Text = btnClicked.Text;
            }
        }

        public void UpdateDateAndTime(Label lblDateTime)
        {
            if (lblDateTime != null)
            {
                lblDateTime.Text = DateTime.Now.ToString(_dateTimeFormat);
            }
        }

        public void UpdateUsername(Label lblUsername)
        {
            if (lblUsername != null)
            {
                lblUsername.Text = _username;
            }
        }

        public void UpdateDynamicPnlState(Panel dynamicPnl, Button btnClicked)
        {
            if (dynamicPnl != null && btnClicked != null)
            {
                dynamicPnl.Show();
                dynamicPnl.Height = btnClicked.Height;
                dynamicPnl.Top = btnClicked.Top;
            }
        }
    }
}
