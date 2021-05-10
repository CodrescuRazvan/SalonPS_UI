using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalonProject.Model;

namespace SalonProject.BL
{
    interface InterfaceUserDAL
    {
        User getUser(String username, String password);

        void addEmployee(String name, String username, String password);
    }
}
