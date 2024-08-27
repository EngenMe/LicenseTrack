using System.Windows.Forms;

namespace LicenseTrack.Forms
{
    public interface ISetDefaultPersonalPictureService
    {
        void SetPersonalPicture(RadioButton rbMale, PictureBox pictureBox);
    }
}