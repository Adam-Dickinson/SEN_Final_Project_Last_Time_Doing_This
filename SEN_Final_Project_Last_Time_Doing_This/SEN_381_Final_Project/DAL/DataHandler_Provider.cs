using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SEN_381_Final_Project.DAL
{
    class DataHandler_Provider
    {
        public DataHandler_Provider()
        {

        }

        string conn = "Server=(local); Initial Catalog= SEN_381_Final_Project; Integrated Security = SSPI";

        public DataTable displayProvider()
        {
            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter adapter = new SqlDataAdapter("spDisplayProviders", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void insertProvider(int id, string name, string location, string address, string status)
        {
            using (SqlConnection connect = new SqlConnection(conn)) 
            {
                SqlCommand cmd = new SqlCommand("spAddProvider", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Company_ID", id);
                cmd.Parameters.AddWithValue("@Provider_Name", name);
                cmd.Parameters.AddWithValue("@_Location", location);
                cmd.Parameters.AddWithValue("@_Address", address);
                cmd.Parameters.AddWithValue("@_Status", status);

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

        public void updateProvider(int id, string name, string location, string address, string status)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spUpdateProvider", connect);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Company_ID", id);
                cmd.Parameters.AddWithValue("@Provider_Name", name);
                cmd.Parameters.AddWithValue("@_Location", location);
                cmd.Parameters.AddWithValue("@_Address", address);
                cmd.Parameters.AddWithValue("@_Status", status);

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

                cmd.Parameters.AddWithValue("@Company_ID", id);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
