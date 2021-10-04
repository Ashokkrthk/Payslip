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
    public class BankBusinessLayer
    {
        public string ConnectionString { get; set; }

        public BankBusinessLayer()
        {

        }
        public BankBusinessLayer(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public List<BankDetails> Details()
        {
            List<BankDetails> details = new List<BankDetails>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spGetBankDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BankDetails detail = new BankDetails();
                    detail.ID = Convert.ToInt32(dr["ID"]);
                    detail.Userid = Convert.ToInt32(dr["Userid"]);
                    detail.Bank_Name = dr["Bank_Name"].ToString();
                    detail.Account_Number = dr["Account_Number"].ToString();
                    detail.UAN_Number = dr["UAN_Number"].ToString();
                    detail.IsActive = Convert.ToBoolean(dr["IsActive"]);
                    details.Add(detail);
                }
            }
            return details;
        }
        public void AddBankDetails(BankDetails bankObj)
        {
            try
            {
                using SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("spCreateBankDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Userid", bankObj.Userid);
                cmd.Parameters.AddWithValue("@Bank_Name", bankObj.Bank_Name);
                cmd.Parameters.AddWithValue("@Account_Number", bankObj.Account_Number);
                cmd.Parameters.AddWithValue("@UAN_Number", bankObj.UAN_Number);
                cmd.Parameters.AddWithValue("@IsActive", bankObj.IsActive);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public void EditBankDetails(BankDetails bankObj)
        {
            try
            {
                using SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("spUpdateBankDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Userid", bankObj.Userid);
                cmd.Parameters.AddWithValue("@Bank_Name", bankObj.Bank_Name);
                cmd.Parameters.AddWithValue("@Account_Number", bankObj.Account_Number);
                cmd.Parameters.AddWithValue("@UAN_Number", bankObj.UAN_Number);
                cmd.Parameters.AddWithValue("@IsActive", bankObj.IsActive);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public void DeleteUser(int id)
        {
            try
            {
                using SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("spDeleteBankDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Userid", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
