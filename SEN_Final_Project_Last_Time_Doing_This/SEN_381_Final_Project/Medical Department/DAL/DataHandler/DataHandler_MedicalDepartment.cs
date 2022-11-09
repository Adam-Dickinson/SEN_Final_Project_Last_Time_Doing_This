using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Security.Cryptography;

namespace SEN_381_Final_Project.DAL
{
    class DataHandler_MedicalDepartment
    {
        string conn = "Data Source=PC-MASTERRACE\\SQLEXPRESS;Initial Catalog=SEN_381_Final_Project;Integrated Security=True";

        public DataHandler_MedicalDepartment()
        {

        }

        public DataTable displayCondition()
        {
            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter adapter = new SqlDataAdapter("spDisplayCondition", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable displayTreatments()
        {
            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter adapter = new SqlDataAdapter("spDisplayTreatment", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void addCondition(int id, string name, string info)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spAddCondition", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Condition_ID", id);
                cmd.Parameters.AddWithValue("@Condition_Name", name);
                cmd.Parameters.AddWithValue("@Information", info);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void addTreatment(int id, string name, string descrip,string conName, int conID, string PName, int PID)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spAddTreatments", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Treatment_ID", id);
                cmd.Parameters.AddWithValue("@Treatment_Name", name);
                cmd.Parameters.AddWithValue("@Treatment_Description", descrip);
                cmd.Parameters.AddWithValue("@Condition_Name", conName);
                cmd.Parameters.AddWithValue("@Condition_ID", conID);
                cmd.Parameters.AddWithValue("@Policy_Name", PName);
                cmd.Parameters.AddWithValue("@Policy_ID", PID);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable searchTreatment(string name)
        {
            using(SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spSearchTreatments", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Treatment_Name", name);

                connect.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                    return dt;
                }
            }
        }

        public DataTable searchCondition(string name)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spSearchCondition", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Condition_Name", name);

                connect.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                    return dt;
                }
            }
        }

        public void updateTreatment(int id, string name, string descrip,string conName, int conID, string PName, int PID)
        {
            using(SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spUpdateTreatments", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Treatment_ID", id);
                cmd.Parameters.AddWithValue("@Treatment_Name", name);
                cmd.Parameters.AddWithValue("@Treatment_Desc", descrip);
                cmd.Parameters.AddWithValue("@Condition_Name", conName);
                cmd.Parameters.AddWithValue("@Condition_ID", conID);
                cmd.Parameters.AddWithValue("@Policy_Name", PName);
                cmd.Parameters.AddWithValue("@Policy_ID", PID);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void updateCondition(int id, string name, string info)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spUpdateConditions", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Condition_ID", id);
                cmd.Parameters.AddWithValue("@Condition_Name", name);
                cmd.Parameters.AddWithValue("@Condition_Information", info);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void deleteTreatment(int id)
        {
            using(SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spDeleteTreatment", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("Treatment_ID", id);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void deleteCondition(int id)
        {
            using(SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spDeleteCondition", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Condition_ID", id);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void TestUpdateCondition(int id, string name, string info, string condition)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spTest", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Condition_ID", id);
                cmd.Parameters.AddWithValue("@Condition_Name", name);
                cmd.Parameters.AddWithValue("@Condition_Information", info);
                cmd.Parameters.AddWithValue("@Treatment_ConditionName", condition);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void addToTableCTP(int TID, string Tname, int CID, string CName, int PID, string PName)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spAddCallDetailsCTP", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Treatment_ID", TID);
                cmd.Parameters.AddWithValue("@Treatment_Name", Tname);
                cmd.Parameters.AddWithValue("@Condition_ID", CID);
                cmd.Parameters.AddWithValue("@Condition_Name", CName);
                cmd.Parameters.AddWithValue("@Policy_ID", PID);
                cmd.Parameters.AddWithValue("@Policy_Name", PName);


                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

}

