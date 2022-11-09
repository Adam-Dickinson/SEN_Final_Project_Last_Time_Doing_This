using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SEN_381_Final_Project.Product_Management.DAL.DataHandler
{
    class DataHandler_Policy
    {
        public DataHandler_Policy()
        {

        }

        string conn = "Data Source=PC-MASTERRACE\\SQLEXPRESS;Initial Catalog=SEN_381_Final_Project;Integrated Security=True";

        public DataTable displayPolicy()
        {
            SqlConnection connection = new SqlConnection(conn);
            SqlDataAdapter adapter = new SqlDataAdapter("spDisplayPolicyNew", connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void addPolicy(int id, string name, string price, string status, string level, int PID, string PName)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spAddPolicy", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Policy_ID", id);
                cmd.Parameters.AddWithValue("@Policy_Name", name);
                cmd.Parameters.AddWithValue("@Policy_Price", price);
                cmd.Parameters.AddWithValue("@Policy_Status", status);
                cmd.Parameters.AddWithValue("@Policy_CoverLevel", level);
                cmd.Parameters.AddWithValue("@Provider_ID", PID);
                cmd.Parameters.AddWithValue("@Provider_Name", PName);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable searchPolicy(string name)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spSearchPolicyNew", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Policy_Name", name);

                connect.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }
        }

        public void updatePolicy(int id, string name, string price, string status, string level, int PID, string PName)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spUpdatePolicy", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Policy_ID", id);
                cmd.Parameters.AddWithValue("@Policy_Name", name);
                cmd.Parameters.AddWithValue("@Policy_Price", price);
                cmd.Parameters.AddWithValue("@Policy_Status", status);
                cmd.Parameters.AddWithValue("@Policy_CoverLevel", level);
                cmd.Parameters.AddWithValue("@Provider_ID", PID);
                cmd.Parameters.AddWithValue("@Provider_Name", PName);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void deletePolicy(int id)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spDeletePolicy", connect);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Policy_ID", id);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
