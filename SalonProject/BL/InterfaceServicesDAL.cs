using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalonProject.Model;

namespace SalonProject.BL
{
    public interface InterfaceServicesDAL
    {

        Services getServices(String serviceName);

        void addServices(String serviceName, float servicePrice);

        void updateServices(String serviceName, float servicePrice, String serviceName2, float servicePrice2);

        void deleteServices(String serviceName);


        List<Services> viewServices();
        }
}
