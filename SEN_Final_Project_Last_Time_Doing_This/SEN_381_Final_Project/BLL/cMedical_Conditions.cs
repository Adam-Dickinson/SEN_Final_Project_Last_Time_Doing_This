using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_381_Final_Project.BLL
{
    class cMedical_Conditions
    {
        public cMedical_Conditions()
        {

        }

        private int conditionID;
        private string conditionName;
        private string description;
        private string treatment;
        private string providerName;

        public cMedical_Conditions(int conditionID, string conditionName, string description, string treatment, string providerName)
        {
            ConditionID = conditionID;
            ConditionName = conditionName;
            Description = description;
            Treatment = treatment;
            ProviderName = providerName;
        }

        public int ConditionID { get => conditionID; set => conditionID = value; }
        public string ConditionName { get => conditionName; set => conditionName = value; }
        public string Description { get => description; set => description = value; }
        public string Treatment { get => treatment; set => treatment = value; }
        public string ProviderName { get => providerName; set => providerName = value; }
    }
}
