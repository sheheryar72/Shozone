using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Shopzone.Models
{
    public class UserManager
    {
        public string ConStr = "Data Source=.;Initial Catalog=Shopzone;Integrated Security=True";

        public bool SignInCheck(string email, string password)
        {
            SqlConnection conn = new SqlConnection(ConStr);
            SqlCommand cmd = conn.CreateCommand();
            try
            {
                cmd.CommandText = "Select * from [User] where email = @email and password = @password";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                conn.Open();
                IDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                if (dt != null && dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["email"].ToString() == email && dt.Rows[0]["password"].ToString() == password)
                    {
                        return true;
                    }
                    conn.Close();
                    return false;
                }
                return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }                               
        }                                   
        public string AddUserInDb(User user)
        {
            SqlConnection conn = new SqlConnection(ConStr);
            SqlCommand cmd = conn.CreateCommand();
            try
            {
                cmd.CommandText = "insert into [User] values(@name, @email, @password, @re_password)";
                conn.Open();
                cmd.Parameters.AddWithValue("@name", user.name);
                cmd.Parameters.AddWithValue("@email", user.email);
                cmd.Parameters.AddWithValue("@password", user.password);
                cmd.Parameters.AddWithValue("@re_password", user.re_password);

                int RawAffected = cmd.ExecuteNonQuery();
                if (RawAffected > 0)
                {
                    return user.email;

                }
                throw new Exception("Some error occured while inserting data");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        public string updateUserInDB(string name, string email, string password, string sessionemail)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConStr);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Update [User] set name = @name, email = @email, password = @password, re_password = @password where email = @useremail";
                conn.Open();
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@useremail", sessionemail);

                int rawAffected = cmd.ExecuteNonQuery();

                if (rawAffected > 0)
                {
                    return email;
                }
                throw new Exception("Error occured while updating data in db");
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public User showUserdata(string email)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConStr);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Select * from [User] where email = @email";
                cmd.Parameters.AddWithValue("@email", email);
                conn.Open();
                IDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                if (dt != null && dt.Rows.Count > 0)
                {
                    User um = new User();
                    um.name = dt.Rows[0]["name"].ToString();
                    um.email = dt.Rows[0]["email"].ToString();
                    um.password = dt.Rows[0]["password"].ToString();

                    return um;
                }
                conn.Close();
                throw new Exception("No Record Found");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string deleteaccount(string email)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConStr);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "delete from [User] where email = @email";
                conn.Open();
                cmd.Parameters.AddWithValue("@email", email);
                int rawAffected = cmd.ExecuteNonQuery();
                if (rawAffected > 0)
                {
                    return email;
                    conn.Close();
                }
                throw new Exception("Error occureed while delete data from DB");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // api work from here

        public List<User> GetUserList()
        {
            SqlConnection conn = new SqlConnection(ConStr);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from [User]";
            conn.Open();
            IDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            List<User> userlist = new List<User>();
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    User us = new User();
                    us.name = dt.Rows[i]["name"].ToString();
                    us.email = dt.Rows[i]["email"].ToString();

                    userlist.Add(us);
                }
                return userlist;
            }
            return null;
        }
    }
}