using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_381_Final_Project.Client_Management.DAL
{
    class DataHandler_Client
    {
        string conn = "Data Source=PC-MASTERRACE\\SQLEXPRESS;Initial Catalog=SEN_381_Final_Project;Integrated Security=True";

        public DataHandler_Client()
        {

        }

        public DataTable displayClients()
        {
            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter adapter = new SqlDataAdapter("spDisplayClientNew", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void addClient(int id, string name, string surname, DateTime DOB, string address, string PhoneNumber, string isFamily, int pID, string pName)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spAddClient", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Client_ID", id);
                cmd.Parameters.AddWithValue("@Client_Name", name);
                cmd.Parameters.AddWithValue("@Client_Surname", surname);
                cmd.Parameters.AddWithValue("@Client_DOB", DOB);
                cmd.Parameters.AddWithValue("@Client_Address", address);
                cmd.Parameters.AddWithValue("@Client_PhoneNumber", PhoneNumber);
                cmd.Parameters.AddWithValue("@Client_IsFamily", isFamily);
                cmd.Parameters.AddWithValue("@Policy_ID", pID);
                cmd.Parameters.AddWithValue("@Policy_Type", pName);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void updateClient(int id, string name, string surname, DateTime DOB, string address, string PhoneNumber, string isFamily, int pID, string pName)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spUpdateClientNew", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Client_ID", id);
                cmd.Parameters.AddWithValue("@Client_Name", name);
                cmd.Parameters.AddWithValue("@Client_Surname", surname);
                cmd.Parameters.AddWithValue("@Client_DOB", DOB);
                cmd.Parameters.AddWithValue("@Client_Address", address);
                cmd.Parameters.AddWithValue("@Client_PhoneNumber", PhoneNumber);
                cmd.Parameters.AddWithValue("@Client_IsFamily", isFamily);
                cmd.Parameters.AddWithValue("@Policy_ID", pID);
                cmd.Parameters.AddWithValue("@Policy_Type", pName);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable searchClient(string name)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spSearchClient", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Client_Name", name);

                connect.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                    return dt;
                }
            }
        }

        public void deleteClient(int id)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spDeleteClient", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Client_ID", id);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
