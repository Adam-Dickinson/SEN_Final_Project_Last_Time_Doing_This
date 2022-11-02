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

        public DataTable displayConditions()
        {
            return Condition.displayCondition();
        }

        public void insertCondition(int id, string name, string info)
        {
            Condition.addCondition(id, name, info);
        }

        public void insertTreatment(int id, string name, string descrip, string Cname)
        {
            Condition.addTreatment(id, name, descrip, Cname);
        }

        public DataTable displayTreatments()
        {
            return Condition.displayTreatments();
        }
    }
}
