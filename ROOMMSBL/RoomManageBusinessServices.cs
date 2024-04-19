using ROOMMSDL;
using ROOMMSMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RoomManageBusinessServices
{
     public class UserService
    {

        public bool VerifyUser(string username, string password)
        {
            UserDataServices dataServices = new UserDataServices();
            var result = dataServices.GetUser(username, password);

            return result != null ? true : false;


        }
    }
}
