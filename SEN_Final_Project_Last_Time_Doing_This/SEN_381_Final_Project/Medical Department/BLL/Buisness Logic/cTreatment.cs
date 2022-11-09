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
        private string descrip;
        private string conName;
        private int conID;
        private string PName;
        private int PID;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Descrip { get => descrip; set => descrip = value; }
        public string ConName { get => conName; set => conName = value; }
        public int ConID { get => conID; set => conID = value; }
        public string PName1 { get => PName; set => PName = value; }
        public int PID1 { get => PID; set => PID = value; }
    }
}
