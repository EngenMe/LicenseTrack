using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Objects
{
    public class objNationality
    {
        public int NationalityID { get; set; }
        public string NationalityName { get; set; }

        public objNationality(int nationalityID, string nationalityName)
        {
            NationalityID = nationalityID;
            NationalityName = nationalityName;
        }
        public objNationality()
        {
            NationalityID = 0;
            NationalityName = string.Empty;
        }
    }
}
