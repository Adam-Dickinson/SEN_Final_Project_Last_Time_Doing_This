using SEN_381_Final_Project.Client_Management.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SEN_381_Final_Project.Client_Management.BLL
{
    public class cCleintBL
    {
        DataHandler_Client client = new DataHandler_Client();
        cClient cClient = new cClient();
        cFamily cFamily = new cFamily();


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

        public void addClient(int id, string name, string surname, string age, string address, string PhoneNumber, string isFamily, int rID)
        {
            cClient.Name = name;
            cClient.Address = address;
            cClient.Surname = surname;
            cClient.Age = age;
            cClient.Id = id;
            cClient.IsFamily = isFamily; ;
            cClient.PhoneNumber = PhoneNumber;
            cClient.RID = rID;

            client.addClient(id,name, surname, age, address, PhoneNumber, isFamily, rID);
        }

        public void addFamily(int cid, int rID, string name, string surname, string phonenumber)
        {
            cFamily.Name = name; 
            cFamily.Cid = cid;
            cFamily.Surname = surname;
            cFamily.Phonenumber = phonenumber;


            client.addFamily(cid, rID, name, surname, phonenumber);
        }

        public void updateClient(int id, string name, string surname, string age, string address, string phonenumber, string isFamily, int Role)
        {
            cClient.Name = name;
            cClient.Address = address;
            cClient.Surname = surname;
            cClient.Age = age;
            cClient.Id = id;
            cClient.IsFamily = isFamily; ;
            cClient.PhoneNumber = phonenumber;
            cClient.RID = Role;

            client.updateClient(id, name, surname, age, address, phonenumber , isFamily, Role);
        }

        public void updateFamily(int cid, int rID, string name, string surname, string phonenumber)
        {
            cFamily.Name = name;
            cFamily.Cid = cid;
            cFamily.Surname = surname;
            cFamily.Phonenumber = phonenumber;

            client.updateFamily(cid, rID, name, surname, phonenumber);
        }

        public DataTable searchClient(string name)
        {
            cClient.Name = name;

            return client.searchClient(name);
        }

        public DataTable searchFamily(string surname)
        {
            cFamily.Surname = surname;

            return client.searchFamily(surname);
        }

        public void deleteClient(int id)
        {
            cClient.Id = id;

            client.deleteClient(id);
        }

        public void deleteFamily(int id)
        {
            cFamily.Id = id;
            client.deleteFamily(id);
        }
    }
}
