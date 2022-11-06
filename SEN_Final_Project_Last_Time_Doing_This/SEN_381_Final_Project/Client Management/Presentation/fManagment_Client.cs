using SEN_381_Final_Project.Client_Management.BLL;
using SEN_381_Final_Project.Medical_Department.Presentation;
using SEN_381_Final_Project.Product_Management.BLL;
using SEN_381_Final_Project.Product_Management.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN_381_Final_Project.Client_and_Policy_Management.Client_Management.Presentation
{
    public partial class fManagment_Client : Form
    {
        public fManagment_Client()
        {
            InitializeComponent();
        }

        cCleintBL client = new cCleintBL();
        cPolicyBL Policy = new cPolicyBL();

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_callcentre_Click(object sender, EventArgs e)
        {
            this.Hide();
            fCall_Center CallCenter = new fCall_Center();
            CallCenter.Show();
        }

        private void btn_medical_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMedical medical = new fMedical();
            medical.Show();
        }

        private void btn_clientpolicy_Click(object sender, EventArgs e)
        {
            this.Hide();
            fManagment_Client client = new fManagment_Client();
            client.Show();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            this.Hide();
            fPolicy_From policy = new fPolicy_From();
            policy.Show();
        }

        private void btn_provider_Click(object sender, EventArgs e)
        {
            this.Hide();
            fProvider_Management provider = new fProvider_Management();
            provider.Show();
        }

        private void fManagment_Client_Load(object sender, EventArgs e)
        {
            dgv_Client.DataSource = client.displayClient();
            cb_CPolicy.Text = "Select a Policy";
        }

        private void cb_CPolicy_Enter(object sender, EventArgs e)
        {
            if(cb_CPolicy.Text == "Select a Policy")
            {
                cb_CPolicy.DataSource = Policy.showAllPolicys();
                cb_CPolicy.DisplayMember = "Policy_Name";
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            dgv_Client.DataSource = client.displayClient();

            txt_CAddress.Clear();
            txt_CID.Clear();
            txt_CName.Clear();
            txt_CPhoneNumber.Clear();
            txt_CSearch.Clear();
            txt_CSurname.Clear();
            cb_CFamily.SelectedIndex = -1;
            cb_CPolicy.Text = "Select a Policy";
        }

        private void btn_CSearch_Click(object sender, EventArgs e)
        {
            dgv_Client.DataSource = client.searchClient(txt_CSearch.Text);

            txt_CAddress.Clear();
            txt_CID.Clear();
            txt_CName.Clear();
            txt_CPhoneNumber.Clear();
            txt_CSearch.Clear();
            txt_CSurname.Clear();
            cb_CFamily.SelectedIndex = -1;
            cb_CPolicy.Text = "Select a Policy";
        }

        private void btn_CAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_CUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btn_CDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
