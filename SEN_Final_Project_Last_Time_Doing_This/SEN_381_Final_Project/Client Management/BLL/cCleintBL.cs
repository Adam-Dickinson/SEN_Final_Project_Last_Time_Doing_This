using SEN_381_Final_Project.Client_Management.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_381_Final_Project.Client_Management.BLL
{
    class cCleintBL
    {
        DataHandler_Client client = new DataHandler_Client();

        public cCleintBL()
        {

        }

        public DataTable displayClient()
        {
            return client.displayClients();
        }
    }
}
