using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer.Interfaces
{
    public interface IKeyPressService
    {
        void MustBeDigit(object sender, KeyPressEventArgs e);
        void MustBeDigitOrWhiteSpace(object sender, KeyPressEventArgs e);
        void MustBeLetter(object sender, KeyPressEventArgs e);
        void MustBeLetterOrWhiteSpace(object sender, KeyPressEventArgs e);
    }
}
