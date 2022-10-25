using SEN_381_Final_Project.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SEN_381_Final_Project.BLL
{
    public class cProviderBO
    {
        private int company_ID;
        private string company_Name;
        private string location;
        private string address;
        private string status;

       
        public int Company_ID { get => company_ID; set => company_ID = value; }
        public string Company_Name { get => company_Name; set => company_Name = value; }
        public string Location { get => location; set => location = value; }
        public string Address { get => address; set => address = value; }
        public string Status { get => status; set => status = value; }
    } 
}