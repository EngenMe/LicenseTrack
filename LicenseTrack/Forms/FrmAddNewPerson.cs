using BusinessLayer.Interfaces;
using LicenseTrack.Interfaces;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LicenseTrack.Forms
{
    public partial class FrmAddNewPerson : Form
    {
        private readonly IKeyPressService _keyPressService;
        private readonly int _requiredAgeApplicationForDrivingLicenseApplication;
        private readonly ISetComboBoxValueService _setComboBoxValue;
        private readonly IDataService _dataService;
        private readonly string _nationalityDataTableName;
        private readonly string _countryDataTableName;
        private readonly string _defaultNationality;
        private readonly string _defaultCountry;
        private readonly ISetDefaultPersonalPictureService _setDefaultPersonalPictureService;

        public FrmAddNewPerson(IKeyPressService keyPressService,
            int requiredAgeApplicationForDrivingLicenseApplication,
            ISetComboBoxValueService setComboBoxValue, IDataService dataService,
            string nationalityDataTableName, string countryDataTableName, string defaultNationality, 
            string defaultCountry, ISetDefaultPersonalPictureService setDefaultPersonalPictureService)
        {
            InitializeComponent();

            _keyPressService = keyPressService;
            _requiredAgeApplicationForDrivingLicenseApplication =
                requiredAgeApplicationForDrivingLicenseApplication;
            _setComboBoxValue = setComboBoxValue;
            _dataService = dataService;
            _nationalityDataTableName = nationalityDataTableName;
            _defaultNationality = defaultNationality;
            _defaultCountry = defaultCountry;
            _countryDataTableName = countryDataTableName;
            _setDefaultPersonalPictureService = setDefaultPersonalPictureService;

            _SetKeyPressService();
            _SetDateOfBirthConstraints();
            _FillNationalityCb();
            _FillCountryCb();
            _SetDefaultNationality();
            _SetDefaultCountry();
            _SetDefaultPersonalPictureService();
        }

        private void _SetKeyPressService()
        {
            ctrlInputPersonInfo.tbFirstName.KeyPress += _keyPressService.MustBeLetterOrWhiteSpace;
            ctrlInputPersonInfo.tbMiddleName.KeyPress += _keyPressService.MustBeLetterOrWhiteSpace;
            ctrlInputPersonInfo.tbLastName.KeyPress += _keyPressService.MustBeLetterOrWhiteSpace;
        }

        private void _SetDateOfBirthConstraints()
        {
            ctrlInputPersonInfo.dtpDateOfBirth.MaxDate = 
                DateTime.Now.AddYears(-_requiredAgeApplicationForDrivingLicenseApplication);
            ctrlInputPersonInfo.dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);
            ctrlInputPersonInfo.dtpDateOfBirth.Value = DateTime.Now.AddYears(-20);
        }

        private void _FillNationalityCb()
        {
            ctrlInputPersonInfo.cbNationality.DataSource = 
                _dataService.GetDataTable(_nationalityDataTableName).AsEnumerable().Select(
                    row => row.Field<string>("nationality_name")).ToList();
        }

        private void _FillCountryCb()
        {
            ctrlInputPersonInfo.cbCountry.DataSource =
                _dataService.GetDataTable(_countryDataTableName).AsEnumerable().Select(
                    row => row.Field<string>("country_name")).ToList();
        }

        private void _SetDefaultNationality()
        {
            _setComboBoxValue.SetValue(ctrlInputPersonInfo.cbNationality, _defaultNationality);
        }

        private void _SetDefaultCountry()
        {
            _setComboBoxValue.SetValue(ctrlInputPersonInfo.cbCountry, _defaultCountry);
        }

        private void _SetDefaultPersonalPictureService()
        {
            ctrlInputPersonInfo.rbMale.CheckedChanged += RbMale_CheckedChanged;
        }

        private void RbMale_CheckedChanged(object sender, EventArgs e)
        {
            _setDefaultPersonalPictureService.SetPersonalPicture(ctrlInputPersonInfo.rbMale,
                ctrlInputPersonInfo.pbPersonalPicture);
        }
    }
}
