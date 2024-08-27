using LicenseTrack.Forms;
using LicenseTrack.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseTrack.Classes
{
    public class AddNewPersonService : IAddNewPersonService
    {
        private readonly FrmAddNewPerson _frmAddNewPerson;

        public AddNewPersonService(FrmAddNewPerson frmAddNewPerson)
        {
            _frmAddNewPerson = frmAddNewPerson;
        }

        public void ShowAddNewPersonFrm()
        {
            _frmAddNewPerson.ShowDialog();
        }
    }
}
