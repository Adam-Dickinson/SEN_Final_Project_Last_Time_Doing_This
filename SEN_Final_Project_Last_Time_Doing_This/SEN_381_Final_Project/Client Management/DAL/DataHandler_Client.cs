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
    }
}
