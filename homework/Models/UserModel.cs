using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework.Models
{
    class UserModel
    {
        private string firstName;
        private string surName;
        private string lastName;
        private string login;
        private string password;

        public UserModel() { }
        public UserModel(string _firstName, string _surName, string _lastName, string _login, string _password) 
        {
           this.firstName = _firstName;
            this.surName = _surName;
            this.lastName = _lastName;
            this.login = _login;
            this.password = _password;
        }

      

        public string GetFirstName() { return firstName; }
        public string GetSurName() { return surName; }
        public string GetLastName() { return lastName; }
        public string GetLogin() { return login; }
        public string GetPassword() { return password; }
    }
}
