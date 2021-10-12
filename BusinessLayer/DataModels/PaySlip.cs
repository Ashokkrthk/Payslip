using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DataModels
{
   public class PaySlip : SalaryDetails
    {
      
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string UserName { get; set; }
        public DateTime DOJ { get; set; }
        public string Bank_Name { get; set; }
        public string Account_Number { get; set; }
        public string UAN_Number { get; set; }     
       
        

    }
}
