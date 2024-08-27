using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Objects
{
    public class objCountry
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public objCountry(int countryID, string countryName)
        {
            CountryID = countryID;
            CountryName = countryName;
        }
        public objCountry()
        {
            CountryID = 0;
            CountryName = string.Empty;
        }
    }
}
