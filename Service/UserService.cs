using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Security.Cryptography;

namespace Service
{
    class UserService
    {
        private static UserService _userService = null;

        public UserService() { }

        public static UserService getInstance()
        {
            if (_userService == null)
            {
                _userService = new UserService();
            }
            return _userService;
        }
        public User login(String username, String password)
        {
            String password1 = getMd5Hash(password);
            try
            {
                UserDAL userDAL = new UserDAL();
                User user = userDAL.getUser(username, password1);
                return user;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        static string getMd5Hash(string input)
        {

            // Create a new instance of the MD5CryptoServiceProvider object. 
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash. 
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes 
            // and create a string. 
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data  
            // and format each one as a hexadecimal string. 
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string. 
            return sBuilder.ToString();
        }
    }
}
