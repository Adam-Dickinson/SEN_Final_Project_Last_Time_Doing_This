using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SEN_381_Final_Project.DAL
{
    class DataHandler_CallCentre
    {

        //Connetion Stirng 
        string conn = "Data Source=PC-MASTERRACE\\SQLEXPRESS;Initial Catalog=SEN_381_Final_Project;Integrated Security=True";

        //Making the class public
        public DataHandler_CallCentre()
        {

        }

        //Inserting Client then displaying on DGV
        public DataTable searchClient(int id)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spSearchClientCall", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Client_ID", id);

                connect.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }
        }

        //To display clients on DGV
        public DataTable displayClientsCTP()
        {
            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter adapter = new SqlDataAdapter("spDisplayCLientCTP", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        //Adds record to Call Records Table
        public void addRecord(int id, string name, string surname, string con, string treatment, string policy)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spInsertIntoCall", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Client_ID", id);
                cmd.Parameters.AddWithValue("@Client_Name", name);
                cmd.Parameters.AddWithValue("@Client_Surname", surname);
                cmd.Parameters.AddWithValue("@Condition_Name", con);
                cmd.Parameters.AddWithValue("@Treatment_Name", treatment);
                cmd.Parameters.AddWithValue("@Policy_Used", policy);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //Display all records for Call Record Table
        public DataTable displayRecord(int id)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spSeeRecords", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Client_ID", id);

                connect.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }
        }
    }
}
