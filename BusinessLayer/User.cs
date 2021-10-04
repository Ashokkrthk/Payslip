using BusinessLayer.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class User : BankDetails
    {
        public int ID { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        [Display(Name = "User Name")]
        [Required(ErrorMessage = " User Name is Required")]
        public string UserName { get; set; }
        public string Password { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DOB { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DOJ { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime Updateddate { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string UANNumber { get; set; }
        public int PaidDays { get; set; }
        public int TotalWorkingDays { get; set; }
        public int UserType { get; set; }
    }
}
