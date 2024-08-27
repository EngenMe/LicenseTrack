using LicenseTrack.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseTrack.Classes
{
    public class SetDefaultPersonalPictureService : ISetDefaultPersonalPictureService
    {
        private readonly string _defaultMalePicturePath;
        private readonly string _defaultFemalePicturePath;

        public SetDefaultPersonalPictureService(string defaultMenPath, string defaultWomenPath)
        {
            _defaultMalePicturePath = defaultMenPath;
            _defaultFemalePicturePath = defaultWomenPath;
        }

        public void SetPersonalPicture(RadioButton rbMale, PictureBox pictureBox)
        {
            if (rbMale.Checked)
                pictureBox.ImageLocation = _defaultMalePicturePath;
            else
                pictureBox.ImageLocation = _defaultFemalePicturePath;
        }
    }
}
