using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using SalonProject.Model;
using System.Data;

namespace SalonProject.BL
{
    public class AppointmentDAL : InterfaceAppointmentDAL
    {
        
        private static AppointmentDAL _appointmentDAL = null;
        private static String _connectionString = @"Data Source = DESKTOP-USG1CBP\SQLEXPRESS;Initial Catalog=projectPs;Integrated Security=True";
        SqlConnection _conn = null;

        public AppointmentDAL()
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

        public static AppointmentDAL getInstance()
        {
            if (_appointmentDAL == null)
            {
                _appointmentDAL = new AppointmentDAL();
            }
            return _appointmentDAL;
        }
        List<Appointment> InterfaceAppointmentDAL.viewAppointments(DateTime date)
        {
            List<Appointment> appointmentsList = new List<Appointment>();
            // dd-MM-yy, HH:mm
            String sql = "SELECT * FROM dbo.appointments WHERE CONVERT(DATETIME, FLOOR(CONVERT(FLOAT, date))) = '" + date.Date + "'";

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                //SqlDataReader reader = cmd.ExecuteReader();
                //reader.Read();

                foreach (DataRow row in table.Rows)
                {
                    List<Services> selectedServices = new List<Services>();
                    String[] services = row["services"].ToString().Split(',');
                    String completeDate = row["date"].ToString().Trim(' ');
                    DateTime computedDate = DateTime.Parse(completeDate);
                    //DateTime.TryParseExact(completeDate, "dd-MM-yy, HH:mm", null, System.Globalization.DateTimeStyles.None, out computedDate);
                    foreach (String service in services)
                    {
                        ServicesDAL servicesDAL = new ServicesDAL();
                        Services serviceFound = servicesDAL.getServices(service);
                        selectedServices.Add(serviceFound);
                    }
                    Appointment appointment = new Appointment(computedDate, row["clientName"].ToString().Trim(' '), row["phoneNumber"].ToString().Trim(' '), selectedServices);
                    appointmentsList.Add(appointment);
                }
                _conn.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return appointmentsList;
        }

        void InterfaceAppointmentDAL.createAppointment(DateTime date, String clientName, String phoneNumber, List<Services> services)
        {
            List<String> servicesName = new List<String>();
            String[] dateString = date.ToString("dd-MM-yy, HH:mm").Split(',');
            foreach (Services service in services)
            {
                servicesName.Add(service.getServiceName());
            }
            String selectedServices = String.Join(",", servicesName);
            String sql = "INSERT INTO dbo.appointments (date, clientName, phoneNumber, services) values ('"  
                            + date + "','"
                            + clientName + "','" 
                            + phoneNumber + "','" 
                            + selectedServices + "')";
            List<Appointment> appointments = viewAppointmentsSameDate(date);
            foreach(Appointment appointment in appointments)
            {
                foreach(Services services1 in appointment.getServices())
                {
                    foreach(String svName in servicesName)
                    {
                        if (services1.getServiceName().Equals(svName))
                        {
                            return;
                        }
                    }
                }
            }

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

        List<Appointment> InterfaceAppointmentDAL.viewAppointmentsClient(String clientName)
        {
            List<Appointment> appointments = new List<Appointment>();
            String sql = "SELECT * FROM dbo.appointments WHERE clientName = '" + clientName + "'";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                //SqlDataReader reader = cmd.ExecuteReader();
                //reader.Read();

                foreach (DataRow row in table.Rows)
                {
                    List<Services> selectedServices = new List<Services>();
                    String[] services = row["services"].ToString().Split(',');
                    String completeDate = row["date"].ToString().Trim(' ');
                    Console.WriteLine(completeDate);
                    DateTime computedDate = DateTime.Parse(completeDate);
                    //DateTime.TryParseExact(completeDate, "yyyy-MM-dd HH:mm:ss.fff", null, System.Globalization.DateTimeStyles.None, out computedDate);
                    Console.WriteLine(computedDate);
                    foreach (String service in services)
                    {
                        ServicesDAL servicesDAL = new ServicesDAL();
                        Services serviceFound = servicesDAL.getServices(service);
                        selectedServices.Add(serviceFound);
                    }
                    //Appointment appointment = new Appointment(computedDate, row["clientName"].ToString(), row["phoneNumber"].ToString(), selectedServices);
                    Appointment appointment = new Appointment(computedDate, row["clientName"].ToString().Trim(' '), row["phoneNumber"].ToString().Trim(' '), selectedServices);
                    appointments.Add(appointment);
                }
                _conn.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return appointments;
        }

        public List<Appointment> viewAppointmentsSameDate(DateTime date)
        {
            List<Appointment> appointmentsList = new List<Appointment>();
            // dd-MM-yy, HH:mm
            String sql = "SELECT * FROM dbo.appointments WHERE date = '" + date + "'";

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                //SqlDataReader reader = cmd.ExecuteReader();
                //reader.Read();

                foreach (DataRow row in table.Rows)
                {
                    List<Services> selectedServices = new List<Services>();
                    String[] services = row["services"].ToString().Split(',');
                    String completeDate = row["date"].ToString().Trim(' ');
                    DateTime computedDate = DateTime.Parse(completeDate);
                    //DateTime.TryParseExact(completeDate, "dd-MM-yy, HH:mm", null, System.Globalization.DateTimeStyles.None, out computedDate);
                    foreach (String service in services)
                    {
                        ServicesDAL servicesDAL = new ServicesDAL();
                        Services serviceFound = servicesDAL.getServices(service);
                        selectedServices.Add(serviceFound);
                    }
                    Appointment appointment = new Appointment(computedDate, row["clientName"].ToString().Trim(' '), row["phoneNumber"].ToString().Trim(' '), selectedServices);
                    appointmentsList.Add(appointment);
                }
                _conn.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return appointmentsList;
        }

        List<Appointment> InterfaceAppointmentDAL.getAppointmentsBetween(DateTime date1, DateTime date2)
        {
            List<Appointment> appointmentsList = new List<Appointment>();
            // dd-MM-yy, HH:mm
            String sql = "SELECT * FROM dbo.appointments WHERE date BETWEEN '" + date1 + "' AND '" + date2 +"'";

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                //SqlDataReader reader = cmd.ExecuteReader();
                //reader.Read();

                foreach (DataRow row in table.Rows)
                {
                    List<Services> selectedServices = new List<Services>();
                    String[] services = row["services"].ToString().Split(',');
                    String completeDate = row["date"].ToString().Trim(' ');
                    DateTime computedDate = DateTime.Parse(completeDate);
                    foreach (String service in services)
                    {
                        ServicesDAL servicesDAL = new ServicesDAL();
                        Services serviceFound = servicesDAL.getServices(service);
                        selectedServices.Add(serviceFound);
                    }
                    Appointment appointment = new Appointment(computedDate, row["clientName"].ToString().Trim(' '), row["phoneNumber"].ToString().Trim(' '), selectedServices);
                    appointmentsList.Add(appointment);
                }
                _conn.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return appointmentsList;
        }
    }
}
