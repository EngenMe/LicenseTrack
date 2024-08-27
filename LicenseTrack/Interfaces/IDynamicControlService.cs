using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseTrack.Interfaces
{
    public interface IDynamicControlService
    {
        void UpdateCurrentWindowName(Button btnClicked, Label lblWindowName);
        void UpdateDateAndTime(Label lblDateTime);
        void UpdateUsername(Label lblUsername);
        void UpdateDynamicPnlState(Panel dynamicPnl, Button btnClicked);
    }
}
