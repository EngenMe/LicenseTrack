using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BusinessLayer.objects
{
    public class objUser
    {
        public int UserID { get; set; }
        public objPerson Person { get; set; }
        public string Username {  get; set; }
        public string Password { get; set; }
        public int Permission { get; set; }

        public objUser(int userID, objPerson person, string username, string password, int permission)
        {
            UserID = userID;
            Person = person; 
            Username = username;
            Password = password;
            Permission = permission;
        }
        public objUser()
        {
            UserID = 0;
            Person = new objPerson();
            Username = string.Empty;
            Password = string.Empty;
            Permission = 0;
        }
    }
}
