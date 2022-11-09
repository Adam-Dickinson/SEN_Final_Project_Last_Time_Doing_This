using SEN_381_Final_Project.BLL;
using SEN_381_Final_Project.BusinessLayer.BL;
using SEN_381_Final_Project.Client_Management.BLL;
using SEN_381_Final_Project.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_381_Final_Project.Call_Centre.BLL.Buisness_Object
{
    class CallBL : cClient_Details
    {
        DataHandler_CallCentre CallCentre = new DataHandler_CallCentre();
        cClient_Details cClient_Details = new cClient_Details();

        // These methods below are the link between the DAl and the presentation layer

        public DataTable searchClient(int id)
        {
            cClient_Details.ID1 = id;

            return CallCentre.searchClient(id);
        }

        public DataTable displayClient()
        {
            return CallCentre.displayClientsCTP();
        }

        public void insertRecord(int id, string name, string surname, string con, string treatment, string policy)
        {
            cClient_Details.ID1 = id;
            cClient_Details.Name1 = name;
            cClient_Details.Surname1 = surname;
            cClient_Details.Condition1 = con;
            cClient_Details.Treatment1 = treatment;
            cClient_Details.Policy1 = policy;

            CallCentre.addRecord(id, name, surname, con, treatment, policy);
        }

        public DataTable displayRecord(int id)
        {
            cClient_Details.ID1 = id;

            return CallCentre.displayRecord(id);
        }
    }
}
