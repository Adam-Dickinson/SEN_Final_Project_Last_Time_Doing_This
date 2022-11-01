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
        string conn = "Data Source=PC-MASTERRACE\\SQLEXPRESS;Initial Catalog=SEN_381_Final_Project;Integrated Security=True";

        public DataHandler_CallCentre()
        {

        }

        public DataTable searchClient(int id)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spSearchClient", connect);
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
