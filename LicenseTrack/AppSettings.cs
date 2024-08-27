using BusinessLayer.Classes;
using BusinessLayer.Interfaces;
using LicenseTrack.Classes;
using LicenseTrack.Forms;
using LicenseTrack.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseTrack
{
    internal class AppSettings
    {
        internal static FrmApplications frmApplications { get; set; }
        internal static FrmPeople frmPeople { get; set; }
        internal static FrmDrivers frmDrivers { get; set; }
        internal static FrmUsers frmUsers { get; set; }
        internal static FrmSettings frmSettings { get; set; }
        internal static FrmDeveloperInfo frmDeveloperInfo { get; set; }
        internal static FrmSystemInfo frmSystemInfo { get; set; }
        internal static DeveloperUrlHandler developerUrlHandler { get; set; }
        internal static SystemUrlHandler systemUrlHandler { get; set; }

        internal static readonly string mainFormDateTimeFormat = "F";

        internal static readonly string developerGithubURL = "https://github.com/EngenMe";
        internal static readonly string systemGithubURL = "https://github.com/EngenMe";
        internal static readonly string developerLinkedInURL = "https://www.linkedin.com/in/engenme/";
        internal static readonly string systemLinkedInURL = "https://www.linkedin.com/in/engenme/";

        internal static readonly string developerEmail = "mohamed_farouk.hasnaoui@g.enp.edu.dz";
        internal static readonly string developerPhone = "+353899485281";

        internal static readonly string systemVersion = "1.0.0.1"; //TODO - Get system version from git

        internal static readonly string peopleTableName = "vw_people";
        internal static readonly string nationalityDataTableName = "nationalities";
        internal static readonly string countryDataTableName = "countries";

        internal static readonly string connectionString = 
            "Server=.;Database=DB_License_Track;User Id=sa;Password=sa123456;";

        internal static readonly string defaultNationality = "Irish";
        internal static readonly string defaultCountry = "Ireland";

        internal static readonly string defaultMalePicturePath = 
            @"C:\Users\moham\source\repos\DataAccessLayer\data\Img\defaultMale.png";
        internal static readonly string defaultFemalePicturePath =
            @"C:\Users\moham\source\repos\DataAccessLayer\data\Img\defaultFemale.png";

        internal static readonly int requiredAgeApplicationForDrivingLicenseApplication = 18;

        internal static readonly List<string> allowedTables = new List<string> { peopleTableName,
            nationalityDataTableName, countryDataTableName };

        internal static Dictionary<enFormChosen.enumFormChosen, Form> formChosenList { get; set; }

        internal static Dictionary<LinkLabel, ILinkLabelHandler> linkLabelHandlers { get; set; }
    }
}
