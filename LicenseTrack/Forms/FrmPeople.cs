using BusinessLayer.Interfaces;
using LicenseTrack.Interfaces;
using System.Data;
using System.Windows.Forms;

namespace LicenseTrack.Forms
{
    public partial class FrmPeople : Form
    {
        private readonly IDataService _dataService;
        private readonly IGetNumberOfRecordFromDtService _getNumberOfRecordFromDtService;
        private readonly IAddNewPersonService _addNewPersonService;
        private readonly string _peopleTableName;

        public FrmPeople(IDataService dataService, string peopleTableName, 
            IGetNumberOfRecordFromDtService getNumberOfRecordFromDtService,
            IAddNewPersonService addNewPersonService)
        {
            InitializeComponent();

            _dataService = dataService;
            _peopleTableName = peopleTableName;
            _getNumberOfRecordFromDtService = getNumberOfRecordFromDtService;
            _addNewPersonService = addNewPersonService;

            _FillDgvService();
            _SetNumberOfRecordService();
            _AddNewPersonService();
        }

        public void _FillDgvService()
        {
            dgvPeople.DataSource = _dataService.GetDataTable(_peopleTableName);
        }

        public void _SetNumberOfRecordService()
        {
            lblNumberOfRecords.Text = _getNumberOfRecordFromDtService.GetNumberOfRecords(
                (DataTable)dgvPeople.DataSource).ToString();
        }

        // Add new person service
        public void _AddNewPersonService()
        {
            btnAddNewPerson.Click += BtnAddNewPerson_Click;
        }

        private void BtnAddNewPerson_Click(object sender, System.EventArgs e)
        {
            _addNewPersonService.ShowAddNewPersonFrm();
        }
    }
}
