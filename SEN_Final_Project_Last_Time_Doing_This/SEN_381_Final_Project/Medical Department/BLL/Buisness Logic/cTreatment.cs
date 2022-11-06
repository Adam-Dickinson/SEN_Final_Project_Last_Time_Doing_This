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
        private int condition_id;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int Condition_ID { get => condition_id; set => condition_id = value; }
    }
}
