using BusinessLayer.Interfaces;
using LicenseTrack.Forms;
using LicenseTrack.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseTrack.Classes
{
    public class InfoCardService : IInfoCardService
    {
        private readonly FrmDeveloperInfo _frmDeveloperInfo;
        private readonly FrmSystemInfo _frmSystemInfo;
        private readonly string _developerGithubURL;
        private readonly string _developerLinkedInURL;
        private readonly string _developerEmail;
        private readonly string _developerPhone;
        private readonly Dictionary<LinkLabel, ILinkLabelHandler> _linkLabelHandlers;
        private readonly string _systemVersion;

        public InfoCardService(FrmDeveloperInfo frmDeveloperInfo, FrmSystemInfo frmSystemInfo,
            string developerGithubURL, string developerLinkedInURL, string developerEmail,
            string developerPhone, Dictionary<LinkLabel, ILinkLabelHandler> linkLabelHandlers, 
            string systemVersion)
        {
            _frmDeveloperInfo = frmDeveloperInfo;
            _frmSystemInfo = frmSystemInfo;
            _developerGithubURL = developerGithubURL;
            _developerLinkedInURL = developerLinkedInURL;
            _developerEmail = developerEmail;
            _developerPhone = developerPhone;
            _linkLabelHandlers = linkLabelHandlers;
            _systemVersion = systemVersion;
        }

        // Show cards
        public void ShowDeveloperInfoCard()
        {
            _frmDeveloperInfo.ShowDialog();
        }

        public void ShowSystemInfoCard()
        {
            _frmSystemInfo.ShowDialog();
        }

        // Lnk Lbl service
        public void SetLnkLblsCardServices()
        {
            _frmDeveloperInfo.ctrlDeveloperInfoCard.lnkLblEmail.Click += LnkLblEmail_Click;
            _frmDeveloperInfo.ctrlDeveloperInfoCard.lnkLblPhone.Click += LnkLblPhone_Click;
            _frmDeveloperInfo.ctrlDeveloperInfoCard.lnkLblLinkedIn.Click += LnkLblLinkedIn_Click;
            _frmDeveloperInfo.ctrlDeveloperInfoCard.lnkLblGithub.Click += LnkLblGithub_Click;

            _frmSystemInfo.ctrlSystemInfoCard.lnkLblLinkedIn.Click += LnkLblLinkedIn_Click;
            _frmSystemInfo.ctrlSystemInfoCard.lnkLblGithub.Click += LnkLblGithub_Click;
        }

        private void LnkLblGithub_Click(object sender, EventArgs e)
        {
            LinkLabel linkLabel = sender as LinkLabel;

            if (linkLabel != null && _linkLabelHandlers.TryGetValue(linkLabel, out var handler))
            {
                handler.Handle();
            }
        }

        private void LnkLblLinkedIn_Click(object sender, EventArgs e)
        {
            LinkLabel linkLabel = sender as LinkLabel;

            if (linkLabel != null && _linkLabelHandlers.TryGetValue(linkLabel, out var handler))
            {
                handler.Handle();
            }
        }

        private void LnkLblPhone_Click(object sender, EventArgs e)
        {
            Process.Start($"tel:{_developerPhone}");
        }

        private void LnkLblEmail_Click(object sender, EventArgs e)
        {
            Process.Start($"mailto:{_developerEmail}");
        }

        // System version
        public void SetSystemVersion()
        {
            _frmSystemInfo.ctrlSystemInfoCard.lblVersion.Text = _systemVersion;
        }
    }
}
