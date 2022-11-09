using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_381_Final_Project.Client_Management.BLL
{
    class cClient
    {
        public cClient()
        {

        }

        private int id;
        private string name;
        private string surname;
        private string age;
        private string address;
        private string phoneNumber;
        private string isFamily;
        private int rID;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Age { get => age; set => age = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string IsFamily { get => isFamily; set => isFamily = value; }
        public int RID { get => rID; set => rID = value; }
    }
}
