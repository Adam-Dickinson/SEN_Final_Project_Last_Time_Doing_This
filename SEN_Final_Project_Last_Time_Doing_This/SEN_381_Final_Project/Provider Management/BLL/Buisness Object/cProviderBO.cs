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
        private int provider_id;
        private string provider_name;
        private string provider_address;
        private string provider_email;
        private string provider_phoneNumber;
        private string provider_status;

        public int Provider_id { get => provider_id; set => provider_id = value; }
        public string Provider_name { get => provider_name; set => provider_name = value; }
        public string Provider_address { get => provider_address; set => provider_address = value; }
        public string Provider_email { get => provider_email; set => provider_email = value; }
        public string Provider_phoneNumber { get => provider_phoneNumber; set => provider_phoneNumber = value; }
        public string Provider_Status { get => provider_status; set => provider_status = value; }
    } 
}