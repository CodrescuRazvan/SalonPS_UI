using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalonProject.Model;

namespace SalonProject.BL
{
    public interface InterfaceAppointmentDAL
    {
        void createAppointment(DateTime date, String clientName, String phoneNumber, List<Services> services);

        List<Appointment> viewAppointmentsClient(String clientName);
        List<Appointment> viewAppointments(DateTime date);

        List<Appointment> viewAppointmentsSameDate(DateTime date);

        List<Appointment> getAppointmentsBetween(DateTime date1, DateTime date2);
    }
}
