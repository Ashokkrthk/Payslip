using BusinessLayer;
using BusinessLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySlip.Models.Utility
{
    public class TemplateGenerator
    {
        public static string GetHTMLString(BusinessLayer.DataModels.PaySlip payslip)
        {            

            var sb = new StringBuilder();

            sb.Append("<html><head></head><body><table border='1'>");

            sb.Append("<tr height='100px' style='background-color:#777877;color:#ffffff;text-align:center;font-size:24px; font-weight:600;'>" +
                        "<td colspan = '4'>Twilight IT Solutions </td></ tr >");

            sb.Append("<tr> " +
                        "<th>Name:</th><td>"+ payslip.Name +"</td>" +
                        "<th>Total WorkingDays</th><td>"+ payslip.TotalWorkingDays+"</td>" +
                        "</tr>" +
                        //<!-----2 row--->	
                        "<tr>" +
                        "<th>ID</th><td>" + payslip.ID + "</td>" +
                        "<th>LOP Days</th><td>"+ payslip.LOPDays +"</td>" +
                        "</tr>" +
                        //<!------3 row---->
                        "<tr>" +
                        "<th>Designation</th><td>"+ payslip.Designation +"</td>" +
                        "<th>PaidDays</th><td>"+ payslip.Designation +"</td>" +
                        "</tr>" +
                        //<!------4 row---->
                        "<tr>" +
                        "<th>Department</th><td>"+ payslip.Department +"</td>" +
                        "<th>Bank Name</th><td>"+ payslip.Bank_Name +"</td>" +
                        "</tr>" +
                        //<!------5 row---->
                        "<tr>" +
                        "<th>DOJ</th><td>"+ payslip.DOJ +"</td>" +
                        "<th>Account Number</th><td>"+ payslip.Account_Number +"</td>" +
                        "</tr>" +
                        //<!------6 row---->
                        "<tr>" +
                        "<th>UAN Number</th><td>"+ payslip.UAN_Number +"</td>" +
                        "</tr>" +
                        "</table>" +
                        "<tr></tr>" +
                        "<br/>");

            sb.Append("<table border ='1'> " +
                        "<tr>" +
                        "<th>Earnings</th><th>Amount</th>" +
                        "<th>Deductions</th><th>Amount</th>" +
                        "</tr>" +
                        "<tr>" +
                        "<td>Basic Salary</td><td>"+ payslip.BasicSalary +"</td>" +
                        "<td>EPF</td><td>"+ payslip.EPF +"</td>" +
                        "</tr>" +
                        "<tr>" +
                        "<td>House Rent Allowances</td><td>"+ payslip.HouseRent_Allowances+"</td>" +
                        "<td>ESI</td><td>"+ payslip.ESI +"</td>" +
                        "</tr>" +
                        "<tr>" +
                        "<td>Conveyance Allowances</td><td>"+ payslip.BasicSalary +"</td>" +
                        "<td>Professional Tax</td><td>"+ payslip.BasicSalary +"</td>" +
                        "</tr>" +
                        "<tr>" +
                        "<td>Medical Allowances</td><td>"+ payslip.Medical_Allowances +"</td>" +
                        "<td></td>" +
                        "<td></td>" +
                        "</tr>" +
                        "<tr>" +
                        "<td>Special Allowances</td>" +
                        "<td>"+ payslip.Special_Allowances +"</td>" +
                        "<td></td>" +
                        "<td></td>" +
                        "</tr>" +
                        
                        "<tr>" +
                        "<th>Gross Salary</th><td>"+ payslip.BasicSalary+"</td>" +
                        "<th>Total Deductions</th><td>"+ payslip.TotalDeductions +"</td>" +
                        "</tr>" +
                        "<tr><td></td>" +
                        "<td><strong>NET PAY</strong></td><td>"+ payslip.NetPay +"</td>" +
                        "<td></td>" +
                        "</tr>" +
                        "</table></body></html>");

            return sb.ToString();
        }
    }
}
   