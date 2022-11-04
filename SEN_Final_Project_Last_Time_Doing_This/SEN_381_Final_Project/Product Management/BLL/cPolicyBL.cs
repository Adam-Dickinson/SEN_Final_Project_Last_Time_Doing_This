using SEN_381_Final_Project.Product_Management.DAL.DataHandler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_381_Final_Project.Product_Management.BLL
{
    public class cPolicyBL
    {
        DataHandler_Policy policy = new DataHandler_Policy();


        public DataTable showAllPolicys()
        {
            return policy.displayPolicy();
        }

        public void addPolicy(int id, string name, string price, string status, string level)
        {
            policy.addPolicy(id, name, price, status, level);
        }

        public void updatePolicy(int id, string name, string price, string status, string level)
        {
            policy.updatePolicy(id, name, price, status, level);
        }

        public void deletePolicy(int id)
        {
            policy.deletePolicy(id);
        }

        public DataTable searchPolicy(string name)
        {
            return policy.searchPolicy(name);
        }
    }
}
