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

        public void addClient(int id, string name, string surname, DateTime DOB, string address, string PhoneNumber, string isFamily, int pID, string pName)
        {
            client.addClient(id,name, surname, DOB, address, PhoneNumber, isFamily, pID, pName);
        }

        public void updateClient(int id, string name, string surname, DateTime DOB, string address, string PhoneNumber, string isFamily, int pID, string pName)
        {
            client.updateClient(id, name, surname, DOB, address, PhoneNumber, isFamily, pID, pName);
        }

        public DataTable searchClient(string name)
        {
            return client.searchClient(name);
        }

        public void deleteClient(int id)
        {
            client.deleteClient(id);
        }
    }
}
