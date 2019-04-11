using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CamperBookingSystem.Classes
{
    class User
    {
        public string username = "";
        public bool admin = false;

        public static User Find(string queriedUsername)
        {
            User oUser = new User();
            DataRow dataRow = DB.FindUser(queriedUsername);

            if (dataRow != null)
            {
                oUser.username = dataRow["Username"].ToString();
                oUser.admin = bool.Parse(dataRow["admin"].ToString());

                return oUser;
            }
            else
            {
                return null;
            }
            
        }
        
    }
}
