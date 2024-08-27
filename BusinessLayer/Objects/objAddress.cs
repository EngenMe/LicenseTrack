using BusinessLayer.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.objects
{
    public class objAddress
    {
        public int AddressID { get; set; }
        public objCountry Country { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public objAddress(int addressID, objCountry country, string streetLine1, string streetLine2,
            string city, string state,
            string zip)
        {
            AddressID = addressID;
            Country = country;
            StreetLine1 = streetLine1;
            StreetLine2 = streetLine2;
            City = city;
            State = state;
            Zip = zip;
        }
        public objAddress()
        {
            AddressID = 0;
            Country = new objCountry();
            StreetLine1 = string.Empty;
            StreetLine2 = string.Empty;
            City = string.Empty;
            State = string.Empty;
            Zip = string.Empty;
        }
    }
}
