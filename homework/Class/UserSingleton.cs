using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework.Class
{
   
    class UserSingleton
    {
        private static Models.UserModel user;
        public static Models.UserModel GetUser() 
        {
            if (user == null)
                user = new Models.UserModel();
            return user;
        }
        public static Models.UserModel FromDb(Entity.Manager _maneger, Entity.User _user) 
        {
            GetUser();
            user = new Models.UserModel(_user.FirstName,_user.SurName,_user.LastName,_maneger.Login);
            return user;
        }
    }
}
