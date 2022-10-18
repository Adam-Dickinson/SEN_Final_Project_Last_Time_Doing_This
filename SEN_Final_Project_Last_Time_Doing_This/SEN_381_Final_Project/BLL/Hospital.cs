using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_381_Final_Project.BLL
{
    class Hospital
    {
        public Hospital()
        {

        }

        private int hospitalID;
        private string hospitalName;
        private string hospitalLocation;
        private string contactDetails;
        private string listOfTreatments;

        public Hospital(int hospitalID, string hospitalName, string hospitalLocation, string contactDetails, string listOfTreatments)
        {
            this.hospitalID = hospitalID;
            this.hospitalName = hospitalName;
            this.hospitalLocation = hospitalLocation;
            this.contactDetails = contactDetails;
            this.listOfTreatments = listOfTreatments;
        }

        public int HospitalID { get => hospitalID; set => hospitalID = value; }
        public string HospitalName { get => hospitalName; set => hospitalName = value; }
        public string HospitalLocation { get => hospitalLocation; set => hospitalLocation = value; }
        public string ContactDetails { get => contactDetails; set => contactDetails = value; }
        public string ListOfTreatments { get => listOfTreatments; set => listOfTreatments = value; }
    }
}
