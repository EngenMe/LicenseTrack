using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.objects
{
    public class objName
    {
        public int NameID {  get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public objName(int nameID, string firstName, string middleName, string lastName)
        {
            NameID = nameID;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }
        public objName()
        {
            NameID = 0;
            FirstName = string.Empty;
            MiddleName = string.Empty;
            LastName = string.Empty;
        }
    }
}
