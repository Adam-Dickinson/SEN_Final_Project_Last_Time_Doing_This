using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_381_Final_Project.BLL
{
    class cMedical_Conditions
    {
        public cMedical_Conditions()
        {

        }

        private int id;
        private string name;
        private string information;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Information { get => information; set => information = value; }
    }
}
