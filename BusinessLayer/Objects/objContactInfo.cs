using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.objects
{
    public class objContactInfo
    {
        public int ContactInfoID { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }

        public objContactInfo(int contactInfoID, string homePhone, string mobilePhone, string email)
        {
            ContactInfoID = contactInfoID;
            HomePhone = homePhone;
            MobilePhone = mobilePhone;
            Email = email;
        }
        public objContactInfo()
        {
            ContactInfoID = 0;
            HomePhone = string.Empty;
            MobilePhone = string.Empty;
            Email = string.Empty;
        }
    }
}
