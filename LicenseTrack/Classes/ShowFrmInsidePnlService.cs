using LicenseTrack.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseTrack.Classes
{
    public class ShowFrmInsidePnlService : IShowFrmInsidePnlService
    {
        private bool _IsPanelContainForm(Form form, Panel panel)
        {
            foreach (Control ctrl in panel.Controls)
            {
                if (ctrl is Form)
                    if (((Form)ctrl) == form)
                        return true;
            }

            return false;
        }

        private void _ShowNewFrmInPnl(Form form, Panel panel)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            form.Parent = panel;
            form.BringToFront();
            form.Show();
        }

        private void _BringExistedFrmInFrontOfPnl(Form form)
        {
            form.Show();
            form.BringToFront();
        }

        public void ShowFrmInsidePnl(Form form, Panel panel)
        {
            if (panel != null)
            {
                if (_IsPanelContainForm(form, panel))
                    _BringExistedFrmInFrontOfPnl(form);
                else
                    _ShowNewFrmInPnl(form, panel);
            }
        }
    }
}
