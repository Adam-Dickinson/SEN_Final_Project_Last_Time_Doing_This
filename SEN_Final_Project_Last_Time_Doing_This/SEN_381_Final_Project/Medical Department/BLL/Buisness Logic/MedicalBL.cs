using SEN_381_Final_Project.BLL;
using SEN_381_Final_Project.BusinessLayer.BL;
using SEN_381_Final_Project.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_381_Final_Project.Medical_Department.BLL.Buisness_Object
{
    class MedicalBL
    {
        DataHandler_MedicalDepartment Condition = new DataHandler_MedicalDepartment();
        cMedical_Conditions condition = new cMedical_Conditions();
        cTreatment tratment = new cTreatment();

        public DataTable displayConditions()
        {
            return Condition.displayCondition();
        }

        public DataTable displayTreatments()
        {
            return Condition.displayTreatments();
        }

        public void insertCondition(int id, string name, string info)
        {
            condition.Id = id;
            condition.Name = name;
            condition.Information = info;

            Condition.addCondition(id, name, info);
        }

        public void insertTreatment(int id, string name, string descrip, string conName, int conID, string PName, int PID)
        {
            tratment.Id = id;
            tratment.Name = name;
            tratment.Descrip = descrip; 
            tratment.ConName = conName;
            tratment.ConID = conID;
            tratment.PName1 = PName;
            tratment.PID1 = PID;

            Condition.addTreatment(id, name, descrip, conName, conID, PName, PID);
        }

        public void insertCTP(int TID, string Tname, int CID, string CName, int PID, string PName)
        {
            Condition.addToTableCTP(TID, Tname, CID, CName, PID, PName);
        }

        public DataTable searchCondition(string name)
        {
            condition.Name = name;

            return Condition.searchCondition(name);
        }
            
        public DataTable searchTreatment(string name)
        {
            tratment.Name = name;

            return Condition.searchTreatment(name);
        }

        public void updateCondition(int id, string name, string info)
        {
            condition.Id = id;
            condition.Name = name;
            condition.Information = info;

            Condition.updateCondition(id, name, info);
        }

        public void updateTreatment(int id, string name, string descrip, string conName, int conID, string PName, int PID)
        {
            tratment.Id = id;
            tratment.Name = name;
            tratment.Descrip = descrip;
            tratment.ConName = conName;
            tratment.ConID = conID;
            tratment.PName1 = PName;
            tratment.PID1 = PID;

            Condition.updateTreatment(id, name, descrip, conName, conID, PName, PID);
        }

        public void deleteCondition(int id)
        {
            condition.Id = id;

            Condition.deleteCondition(id);
        }

        public void deleteTreatment(int id)
        {
            tratment.Id = id;

            Condition.deleteCondition(id);
        }

        public void TestUpdate(int id, string name, string info, string condition)
        {
            Condition.TestUpdateCondition(id, name, info, condition);
        }

    }
}
