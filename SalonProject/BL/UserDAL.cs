using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using SalonProject.Model;

namespace SalonProject.BL
{
    class UserDAL : InterfaceUserDAL
    {
        private static UserDAL _userDAL = null;
        private static String _connectionString = @"Data Source = DESKTOP-USG1CBP\SQLEXPRESS;Initial Catalog=projectPs;Integrated Security=True";
        SqlConnection _conn = null;

        public UserDAL()
        {
            try
            {
                _conn = new SqlConnection(_connectionString);
            }
            catch (SqlException e)
            {
                _conn = null;
            }
        }

        public static UserDAL getInstance()
        {
            if (_userDAL == null)
            {
                _userDAL = new UserDAL();
            }
            return _userDAL;
        }

        public User getUser(String username, String password)
        {
            User u = null;
            String sql = "SELECT * FROM dbo.users WHERE username='" + username + "' AND password='" + password + "'";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                u = new User(reader["username"].ToString(), reader["password"].ToString(), reader["name"].ToString(), reader["role"].ToString());
                _conn.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return u;
        }

        public void addEmployee(String name, String username, String password)
        {
            Console.WriteLine(name + " " + username + " " + password);
            String sql = "INSERT INTO dbo.users (username, password, name, role) values ('" + username + "','" + password + "','" + name + "', 'employee')";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.ExecuteNonQuery();
                _conn.Close();
                Console.WriteLine("Added");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
