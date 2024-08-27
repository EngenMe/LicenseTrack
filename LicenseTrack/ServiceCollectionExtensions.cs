using BusinessLayer.Classes;
using BusinessLayer.Interfaces;
using LicenseTrack.Classes;
using LicenseTrack.Forms;
using LicenseTrack.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LicenseTrack
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterMainFormServices(this IServiceCollection services)
        {
            services.AddSingleton<FrmMain>(
                provider => new FrmMain(
                    provider.GetRequiredService<IFormTitleBarService>(),
                    provider.GetRequiredService<IDynamicControlService>(),
                    provider.GetRequiredService<IInfoCardService>(),
                    provider.GetRequiredService<IShowFrmInsidePnlService>(),
                    AppSettings.formChosenList
                    )
            );
        }

        public static void RegisterApplicationsServices(this IServiceCollection services)
        {
            services.AddSingleton<FrmApplications>(
                provider => new FrmApplications(
                    )
            );
        }

        public static void RegisterPeopleServices(this IServiceCollection services)
        {
            services.AddSingleton<FrmPeople>(
                provider => new FrmPeople(
                    provider.GetRequiredService<IDataService>(),
                    AppSettings.peopleTableName,
                    provider.GetRequiredService<IGetNumberOfRecordFromDtService>(),
                    provider.GetRequiredService<IAddNewPersonService>()
                    )
            );
        }

        public static void RegisterDriversServices(this IServiceCollection services)
        {
            services.AddSingleton<FrmDrivers>(
                provider => new FrmDrivers(
                    )
            );
        }

        public static void RegisterUsersServices(this IServiceCollection services)
        {
            services.AddSingleton<FrmUsers>(
                provider => new FrmUsers(
                    )
            );
        }

        public static void RegisterSettingsServices(this IServiceCollection services)
        {
            services.AddSingleton<FrmSettings>(
                provider => new FrmSettings(
                    )
            );
        }

        public static void RegisterDeveloperInfoServices(this IServiceCollection services)
        {
            services.AddSingleton<FrmDeveloperInfo>(
                provider => new FrmDeveloperInfo(
                    )
                );
            services.AddSingleton<DeveloperUrlHandler>(provider =>
                new DeveloperUrlHandler(AppSettings.developerLinkedInURL));
        }

        public static void RegisterSystemInfoServices(this IServiceCollection services)
        {
            services.AddSingleton<FrmSystemInfo>(
                provider => new FrmSystemInfo(
                    )
                );
            services.AddSingleton<SystemUrlHandler>(provider =>
                new SystemUrlHandler(AppSettings.systemLinkedInURL));
        }

        public static void RegisterAddNewPersonServices(this IServiceCollection services)
        {
            services.AddSingleton<FrmAddNewPerson>(
                provider => new FrmAddNewPerson(
                    provider.GetRequiredService<IKeyPressService>(),
                    AppSettings.requiredAgeApplicationForDrivingLicenseApplication,
                    provider.GetRequiredService<ISetComboBoxValueService>(),
                    provider.GetRequiredService<IDataService>(),
                    AppSettings.nationalityDataTableName,
                    AppSettings.countryDataTableName,
                    AppSettings.defaultNationality,
                    AppSettings.defaultCountry,
                    provider.GetRequiredService<ISetDefaultPersonalPictureService>()
                    )
                );
        }

        public static void RegisterCommonServices(this IServiceCollection services)
        {
            services.AddSingleton<IFormTitleBarService, FormTitleBarService>();
            services.AddSingleton<IDynamicControlService, DynamicControlService>(
                provider => new DynamicControlService(
                    AppSettings.mainFormDateTimeFormat,
                    "admin" //TODO - Get username from log
                    )
                );
            services.AddSingleton<IInfoCardService, InfoCardService>(
                provider => new InfoCardService(
                    provider.GetRequiredService<FrmDeveloperInfo>(),
                    provider.GetRequiredService<FrmSystemInfo>(),
                    AppSettings.developerGithubURL,
                    AppSettings.developerLinkedInURL,
                    AppSettings.developerEmail,
                    AppSettings.developerPhone,
                    AppSettings.linkLabelHandlers,
                    AppSettings.systemVersion
                    )
                );
            services.AddSingleton<IShowFrmInsidePnlService, ShowFrmInsidePnlService>();
            services.AddSingleton<IDatabaseServiceFactory, DatabaseServiceFactory>();
            services.AddSingleton<IDataServiceFactory, DataServiceFactory>();
            services.AddSingleton<IDataService, DataService>(
                provider => new DataService(
                    AppSettings.connectionString,
                    AppSettings.allowedTables,
                    provider.GetRequiredService<IDatabaseServiceFactory>(),
                    provider.GetRequiredService<IDataServiceFactory>()
                    )
                );
            services.AddSingleton<IGetNumberOfRecordFromDtService, GetNumberOfRecordFromDtService>();
            services.AddSingleton<IAddNewPersonService, AddNewPersonService>(
                provider => new AddNewPersonService(
                    provider.GetRequiredService<FrmAddNewPerson>()
                    )
                );
            services.AddSingleton<IKeyPressService, KeyPressService>();
            services.AddSingleton<ISetComboBoxValueService, SetComboBoxValueService>();
            services.AddSingleton<ISetDefaultPersonalPictureService, SetDefaultPersonalPictureService>(
                provider => new SetDefaultPersonalPictureService(
                    AppSettings.defaultMalePicturePath,
                    AppSettings.defaultFemalePicturePath
                    )
                );
        }
    }
}
