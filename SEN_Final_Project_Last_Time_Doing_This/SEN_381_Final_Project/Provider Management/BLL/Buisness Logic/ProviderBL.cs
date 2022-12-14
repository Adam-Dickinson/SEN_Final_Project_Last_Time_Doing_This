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
    public class ProviderBL : cProviderBO
    {
        DataHandler_Provider provider = new DataHandler_Provider();
        cProviderBO providerBO = new cProviderBO();
        public DataTable ShowAllProviders()
        {
            return provider.displayProvider();
        }

        public void updateProviders(int id,string name, string address, string email, string phoneNumber, string status)
        {

             providerBO.Provider_name = name;
             providerBO.Provider_address = address;
             providerBO.Provider_email = email;
             providerBO.Provider_Status = status;
             provider.updateProvider(id, name, address, email, phoneNumber, status);
        }

        public void updateProviderToPolicy(int id, string name)
        {

            providerBO.Provider_name = name;
            provider.spUPDATEPOlicyFROMProvider(id, name);
        }

        public void deleteProvider(int id)
        {         
            provider.deleteProvider(id);         
        }

        public DataTable searchProvider(string name)
        {
            return provider.searchProvider(name);
        }

        public void insertProvider(int id, string name, string address, string email, string phoneNumber, string status)
        {
            provider.insertProvider(id, name, address,email, phoneNumber, status);
        }

    }
}
