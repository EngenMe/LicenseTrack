using LicenseTrack.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseTrack.Classes
{
    public class SetComboBoxValueService : ISetComboBoxValueService
    {
        public void SetValue(ComboBox comboBox, string value)
        {
            if (comboBox != null && value != null)
            {
                int counter = 0;

                foreach (string item in comboBox.Items)
                {
                    if (item == value)
                    {
                        comboBox.SelectedIndex = counter;
                        return;
                    }

                    counter++;
                }
            }
        }
    }
}
