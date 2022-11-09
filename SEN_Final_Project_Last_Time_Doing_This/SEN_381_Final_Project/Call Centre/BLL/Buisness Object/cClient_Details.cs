using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_381_Final_Project.BLL
{
    class cClient_Details
    {
        public cClient_Details()
        {

        }

        private int ID;
        private string Name;
        private string Surname;
        private string Condition;
        private string Treatment;
        private string Policy;

        public int ID1 { get => ID; set => ID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Surname1 { get => Surname; set => Surname = value; }
        public string Condition1 { get => Condition; set => Condition = value; }
        public string Treatment1 { get => Treatment; set => Treatment = value; }
        public string Policy1 { get => Policy; set => Policy = value; }
    }
}
