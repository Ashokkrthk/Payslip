using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BusinessLayer.DataModels;

namespace BusinessLayer
{
    public class UserBusinessLayer
    {
        public string ConnectionString { get; set; }
        public UserBusinessLayer()
        {

        }
        public UserBusinessLayer(string connectionString)
        {
            ConnectionString = connectionString;
        }
        
        public List<User> Users()
        {           
                List<User> users = new List<User>();
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spUserGet", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        User user = new User();
                        user.ID = Convert.ToInt32(dr["ID"]);
                        user.Name = dr["Name"].ToString();
                        user.Designation = dr["Designation"].ToString();
                        user.Department = dr["Department"].ToString();
                        user.UserName = dr["UserName"].ToString();
                        user.DOB = Convert.ToDateTime(dr["DOB"]);
                        user.DOJ = Convert.ToDateTime(dr["DOJ"]);
                        user.CreatedDate = Convert.ToDateTime(dr["CreatedDate"]);                      
                        user.UserType = Convert.ToInt32(dr["UserType"]);
                        user.Bank_Name = dr["Bank_Name"].ToString();
                        user.Account_Number = dr["Account_Number"].ToString();
                        user.UAN_Number = dr["UAN_Number"].ToString();
                        users.Add(user);

                    }
                }
                return users;            
        }

       


        public void AddUser(User userObj)
        {
            try
            {
                using SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("spUserCreate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", userObj.ID);
                cmd.Parameters.AddWithValue("@Name", userObj.Name);
                cmd.Parameters.AddWithValue("@Designation", userObj.Designation);
                cmd.Parameters.AddWithValue("@Department", userObj.Department);            
                cmd.Parameters.AddWithValue("@UserName", userObj.UserName);
                cmd.Parameters.AddWithValue("@DOB", userObj.DOB);
                cmd.Parameters.AddWithValue("@DOJ", userObj.DOJ);
                cmd.Parameters.AddWithValue("@UserType", 2);
                cmd.Parameters.AddWithValue("@Bank_Name", userObj.Bank_Name);
                cmd.Parameters.AddWithValue("@Account_Number", userObj.Account_Number);
                cmd.Parameters.AddWithValue("@UAN_Number", userObj.UAN_Number);
                cmd.Parameters.AddWithValue("@IsActive", userObj.IsActive);
               
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User Login(string userName, string password)
        {
            User objDetails = new User();
            bool isUserExist = false;
            using SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("spUserLogin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("UserName", userName);
            cmd.Parameters.AddWithValue("Password", password);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                isUserExist = Convert.ToBoolean(dr["ResultNo"]);
            }
            if(isUserExist)
            {
                dr.NextResult();
                while (dr.Read())
                {                    
                    objDetails.ID = Convert.ToInt32(dr["ID"]);
                    objDetails.Name = dr["Name"].ToString();
                    objDetails.Department = dr["Department"].ToString();
                    objDetails.Designation = dr["Designation"].ToString();
                    objDetails.UserName = dr["UserName"].ToString();
                    objDetails.DOB = Convert.ToDateTime(dr["DOB"]);
                    objDetails.DOJ = Convert.ToDateTime(dr["DOJ"]);
                    objDetails.UserType = Convert.ToInt32(dr["UserType"]);                   
                }
            }
            return objDetails;
        }
        
        public void UpdateUser(User userObj)
        {
            try
            {
                using SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("spUserUpdate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", userObj.ID);
                cmd.Parameters.AddWithValue("@Name", userObj.Name);
                cmd.Parameters.AddWithValue("@Designation", userObj.Designation);
                cmd.Parameters.AddWithValue("@Department", userObj.Department);
                cmd.Parameters.AddWithValue("@UserName", userObj.UserName);             
                cmd.Parameters.AddWithValue("@DOB", userObj.DOB);
                cmd.Parameters.AddWithValue("@DOJ", userObj.DOJ);              
                cmd.Parameters.AddWithValue("@UserType", 2);
                cmd.Parameters.AddWithValue("@Bank_Name", userObj.Bank_Name);
                cmd.Parameters.AddWithValue("@Account_Number", userObj.Account_Number);
                cmd.Parameters.AddWithValue("@UAN_Number", userObj.UAN_Number);            
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void DeleteUser(int id)
        {
            try
            {
                using SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("spUserDelete", con);
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
