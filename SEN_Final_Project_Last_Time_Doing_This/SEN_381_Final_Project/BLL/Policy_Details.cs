using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_381_Final_Project.BLL
{
    class Policy_Details
    {
        public Policy_Details()
        {

        }

        private int policy_iD;
        private string policy_name;
        private string description;
        private string levelOfCover;
        private int MonthlyRate;
        private string coveredTreatments;

        public Policy_Details(int policy_iD, string policy_name, string description, string levelOfCover, int monthlyRate, string coveredTreatments)
        {
            this.Policy_iD = policy_iD;
            this.Policy_name = policy_name;
            this.Description = description;
            this.LevelOfCover = levelOfCover;
            this.MonthlyRate1 = monthlyRate;
            this.CoveredTreatments = coveredTreatments;
        }

        public int Policy_iD { get => policy_iD; set => policy_iD = value; }
        public string Policy_name { get => policy_name; set => policy_name = value; }
        public string Description { get => description; set => description = value; }
        public string LevelOfCover { get => levelOfCover; set => levelOfCover = value; }
        public int MonthlyRate1 { get => MonthlyRate; set => MonthlyRate = value; }
        public string CoveredTreatments { get => coveredTreatments; set => coveredTreatments = value; }
    }
