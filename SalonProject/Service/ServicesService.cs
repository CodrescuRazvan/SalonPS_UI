using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalonProject.BL;
using SalonProject.Model;
using System.Configuration;
using System.Reflection;

namespace SalonProject.Service
{
    class ServicesService
    {

        //private static ServicesService _servicesService = null;
        InterfaceServicesDAL _servicesDAL;
        public ServicesService()
        {
            Type obj = Type.GetType(ConfigurationManager.AppSettings["DefaultBLServices"]);
            MethodInfo method = obj.GetMethod("getInstance");
            _servicesDAL = (ServicesDAL)method.Invoke(_servicesDAL, null);

        }

        public void createServices(String serviceName, float servicePrice)
        {
            try
            {
                _servicesDAL.addServices(serviceName, servicePrice);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void updateServices(String changedName, float changePrice, String toBeChangedName, float toBeChangedPrice)
        {
            try
            {
                _servicesDAL.updateServices(changedName, changePrice, toBeChangedName, toBeChangedPrice);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void deleteServices(String serviceName)
        {
            try
            {
                _servicesDAL.deleteServices(serviceName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public List<String> viewServices()
        {
            List<Services> servicesList = new List<Services>();
            try
            {
                servicesList = _servicesDAL.viewServices();
                //Console.WriteLine(servicesList[0].getServiceName() + " " + servicesList[1].getServiceName());
                List<String> final = new List<String>();
                foreach(Services services in servicesList)
                {
                    final.Add(services.getServiceName() + ", " + services.getServicePrice().ToString());
                }
                return final;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}
