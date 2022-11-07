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

        public DataTable displayRoles()
        {
            return client.displayRoles();
        }

        public DataTable displayFamily()
        {
            return client.displayFamily();
        }

        public void addClient(int id, string name, string surname, string age, string address, string PhoneNumber, string isFamily, int rID,int pID, string pName)
        {
            client.addClient(id,name, surname, age, address, PhoneNumber, isFamily, rID, pID, pName);
        }

        public void addFamily(int cid, int rID, string name, string surname, string phonenumber)
        {
            client.addFamily(cid, rID, name, surname, phonenumber);
        }

        public void updateClient(int id, string name, string surname, string age, string address, string PhoneNumber, string isFamily, int rID, int pID, string pName)
        {
            client.updateClient(id, name, surname, age, address, PhoneNumber, isFamily, rID, pID, pName);
        }

        public void updateFamily(int cid, int rID, string name, string surname, string phonenumber)
        {
            client.updateFamily(cid, rID, name, surname, phonenumber);
        }

        public DataTable searchClient(string name)
        {
            return client.searchClient(name);
        }

        public DataTable searchFamily(string surname)
        {
            return client.searchFamily(surname);
        }

        public void deleteClient(int id)
        {
            client.deleteClient(id);
        }

        public void deleteFamily(int id)
        {
            client.deleteFamily(id);
        }
    }
}
