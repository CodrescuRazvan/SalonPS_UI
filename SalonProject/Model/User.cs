using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonProject.Model
{
    public class User
    {
        private String _name;
        private String _username;
        private String _password;
        private String _role;

        public User(String name, String username, String password, String role)
        {
            _name = name;
            _username = username;
            _password = password;
            _role = role;
        }

        public String getRole()
        {
            return _role;
        }

        public String getName()
        {
            return _name;
        }

        public String getPassword()
        {
            return _password;
        }

        public String getUsername()
        {
            return _username;
        }
    }
}
