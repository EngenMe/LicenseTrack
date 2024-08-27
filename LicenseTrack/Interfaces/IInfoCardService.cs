using System.Windows.Forms;

namespace LicenseTrack.Interfaces
{
    public interface IInfoCardService
    {
        void ShowDeveloperInfoCard();
        void ShowSystemInfoCard();
        void SetLnkLblsCardServices();
        void SetSystemVersion();
    }
}
