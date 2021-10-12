using BusinessLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class SalaryBusinessLayer
    {
        public string ConnectionString { get; set; }
        public SalaryBusinessLayer()
        {

        }
        public SalaryBusinessLayer(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public List<SalaryDetails> Details()
        {
            List<SalaryDetails> details = new List<SalaryDetails>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spGetSalary", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    SalaryDetails detail = new SalaryDetails();
                    detail.ID = Convert.ToInt32(dr["ID"]);
                    detail.BasicSalary = Convert.ToInt32(dr["BasicSalary"]);
                    detail.HouseRent_Allowances = Convert.ToDecimal(dr["HouseRent_Allowances"]);
                    detail.Conveyance_Allowances = Convert.ToDecimal(dr["Conveyance_Allowances"]);
                    detail.Medical_Allowances = Convert.ToDecimal(dr["Medical_Allowances"]);
                    detail.Special_Allowances = Convert.ToDecimal(dr["Special_Allowances"]);
                    detail.GrossSalary = Convert.ToInt32(dr["GrossSalary"]);
                    detail.EPF = Convert.ToDecimal(dr["EPF"]);
                    detail.ESI = Convert.ToDecimal(dr["ESI"]);
                    detail.ProfessionalTax = Convert.ToDecimal(dr["ProfessionalTax"]);
                    detail.TotalDeductions = Convert.ToDecimal(dr["TotalDeductions"]);
                    detail.NetPay = Convert.ToInt32(dr["NetPay"]);
                    detail.LOPDays = Convert.ToInt32(dr["LOPDays"]);
                    detail.PaidDays = Convert.ToInt32(dr["PaidDays"]);
                    detail.TotalDeductions = Convert.ToInt32(dr["TotalDeductions"]);
                    detail.Userid = Convert.ToInt32(dr["Userid"]);
                    details.Add(detail);

                }
            }
            return details;
        }
        public void AddSalaryDetails(SalaryDetails salaryObj)
        {
            try
            {

                using SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("spCreateSalary", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BasicSalary", salaryObj.BasicSalary);
                cmd.Parameters.AddWithValue("@HouseRent_Allowances", salaryObj.HouseRent_Allowances);
                cmd.Parameters.AddWithValue("@Conveyance_Allowances", salaryObj.Conveyance_Allowances);
                cmd.Parameters.AddWithValue("@Medical_Allowances", salaryObj.Medical_Allowances);
                cmd.Parameters.AddWithValue("@Special_Allowances", salaryObj.Special_Allowances);
                salaryObj.GrossSalary = Convert.ToDecimal(salaryObj.BasicSalary) + salaryObj.HouseRent_Allowances + salaryObj.Conveyance_Allowances + salaryObj.Medical_Allowances + salaryObj.Special_Allowances;
                cmd.Parameters.AddWithValue("@GrossSalary", salaryObj.GrossSalary);
                cmd.Parameters.AddWithValue("@EPF", salaryObj.EPF);
                cmd.Parameters.AddWithValue("@ESI", salaryObj.ESI);
                cmd.Parameters.AddWithValue("@ProfessionalTax", salaryObj.ProfessionalTax);
                salaryObj.TotalDeductions = salaryObj.EPF + salaryObj.ESI + salaryObj.ProfessionalTax;
                cmd.Parameters.AddWithValue("@TotalDeductions", salaryObj.TotalDeductions);
                salaryObj.NetPay = Convert.ToInt64(salaryObj.GrossSalary - salaryObj.TotalDeductions);
                cmd.Parameters.AddWithValue("@NetPay", salaryObj.NetPay);
                cmd.Parameters.AddWithValue("@LOPDays", salaryObj.LOPDays);
                cmd.Parameters.AddWithValue("@PaidDays", salaryObj.PaidDays);
                cmd.Parameters.AddWithValue("@TotalWorkingDays", salaryObj.TotalWorkingDays);
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateSalaryDetails(SalaryDetails salaryObj)
        {
            try
            {

                using SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("spUpdateSalary", con);
                cmd.CommandType = CommandType.StoredProcedure;      
                cmd.Parameters.AddWithValue("@BasicSalary", salaryObj.BasicSalary);
                cmd.Parameters.AddWithValue("@HouseRent_Allowances", salaryObj.HouseRent_Allowances);
                cmd.Parameters.AddWithValue("@Conveyance_Allowances", salaryObj.Conveyance_Allowances);
                cmd.Parameters.AddWithValue("@Medical_Allowances", salaryObj.Medical_Allowances);
                cmd.Parameters.AddWithValue("@Special_Allowances", salaryObj.Special_Allowances);
               
                cmd.Parameters.AddWithValue("@GrossSalary", salaryObj.GrossSalary);
                cmd.Parameters.AddWithValue("@EPF", salaryObj.EPF);
                cmd.Parameters.AddWithValue("@ESI", salaryObj.ESI);
                cmd.Parameters.AddWithValue("@ProfessionalTax", salaryObj.ProfessionalTax);
                cmd.Parameters.AddWithValue("@TotalDeductions", salaryObj.TotalDeductions);
                
                cmd.Parameters.AddWithValue("@LOPDays", salaryObj.LOPDays);
                cmd.Parameters.AddWithValue("@PaidDays", salaryObj.PaidDays);
                cmd.Parameters.AddWithValue("@TotalWorkingDays", salaryObj.TotalWorkingDays);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private void CalculateSalaryDetails(SalaryDetails salaryObj)
        {            
            salaryObj.GrossSalary = Convert.ToDecimal(salaryObj.BasicSalary + salaryObj.HouseRent_Allowances + salaryObj.Conveyance_Allowances + salaryObj.Medical_Allowances + salaryObj.Special_Allowances);
            salaryObj.TotalDeductions = salaryObj.EPF + salaryObj.ESI + salaryObj.ProfessionalTax;
            salaryObj.NetPay = Convert.ToInt64(salaryObj.GrossSalary - salaryObj.TotalDeductions);
        }
        public PaySlip GeneratePaySlip(int salaryId, int userId, int month, int year)
        {
            PaySlip detail = new PaySlip();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spPaySlip", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@salaryId", salaryId);
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@Month", month);
                cmd.Parameters.AddWithValue("@Year", year);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {                    
                    detail.ID = Convert.ToInt32(dr["ID"]);
                    detail.Name = Convert.ToString(dr["Name"]);
                    detail.Designation = Convert.ToString(dr["Designation"]);
                    detail.Department = Convert.ToString(dr["Department"]);
                    detail.UserName = Convert.ToString(dr["UserName"]);
                    detail.DOJ = Convert.ToDateTime(dr["DOJ"]);
                    detail.Bank_Name = Convert.ToString(dr["Bank_Name"]);
                    detail.Account_Number = Convert.ToString(dr["Account_Number"]);
                    detail.UAN_Number = Convert.ToString(dr["UAN_Number"]);
                    detail.BasicSalary = Convert.ToInt32(dr["BasicSalary"]);
                    detail.HouseRent_Allowances = Convert.ToDecimal(dr["HouseRent_Allowances"]);
                    detail.Conveyance_Allowances = Convert.ToDecimal(dr["Conveyance_Allowances"]);
                    detail.Medical_Allowances = Convert.ToDecimal(dr["Medical_Allowances"]);
                    detail.Special_Allowances = Convert.ToDecimal(dr["Special_Allowances"]);
                    detail.GrossSalary = Convert.ToInt32(dr["GrossSalary"]);
                    detail.EPF = Convert.ToDecimal(dr["EPF"]);
                    detail.ESI = Convert.ToDecimal(dr["ESI"]);
                    detail.ProfessionalTax = Convert.ToDecimal(dr["ProfessionalTax"]);
                    detail.TotalDeductions = Convert.ToDecimal(dr["TotalDeductions"]);
                    detail.NetPay = Convert.ToInt32(dr["NetPay"]);
                    detail.LOPDays = Convert.ToInt32(dr["LOPDays"]);
                    detail.PaidDays = Convert.ToInt32(dr["PaidDays"]);
                    detail.TotalDeductions = Convert.ToInt32(dr["TotalDeductions"]);
                    detail.Userid = Convert.ToInt32(dr["Userid"]);                     
                }
            }
            return detail;
        }

        public void DeleteUser(int id)
        {
            try
            {
                using SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("spDeleteSalary", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }


}
    

