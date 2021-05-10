using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using SalonProject.Model;
using System.Data;
using System.Threading;
using System.Collections;

namespace SalonProject.BL
{
    class ServicesDAL : InterfaceServicesDAL
    {

        private static ServicesDAL _servicesDAL = null;
        private static String _connectionString = @"Data Source = DESKTOP-USG1CBP\SQLEXPRESS;Initial Catalog=projectPs;Integrated Security=True";
        SqlConnection _conn = null;

        public ServicesDAL()
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

        public static ServicesDAL getInstance()
        {
            if (_servicesDAL == null)
            {
                _servicesDAL = new ServicesDAL();
            }
            return _servicesDAL;
        }
        public Services getServices(String serviceName)
        {
            Services services = null;
            String sql = "SELECT * FROM dbo.services WHERE serviceName='" + serviceName + "'";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                String name = reader["serviceName"].ToString().Trim(' ');
                float price = float.Parse(reader["servicePrice"].ToString().Trim(' '));
                reader.Close();
                services = new Services(name, price);
                _conn.Close();
            } 
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

            return services;
        }
    
        void InterfaceServicesDAL.addServices(String serviceName, float servicePrice)
        {
            String sql = "INSERT INTO dbo.services (serviceName, servicePrice) values ('" + serviceName + "','" + servicePrice + "')";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.ExecuteNonQuery();
                _conn.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        void InterfaceServicesDAL.updateServices(String serviceName, float servicePrice, String serviceName2, float servicePrice2)
        {
            Console.WriteLine(serviceName + " " + servicePrice + " " + serviceName2 + " " + servicePrice2);
            String sql = null;
            if (!serviceName.Equals("") && !serviceName2.Trim().Equals(""))
            {
                sql = "UPDATE dbo.services SET serviceName = '" + serviceName + "' WHERE serviceName = '" + serviceName2 + "'";
                try
                {
                    _conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, _conn);
                    cmd.ExecuteNonQuery();
                    _conn.Close();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                }

            }

            if (servicePrice != 0.0f && !serviceName2.Trim().Equals(""))
            {
                sql = "UPDATE dbo.services SET servicePrice = '" + servicePrice + "' WHERE serviceName = '" + serviceName2 + "'";
                try
                {
                    _conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, _conn);
                    cmd.ExecuteNonQuery();
                    _conn.Close();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        void InterfaceServicesDAL.deleteServices(String serviceName)
        {
            String sql = "DELETE FROM dbo.services WHERE serviceName = '" + serviceName + "'";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.ExecuteNonQuery();
                _conn.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        
        List<Services> InterfaceServicesDAL.viewServices()
        {

            List<Services> servicesList = new List<Services>();
            String sql = "SELECT serviceName, servicePrice FROM dbo.services ORDER BY serviceName";
            try
            {

                _conn.Open();

                SqlCommand cmd = new SqlCommand(sql, _conn);
                //DataTable table = new DataTable();
                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                SqlDataReader reader = cmd.ExecuteReader();
                //adapter.Fill(table);
                //cmd.ExecuteNonQuery();
                //cmd.ExecuteNonQuery();
                while (reader.Read())
                {
                        String serviceName = reader["serviceName"].ToString().Trim(' ');
                        float servicePrice = float.Parse(reader["servicePrice"].ToString().Trim(' '));
                        Services service = new Services(serviceName, servicePrice);
                    //while (reader.Read())
                    //{
                    //Services service = new Services();
                    //service.setServiceName(reader["serviceName"].ToString().Trim(' '));
                    //service.setServicePrice(float.Parse(reader["servicePrice"].ToString().Trim(' ')));
                    //Console.WriteLine(reader["serviceName"].ToString());
                    //column["serviceName"] = reader["serviceName"].ToString().Trim(' ');
                    Console.WriteLine(service.getServiceName());
                    servicesList.Add(service);
                    //Console.WriteLine(servicesList[0].getServiceName());
                }
                foreach(Services service in servicesList)
                {
                    Console.WriteLine(service.getServiceName());
                }
                _conn.Close();
                Console.WriteLine(servicesList[0].getServiceName());
                return servicesList;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
