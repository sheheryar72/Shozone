using System; 
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Shopzone.Models
{
    public class ProductManager
    {
        public string ConStr = "Data Source=.;Initial Catalog=Shopzone;Integrated Security=True";
        public Product GetProductByID(int id)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConStr);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Select * from Product where id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                if (dt != null && dt.Rows.Count > 0)
                {
                    Product vm = new Product();
                    vm.id = Convert.ToInt32(dt.Rows[0]["id"]);
                    vm.title = dt.Rows[0]["title"].ToString();
                    vm.description = dt.Rows[0]["description"].ToString();
                    vm.uploadedby = dt.Rows[0]["uploadedby"].ToString();
                    vm.source = dt.Rows[0]["source"].ToString();
                    vm.price = dt.Rows[0]["price"].ToString();
                    vm.selling_price = dt.Rows[0]["selling_price"].ToString();

                    return vm;
                }
                throw new Exception("Some error occured while inserting data");
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Product> GetProductByUploader(string uploaderemail)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConStr);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from Product where uploadedby = @uploaderemail";
                cmd.Parameters.AddWithValue("@uploaderemail", uploaderemail);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                if (dt != null && dt.Rows.Count > 0)
                {
                    List<Product> lv = new List<Product>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Product vm = new Product();
                        vm.id = Convert.ToInt32(dt.Rows[i]["id"]);
                        vm.title = dt.Rows[i]["title"].ToString();
                        vm.description = dt.Rows[i]["description"].ToString();
                        vm.source = dt.Rows[i]["source"].ToString();
                        vm.uploadedat = dt.Rows[i]["uploadedat"].ToString();
                        vm.price = dt.Rows[i]["price"].ToString();
                        vm.selling_price = dt.Rows[i]["selling_price"].ToString();

                        lv.Add(vm);
                    }
                    return lv;
                }
                conn.Close();
                throw new Exception("No record in database");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Product> GetAllProduct()
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConStr);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from Product";
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                if (dt != null && dt.Rows.Count > 0)
                {
                    List<Product> lv = new List<Product>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Product vm = new Product();
                        vm.id = Convert.ToInt32(dt.Rows[i]["id"]);
                        vm.title = dt.Rows[i]["title"].ToString();
                        vm.description = dt.Rows[i]["description"].ToString();
                        vm.source = dt.Rows[i]["source"].ToString();
                        vm.uploadedat = dt.Rows[i]["uploadedat"].ToString();
                        vm.price = dt.Rows[i]["price"].ToString();
                        vm.selling_price = dt.Rows[i]["selling_price"].ToString();

                        lv.Add(vm);
                    }
                    return lv;
                }
                conn.Close();
                throw new Exception("No record in database");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Product> SearchProduct(string search1)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConStr);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from Product where title like @search1";
                cmd.Parameters.AddWithValue("@search1", search1 + "%");
                conn.Open(); 
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                if (dt != null && dt.Rows.Count > 0)
                {
                    List<Product> lv = new List<Product>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Product vm = new Product();
                        vm.id = Convert.ToInt32(dt.Rows[i]["id"]);
                        vm.title = dt.Rows[i]["title"].ToString();
                        vm.description = dt.Rows[i]["description"].ToString();
                        vm.source = dt.Rows[i]["source"].ToString();
                        vm.uploadedat = dt.Rows[i]["uploadedat"].ToString();
                        vm.price = dt.Rows[i]["price"].ToString();
                        vm.selling_price = dt.Rows[i]["selling_price"].ToString();

                        lv.Add(vm);
                    }
                    return lv;
                }
                conn.Close();
                throw new Exception("No record in database");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string UploadProductinDB(string title, string description, string source, string uploadedby, string uploadedat, string price, string selling_price)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConStr);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Insert into Product Values(@title, @description, @source, @uploadedby, @uploadedat, @price, @selling_price)";
                conn.Open();
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@source", source);
                cmd.Parameters.AddWithValue("@uploadedby", uploadedby);
                cmd.Parameters.AddWithValue("@uploadedat", uploadedat);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@selling_price", selling_price);
                int rawAffected = cmd.ExecuteNonQuery();
                if (rawAffected > 0)
                {
                    return uploadedby;
                }
                conn.Close();
                throw new Exception("Some Error occured while inserting data in db");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string UpdateProductInDB(int id, string title, string description, string source, string uploadedat, string price, string selling_price)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConStr);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Update Product set title = @title, description = @description, source = @source, uploadedat = @uploadedat, price = @price, selling_price = @selling_price where id = @id";
                conn.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@source", source);
                cmd.Parameters.AddWithValue("@uploadedat", uploadedat);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@selling_price", selling_price);
                int rawAffected = cmd.ExecuteNonQuery();
                if (rawAffected > 0)
                {
                    return uploadedat;
                }
                conn.Close();
                throw new Exception("Error occured while updating video in DB");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DeleteVideoInDB(int id)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConStr);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "delete from Product where id = @id";
                conn.Open();
                cmd.Parameters.AddWithValue("@id", id);
                int rawAffected = cmd.ExecuteNonQuery();
                if (rawAffected > 0)
                {
                    return id;
                }
                conn.Close();
                throw new Exception("Error occured while updating video in DB");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}