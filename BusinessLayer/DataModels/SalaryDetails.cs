using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DataModels
{
   public class SalaryDetails
    {
        public int ID { get; set; }
        public long BasicSalary { get; set; }
        public decimal HouseRent_Allowances { get; set; }
        public decimal Conveyance_Allowances { get; set; }
        public decimal Medical_Allowances { get; set; }
        public decimal Special_Allowances { get; set; }
        public decimal GrossSalary { get; set; }
        public decimal EPF { get; set; }
        public decimal ESI { get; set; }
        public decimal ProfessionalTax { get; set; }
        public decimal TotalDeductions { get; set; }
        public long NetPay { get; set; }
        public int LOPDays { get; set; }
        public int PaidDays { get; set; }
        public int TotalWorkingDays { get; set; }


    }
}
