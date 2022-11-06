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

        public void insertTreatment(int id, string name, string descrip, int conID)
        {
            tratment.Id = id;
            tratment.Name = name;
            tratment.Description = descrip;
            tratment.Condition_ID = conID;

            Condition.addTreatment(id, name, descrip, conID);
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

        public void updateTreatment(int id, string name, string descrip, int conID)
        {
            tratment.Id = id;
            tratment.Name = name;
            tratment.Description = descrip;
            tratment.Condition_ID = conID;

            Condition.updateTreatment(id, name, descrip, conID);
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
