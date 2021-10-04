using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DataModels
{
   public class BankDetails
    {
        public int ID { get; set; }
        public int Userid { get; set; }
        public string Bank_Name { get; set; }
        public string Account_Number { get; set; }
        public string UAN_Number { get; set; }
        public bool IsActive { get; set; }
    }
}
