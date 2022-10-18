using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_381_Final_Project.BLL
{
    class cProvider
    {
        public cProvider()
        {

        }

        private int company_ID;
        private string company_Name;
        private string location;
        private string address;
        private string status;

        public cProvider(int company_ID, string company_Name, string location, string address, string status)
        {
            this.company_ID = company_ID;
            this.company_Name = company_Name;
            this.location = location;
            this.address = address;
            this.status = status;
        }

        public int Company_ID { get => company_ID; set => company_ID = value; }
        public string Company_Name { get => company_Name; set => company_Name = value; }
        public string Location { get => location; set => location = value; }
        public string Address { get => address; set => address = value; }
        public string Status { get => status; set => status = value; }
    }
}
