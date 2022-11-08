using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public DataTable displayRoles()
        {
            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter adapter = new SqlDataAdapter("showRoles", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable displayFamily()
        {
            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter adapter = new SqlDataAdapter("spDisplayFamily", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void addClient(int id, string name, string surname, string age, string address, string PhoneNumber, string isFamily, int rID)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spAddddClient", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Client_ID", id);
                cmd.Parameters.AddWithValue("@Client_Name", name);
                cmd.Parameters.AddWithValue("@Client_Surname", surname);
                cmd.Parameters.AddWithValue("@Client_Age", age);
                cmd.Parameters.AddWithValue("@Client_Address", address);
                cmd.Parameters.AddWithValue("@Client_PhoneNumber", PhoneNumber);
                cmd.Parameters.AddWithValue("@Client_IsFamily", isFamily);
                cmd.Parameters.AddWithValue("@Role_ID", rID);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void addFamily(int cid, int rID, string name, string surname, string phonenumber)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spAddFamily", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Client_ID", cid);
                cmd.Parameters.AddWithValue("@Role_ID", rID);
                cmd.Parameters.AddWithValue("@Member_Name", name);
                cmd.Parameters.AddWithValue("@Member_Surname", surname);
                cmd.Parameters.AddWithValue("@Member_PhoneNumber", phonenumber);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void updateClient(int id, string name, string surname, string age, string address, string PhoneNumber, string isFamily, int rID)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spUpdateClientsNew", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Client_ID", id);
                cmd.Parameters.AddWithValue("@Client_Name", name);
                cmd.Parameters.AddWithValue("@Client_Surname", surname);
                cmd.Parameters.AddWithValue("@Client_Age", age);
                cmd.Parameters.AddWithValue("@Client_Address", address);
                cmd.Parameters.AddWithValue("@Client_PhoneNumber", PhoneNumber);
                cmd.Parameters.AddWithValue("@Client_IsFamily", isFamily);
                cmd.Parameters.AddWithValue("@Role_ID", rID);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void updateFamily(int cid, int rID, string name, string surname, string phonenumber)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spUpdateFamily", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Client_ID", cid);
                cmd.Parameters.AddWithValue("@Role_ID", rID);
                cmd.Parameters.AddWithValue("@Member_Name", name);
                cmd.Parameters.AddWithValue("@Member_Surname", surname);
                cmd.Parameters.AddWithValue("@Member_PhoneNumber", phonenumber);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable searchClient(string name)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spSearchClients", connect);
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

        public void deleteFamily(int id)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spDeleteFamily", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Client_ID", id);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable searchFamily(string surname)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spSearchFamily", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Member_Surname", surname);

                connect.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                    return dt;
                }
            }
        }
    }
}
