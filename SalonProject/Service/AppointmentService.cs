using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalonProject.Model;
using SalonProject.BL;
using System.Configuration;
using System.Reflection;

namespace SalonProject.Service
{
    class AppointmentService
    {
        private static AppointmentService _appointmentService = null;
        InterfaceAppointmentDAL _appointmentDAL;
        InterfaceServicesDAL _servicesDAL;
        public AppointmentService() 
        {
            Type obj = Type.GetType(ConfigurationManager.AppSettings["DefaultBLAppointment"]);
            MethodInfo method = obj.GetMethod("getInstance");
            _appointmentDAL = (AppointmentDAL)method.Invoke(_appointmentDAL, null);

            Type obj2 = Type.GetType(ConfigurationManager.AppSettings["DefaultBLServices"]);
            MethodInfo method2 = obj2.GetMethod("getInstance");
            _servicesDAL = (ServicesDAL)method2.Invoke(_servicesDAL, null);
        }

        public List<String> viewAppointmentByDate(String date)
        {
            try
            {
                DateTime newDate;
                DateTime.TryParseExact(date, "dd-MM-yy, HH:mm", null, System.Globalization.DateTimeStyles.None, out newDate);
                List<Appointment> appointments = _appointmentDAL.viewAppointments(newDate);
                List<String> final = new List<String>();
                foreach (Appointment appointment in appointments)
                {
                    List<String> servicesName = new List<String>();
                    float totalValue = 0.0f;
                    foreach(Services service in appointment.getServices())
                    {
                        servicesName.Add(service.getServiceName());
                        totalValue += service.getServicePrice();
                    }
                    String services = String.Join(", ", servicesName);
                    final.Add(appointment.getDate().ToString() + ", " + appointment.getClientName() + ", " + appointment.getPhoneNumber() + ", " + services + ", " + totalValue.ToString());
                }
                return final;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public void createAppointment(String date, String clientName, String phoneNumber, String services)
        {
            try
            {
                DateTime newDate;
                DateTime.TryParseExact(date, "dd-MM-yy, HH:mm", null, System.Globalization.DateTimeStyles.None, out newDate);
                Console.WriteLine(newDate);
                String[] servicesString = services.Split(',');
                List<Services> servicesToList = new List<Services>();
                foreach (String service in servicesString)
                {
                    Console.WriteLine(service.Trim(' '));
                    Services serviceFound = _servicesDAL.getServices(service.Trim(' '));
                    servicesToList.Add(serviceFound);
                }
                _appointmentDAL.createAppointment(newDate, clientName, phoneNumber, servicesToList);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public List<String> viewAppointmentClient(String name)
        {
            try
            {
                List<Appointment> appointmentList = _appointmentDAL.viewAppointmentsClient(name);
                List<String> final = new List<String>();
                foreach (Appointment appointment in appointmentList)
                {
                    List<String> servicesName = new List<String>();
                    float totalValue = 0.0f;
                    foreach (Services service in appointment.getServices())
                    {
                        servicesName.Add(service.getServiceName());
                        totalValue += service.getServicePrice();
                    }
                    String services = String.Join(", ", servicesName);
                    final.Add(appointment.getDate().ToString() + ", " + appointment.getClientName() + ", " + appointment.getPhoneNumber() + ", " + services + ", " + totalValue.ToString());
                }
                return final;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public List<String> viewAppointmentDate(String date)
        {
            try
            {
                DateTime newDate;
                DateTime.TryParseExact(date, "dd-MM-yy, HH:mm", null, System.Globalization.DateTimeStyles.None, out newDate);
                List<Appointment> appointmentList = _appointmentDAL.viewAppointments(newDate);
                List<String> final = new List<String>();
                foreach (Appointment appointment in appointmentList)
                {
                    List<String> servicesName = new List<String>();
                    float totalValue = 0.0f;
                    foreach (Services service in appointment.getServices())
                    {
                        servicesName.Add(service.getServiceName());
                        totalValue += service.getServicePrice();
                    }
                    String services = String.Join(", ", servicesName);
                    final.Add(appointment.getDate().ToString() + ", " + appointment.getClientName() + ", " + appointment.getPhoneNumber() + ", " + services + ", " + totalValue.ToString());
                }
                return final;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }

        public List<String> viewBetweenDates(String date1, String date2)
        {
            try
            {
                DateTime newDate1, newDate2;
                DateTime.TryParseExact(date1, "dd-MM-yy, HH:mm", null, System.Globalization.DateTimeStyles.None, out newDate1);
                DateTime.TryParseExact(date2, "dd-MM-yy, HH:mm", null, System.Globalization.DateTimeStyles.None, out newDate2);
                List<Appointment> appointmentList = _appointmentDAL.getAppointmentsBetween(newDate1, newDate2);
                List<String> final = new List<String>();
                foreach (Appointment appointment in appointmentList)
                {
                    List<String> servicesName = new List<String>();
                    float totalValue = 0.0f;
                    foreach (Services service in appointment.getServices())
                    {
                        servicesName.Add(service.getServiceName());
                        totalValue += service.getServicePrice();
                    }
                    String services = String.Join(", ", servicesName);
                    final.Add(appointment.getDate().ToString() + ", " + appointment.getClientName() + ", " + appointment.getPhoneNumber() + ", " + services + ", " + totalValue.ToString());
                }
                return final;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
