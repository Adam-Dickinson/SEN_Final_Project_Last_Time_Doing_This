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

        public void addTreatment(int id, string name, string descrip, string Cname)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spAddTreatment", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Treatment_ID", id);
                cmd.Parameters.AddWithValue("@Treatment_Name", name);
                cmd.Parameters.AddWithValue("@Treatment_Description", descrip);
                cmd.Parameters.AddWithValue("@Medical_Condition", Cname);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable displayTreatments()
        {
            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter adapter = new SqlDataAdapter("spDisplayTreatments", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }

}

