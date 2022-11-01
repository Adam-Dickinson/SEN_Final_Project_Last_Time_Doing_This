using SEN_381_Final_Project.BusinessLayer.BL;
using SEN_381_Final_Project.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_381_Final_Project.Call_Centre.BLL.Buisness_Object
{
    class CallBL
    {
        DataHandler_CallCentre CallCentre = new DataHandler_CallCentre();

        public DataTable searchClient(int id)
        {
            return CallCentre.searchClient(id);
        }

    }
}
