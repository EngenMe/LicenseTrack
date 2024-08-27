using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseTrack.Interfaces
{
    public interface ISetComboBoxValueService
    {
        void SetValue(ComboBox comboBox, string value);
    }
}
