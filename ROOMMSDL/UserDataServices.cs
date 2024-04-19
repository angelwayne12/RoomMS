using ROOMMSMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROOMMSDL
{
    public class UserDataServices
    {
        List<User> users = new List<User>();

        public UserDataServices()
        {
            CreateUserData();
        }

        public void CreateUserData()
        {
            User user1 = new User();
            user1.username = "angel";
            user1.password = "wayne";

            User user2 = new User();
            user2.username= "admin";
            user2.password = "12345";

            users.Add(user1);
            users.Add(user2);
        }

        public User GetUser(string username, string password)
        {
            User foundUser = new User();

            foreach (var user in users)
            {
                if(user.username== username && user.password == password)
                {
                    return user;
                }

            }
            return null;
        }
    }
}
