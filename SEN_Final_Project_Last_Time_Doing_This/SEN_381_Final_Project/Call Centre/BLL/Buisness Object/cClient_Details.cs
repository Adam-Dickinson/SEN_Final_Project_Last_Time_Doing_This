using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_381_Final_Project.BLL
{
    class cClient_Details
    {
        public cClient_Details()
        {

        }

        private int callID;
        private int iD_Number;
        private string name;
        private string lastName;
        private string phoneNUmber;
        private string mainMember;
        private string familyPolicy;
        private string policyName;
        private DateTime joinDateOfPolicy;
        private string activePolicy;
        private string conditionStatus;
        private string medicalCondition;
        private string hospitalName;

        public cClient_Details(int callID, int iD_Number, string name, string lastName, string phoneNUmber, string mainMember, string familyPolicy, string policyName, DateTime joinDateOfPolicy, string activePolicy, string conditionStatus, string medicalCondition, string hospitalName)
        {
            CallID = callID;
            ID_Number = iD_Number;
            Name = name;
            LastName = lastName;
            PhoneNUmber = phoneNUmber;
            MainMember = mainMember;
            FamilyPolicy = familyPolicy;
            PolicyName = policyName;
            JoinDateOfPolicy = joinDateOfPolicy;
            ActivePolicy = activePolicy;
            ConditionStatus = conditionStatus;
            MedicalCondition = medicalCondition;
            HospitalName = hospitalName;
        }

        public int CallID { get => callID; set => callID = value; }
        public int ID_Number { get => iD_Number; set => iD_Number = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNUmber { get => phoneNUmber; set => phoneNUmber = value; }
        public string MainMember { get => mainMember; set => mainMember = value; }
        public string FamilyPolicy { get => familyPolicy; set => familyPolicy = value; }
        public string PolicyName { get => policyName; set => policyName = value; }
        public DateTime JoinDateOfPolicy { get => joinDateOfPolicy; set => joinDateOfPolicy = value; }
        public string ActivePolicy { get => activePolicy; set => activePolicy = value; }
        public string ConditionStatus { get => conditionStatus; set => conditionStatus = value; }
        public string MedicalCondition { get => medicalCondition; set => medicalCondition = value; }
        public string HospitalName { get => hospitalName; set => hospitalName = value; }
    }
}
