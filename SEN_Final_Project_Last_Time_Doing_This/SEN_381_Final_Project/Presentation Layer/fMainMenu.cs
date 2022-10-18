using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN_381_Final_Project
{
    public partial class fMainMenu : Form
    {
        public fMainMenu()
        {
            InitializeComponent();
        }

        private void btn_callCenter_Click(object sender, EventArgs e)
        {
            this.Hide();
            var CallCenter = new fCall_Center();
            CallCenter.Show();
        }

        private void btn_clientAndpolicyManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ClientPolicy = new fClient_And_Policy_Management();
            ClientPolicy.Show();
        }

        private void btn_productMaintenance_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ProductMaintenance = new fProduct_Maintenance();
            ProductMaintenance.Show();
        }

        private void btn_medicalDepartment_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MedicalDepartment = new fMedical_Department();
            MedicalDepartment.Show();
        }

        private void btn_providerManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ProviderManagement = new fProvider_Management();
            ProviderManagement.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
