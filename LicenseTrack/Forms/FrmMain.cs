using LicenseTrack.Classes;
using LicenseTrack.Controls;
using LicenseTrack.Forms;
using LicenseTrack.Interfaces;
using LicenseTrack.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LicenseTrack
{
    public partial class FrmMain : Form
    {
        private readonly IFormTitleBarService _formTitleBarService;
        private readonly IDynamicControlService _dynamicControlService;
        private readonly IInfoCardService _infoCardService;
        private readonly IShowFrmInsidePnlService _showFrmInsidePnlService;
        private readonly Dictionary<enFormChosen.enumFormChosen, Form> _formChosenList;
        private readonly enFormChosen _enumFormChosen;

        public FrmMain(IFormTitleBarService formTitleBarService, IDynamicControlService dynamicControlService, 
            IInfoCardService infoCardService, IShowFrmInsidePnlService showFrmInsidePnlService,
            Dictionary<enFormChosen.enumFormChosen, Form> formChosenList)
        {
            InitializeComponent();

            _formTitleBarService = formTitleBarService;
            _dynamicControlService = dynamicControlService;
            _infoCardService = infoCardService;
            _showFrmInsidePnlService = showFrmInsidePnlService;
            _formChosenList = formChosenList;

            SetFormTitleBarService();
            DynamicControlsService();
            InfoCardService();
        }

        // Form title bar
        private void SetFormTitleBarService()
        {
            btnShutDown.Click += BtnShutDown_Click;
            btnFullScreen.Click += BtnFullScreen_Click;
            btnHide.Click += BtnHide_Click;
        }

        private void BtnHide_Click(object sender, System.EventArgs e)
        {
            _formTitleBarService.MinimizeForm(this);
        }

        private void BtnFullScreen_Click(object sender, System.EventArgs e)
        {
            _formTitleBarService.ToggleForm(this);
        }

        private void BtnShutDown_Click(object sender, System.EventArgs e)
        {
            _formTitleBarService.ExitForm();
        }

        // Dynamic controls
        private void DynamicControlsService()
        {
            tMain.Tick += TMain_Tick;

            btnApplications.Click += SidePnlBtn_Click;
            btnPeople.Click += SidePnlBtn_Click;
            btnDrivers.Click += SidePnlBtn_Click;
            btnUsers.Click += SidePnlBtn_Click;
            btnSettings.Click += SidePnlBtn_Click;

            _dynamicControlService.UpdateUsername(lblUser);
        }

        private void SidePnlBtn_Click(object sender, System.EventArgs e)
        {
            _dynamicControlService.UpdateCurrentWindowName(sender as Button, lblCurrentWindowName);
            _dynamicControlService.UpdateDynamicPnlState(pnlDynamic, sender as Button);
            ShowFrmInsidePnlService(sender as Button);
        }

        private void TMain_Tick(object sender, System.EventArgs e)
        {
            _dynamicControlService.UpdateDateAndTime(lblDateAndTime);
        }

        // Info cards
        private void _ShowInfoCards()
        {
            lnkLblEngenMe.Click += LnkLblEngenMe_Click;
            btnInfo.Click += BtnInfo_Click;
        }

        private void BtnInfo_Click(object sender, System.EventArgs e)
        {
            _infoCardService.ShowSystemInfoCard();
        }

        private void LnkLblEngenMe_Click(object sender, System.EventArgs e)
        {
            _infoCardService.ShowDeveloperInfoCard();
        }

        private void _SetLnkLblsService()
        {
            _infoCardService.SetLnkLblsCardServices();
        }

        private void _SetSystemVersion()
        {
            _infoCardService.SetSystemVersion();
        }

        private void InfoCardService()
        {
            _ShowInfoCards();
            _SetLnkLblsService();
            _SetSystemVersion();
        }

        // Show Frm inside panel
        private void ShowFrmInsidePnlService(Button button)
        {
            _showFrmInsidePnlService.ShowFrmInsidePnl(_formChosenList[(enFormChosen.enumFormChosen
                )button.Tag.ToString().ToInt()], pnlMain); // trigger is in SidePnlBtn_Click
        }
    }
}
