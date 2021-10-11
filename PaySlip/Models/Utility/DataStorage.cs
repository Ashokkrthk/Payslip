using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaySlip.Models.Utility
{
    public class DataStorage
    {
        public static List<User> GetAllEmployees() =>
         new List<User>
         {
                //new Employee { Name="Mike", LastName="Turner", Age=35, Gender="Male"},
                //new Employee { Name="Sonja", LastName="Markus", Age=22, Gender="Female"},
                //new Employee { Name="Luck", LastName="Martins", Age=40, Gender="Male"},
                //new Employee { Name="Sofia", LastName="Packner", Age=30, Gender="Female"},
                //new Employee { Name="John", LastName="Doe", Age=45, Gender="Male"}
         };
    }
}
