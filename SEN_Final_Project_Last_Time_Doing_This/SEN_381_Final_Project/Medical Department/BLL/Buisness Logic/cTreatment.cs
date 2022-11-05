using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_381_Final_Project.Medical_Department.BLL.Buisness_Object
{
    class cTreatment
    {
        public cTreatment()
        {

        }

        private int id;
        private string name;
        private string description;
        private string medical_condition;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Medical_condition { get => medical_condition; set => medical_condition = value; }
    }
}
