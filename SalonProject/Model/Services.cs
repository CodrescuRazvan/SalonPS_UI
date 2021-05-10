using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonProject.Model
{
    public class Services
    {
        private String _serviceName;        
        private float _servicePrice;

        public Services() { }
        public Services(String serviceName, float servicePrice)
        {
            _serviceName = serviceName;
            _servicePrice = servicePrice;
        }

        public String getServiceName()
        {
            return _serviceName;
        }

        public float getServicePrice()
        {
            return _servicePrice;
        }

        public void setServiceName(String serviceName)
        {
            _serviceName = serviceName;
        }

        public void setServicePrice(float servicePrice)
        {
            _servicePrice = servicePrice;
        }
    }
}
