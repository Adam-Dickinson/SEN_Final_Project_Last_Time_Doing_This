using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEN_381_Final_Project.DAL;
using SEN_381_Final_Project.BusinessLayer;
using SEN_381_Final_Project.BLL;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Xml.Linq;

namespace SEN_381_Final_Project.BusinessLayer.BL
{
    public class ProviderBL
    {
        public DataTable ShowAllProviders()
        {
            DataHandler_Provider provider = new DataHandler_Provider();
            return provider.displayProvider();
        }

        public List<cProviderBO> UpdateProvider(int company_id, string name, string location, string address, string status)
        {
            DataHandler_Provider provider = new DataHandler_Provider();
            return provider.updateProvider(company_id, name, location, address, status);
        }
    }
}
