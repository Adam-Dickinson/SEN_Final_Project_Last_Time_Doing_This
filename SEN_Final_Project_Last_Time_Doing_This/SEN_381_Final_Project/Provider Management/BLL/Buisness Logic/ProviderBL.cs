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
        DataHandler_Provider provider = new DataHandler_Provider();
        public DataTable ShowAllProviders()
        {
            return provider.displayProvider();
        }

        public void updateProviders(int id, string name, string location, string address, string status)
        {
             provider.updateProvider(id, name, location, address, status);
        }

        public void deleteProvider(int id)
        {
            provider.deleteProvider(id);
        }

        public DataTable searchProvider(string name)
        {
            return provider.searchProvider(name);
        }

        public void insertProvider(int id, string name, string location, string address, string status)
        {
            provider.insertProvider(id, name, location, address, status);
        }
    }
}
