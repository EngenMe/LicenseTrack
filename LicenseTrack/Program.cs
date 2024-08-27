using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLayer.Classes;
using BusinessLayer.Interfaces;
using LicenseTrack.Classes;
using LicenseTrack.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace LicenseTrack
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var serviceProvider = ConfigureServices();

            InitializeAppSettings(serviceProvider);

            Application.Run(serviceProvider.GetRequiredService<FrmMain>());
        }

        private static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.RegisterCommonServices();

            services.RegisterApplicationsServices();

            services.RegisterPeopleServices();

            services.RegisterDriversServices();

            services.RegisterUsersServices();

            services.RegisterSettingsServices();

            services.RegisterMainFormServices();

            services.RegisterDeveloperInfoServices();

            services.RegisterSystemInfoServices();

            services.RegisterAddNewPersonServices();

            return services.BuildServiceProvider();
        }

        private static void InitializeAppSettings(IServiceProvider serviceProvider)
        {
            AppSettings.frmApplications = serviceProvider.GetRequiredService<FrmApplications>();
            AppSettings.frmPeople = serviceProvider.GetRequiredService<FrmPeople>();
            AppSettings.frmDrivers = serviceProvider.GetRequiredService<FrmDrivers>();
            AppSettings.frmUsers = serviceProvider.GetRequiredService<FrmUsers>();
            AppSettings.frmSettings = serviceProvider.GetRequiredService<FrmSettings>();

            AppSettings.frmDeveloperInfo = serviceProvider.GetRequiredService<FrmDeveloperInfo>();
            AppSettings.frmSystemInfo = serviceProvider.GetRequiredService<FrmSystemInfo>();

            AppSettings.developerUrlHandler = serviceProvider.GetRequiredService<DeveloperUrlHandler>();
            AppSettings.systemUrlHandler = serviceProvider.GetRequiredService<SystemUrlHandler>();

            AppSettings.formChosenList = new Dictionary<enFormChosen.enumFormChosen, Form>
            {
                { enFormChosen.enumFormChosen.applications, AppSettings.frmApplications },
                { enFormChosen.enumFormChosen.people, AppSettings.frmPeople },
                { enFormChosen.enumFormChosen.drivers, AppSettings.frmDrivers },
                { enFormChosen.enumFormChosen.users, AppSettings.frmUsers },
                { enFormChosen.enumFormChosen.settings, AppSettings.frmSettings }
            };

            AppSettings.linkLabelHandlers = new Dictionary<LinkLabel, ILinkLabelHandler>
            {
                { AppSettings.frmDeveloperInfo.ctrlDeveloperInfoCard.lnkLblLinkedIn, 
                    AppSettings.developerUrlHandler },
                { AppSettings.frmSystemInfo.ctrlSystemInfoCard.lnkLblLinkedIn, 
                    AppSettings.systemUrlHandler },
                { AppSettings.frmDeveloperInfo.ctrlDeveloperInfoCard.lnkLblGithub, 
                    AppSettings.developerUrlHandler },
                { AppSettings.frmSystemInfo.ctrlSystemInfoCard.lnkLblGithub, 
                    AppSettings.systemUrlHandler },
            };
        }
    }
}
