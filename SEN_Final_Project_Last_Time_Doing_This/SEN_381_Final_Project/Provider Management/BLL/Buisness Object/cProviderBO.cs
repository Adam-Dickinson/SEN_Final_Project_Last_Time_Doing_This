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

        public int Company_ID
        {
            get; set;
        }
        public string Company_Name
        {
            get; set;
        }
        public string Location
        {
            get; set;
        }
        public string Address
        {
            get; set;
        }
        public string Status
        {
            get; set;
        }
        
    } 
}