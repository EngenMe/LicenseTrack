using BusinessLayer.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.objects
{
    public class objPerson
    {
        public int PersonID { get; set; }
        public objName Name { get; set; }
        public objAddress Address { get; set; }
        public objContactInfo ContactInfo { get; set; }
        public objNationality Nationality { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalIdNumber { get; set; }
        public char Gender { get; set; }
        public string PersonalPicture { get; set; }

        public objPerson(int personID, objName name, objAddress address, objContactInfo contactInfo,
            objNationality nationality, DateTime dateOfBirth, string nationalIdNumber, char gender, 
            string personalPicture)
        {
            PersonID = personID;
            Name = name;
            Address = address;
            ContactInfo = contactInfo;
            Nationality = nationality;
            DateOfBirth = dateOfBirth;
            NationalIdNumber = nationalIdNumber;
            Gender = gender;
            PersonalPicture = personalPicture;

        }
        public objPerson()
        {
            PersonID = 0;
            Name = new objName();
            Address = new objAddress();
            ContactInfo = new objContactInfo();
            Nationality = new objNationality();
            DateOfBirth = DateTime.MinValue;
            NationalIdNumber = string.Empty;
            Gender = '\0';
            PersonalPicture = string.Empty;
        }
    }
}
