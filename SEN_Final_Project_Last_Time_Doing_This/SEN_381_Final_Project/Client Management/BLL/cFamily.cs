using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_381_Final_Project.Client_Management.BLL
{
    class cFamily : cClient
    {
        public cFamily()
        {

        }

        private int cid;
        private int rID;
        private string name;
        private string surname;
        private string phonenumber;

        public int Cid { get => cid; set => cid = value; }
        public int RID { get => rID; set => rID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
    }
}
