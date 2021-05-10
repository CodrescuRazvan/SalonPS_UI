using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonProject.Model
{
    public class Appointment
    {
        private DateTime _date;
        private String _clientName;
        private String _phoneNumber;
        private List<Services> _wishedServices;

        public Appointment() { }
        public Appointment(DateTime date, String clientName, String phoneNumber, List<Services> wishedServices)
        {
            _date = date;
            _clientName = clientName;
            _phoneNumber = phoneNumber;
            _wishedServices = wishedServices;
        }

        public DateTime getDate()
        {
            return _date;
        }

        public String getClientName()
        {
            return _clientName;
        }

        public String getPhoneNumber()
        {
            return _phoneNumber;
        }

        public List<Services> getServices()
        {
            return _wishedServices;
        }

    }
}
