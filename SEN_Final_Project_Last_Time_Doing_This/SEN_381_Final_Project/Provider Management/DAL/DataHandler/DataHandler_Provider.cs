using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SEN_381_Final_Project.BLL;

namespace SEN_381_Final_Project.DAL
{
    class DataHandler_Provider
    {

        string conn = "Data Source=PC-MASTERRACE\\SQLEXPRESS;Initial Catalog=SEN_381_Final_Project;Integrated Security=True";

        public DataHandler_Provider()
        {

        }

        public DataTable displayProvider()
        {
            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter adapter = new SqlDataAdapter("spDisplayProvider", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void insertProvider(int id, string name, string address, string email, string phoneNumber, string status)
        {
            using (SqlConnection connect = new SqlConnection(conn)) 
            {
                SqlCommand cmd = new SqlCommand("spAddProvider", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Provider_ID", id);
                cmd.Parameters.AddWithValue("@Provider_Name", name);
                cmd.Parameters.AddWithValue("@Provider_Address", address);
                cmd.Parameters.AddWithValue("@Provider_Email", email);
                cmd.Parameters.AddWithValue("@Provider_PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@Provider_Status", status);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable searchProvider(string name)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spSearchProvider", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Provider_Name", name);

                connect.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }
        }

        public void updateProvider(int id, string name, string address, string email, string phoneNumber, string status)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spUpdateProvider", connect);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Provider_ID", id);
                cmd.Parameters.AddWithValue("@Provider_Name", name);
                cmd.Parameters.AddWithValue("@Provider_Address", address);
                cmd.Parameters.AddWithValue("@Provider_Email", email);
                cmd.Parameters.AddWithValue("@Provider_PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@Provider_Status", status);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void deleteProvider(int id)
        {
            using(SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spDeleteProvider", connect);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Provider_ID", id);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
