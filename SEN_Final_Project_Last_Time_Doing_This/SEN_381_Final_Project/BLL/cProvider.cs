using SEN_381_Final_Project.DAL;
using SEN_381_Final_Project.DAL.Adapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SEN_381_Final_Project.BLL
{
    class cProvider
    {
        DataAdapter adapter = new DataAdapter();

        private int company_ID;
        private string company_Name;
        private string location;
        private string address;
        private string status;

        public List<cProvider> getProvider()
        {
            List<cProvider> providers = new List<cProvider>();
            DataTable results = adapter.displayQuery("SELECT * FROM provider_details");
            
            foreach(DataRow result in results.Rows)
            {
                cProvider provider = new cProvider();
                var id = result["Company_ID"];
                var name = result["Provider_Name"];
                var location = result["_Location"];
                var address = result["_Address"];
                var status = result["_Status"];

                providers.Add(provider);
            }
            return providers;
        } 
    }
}