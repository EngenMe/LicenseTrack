using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseTrack.Interfaces
{
    public interface IFormTitleBarService
    {
        void ToggleForm(Form form);
        void MinimizeForm(Form form);
        void ExitForm();
    }
}
