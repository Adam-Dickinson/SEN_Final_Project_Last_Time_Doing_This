using SEN_381_Final_Project.BusinessLayer.BL;
using SEN_381_Final_Project.Call_Centre.BLL.Buisness_Object;
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
    public partial class fCall_Center : Form
    {
        public fCall_Center()
        {
            InitializeComponent();
        }

        private void btn_provider_Click(object sender, EventArgs e)
        {
            this.Hide();
            fProvider_Management provider = new fProvider_Management();
            provider.Show();
        }

        CallBL callBL = new CallBL();

        private void btn_medical_Click(object sender, EventArgs e)
        {

        }

        private void cb_Condition_SelectedIndexChanged(object sender, EventArgs e)
        { 

        }

        private void btn_StartCall_Click(object sender, EventArgs e)
        {
            /*dgvPolicyDetails.DataSource = provider.searchProvider(txt_Search.Text);
            txt_Search.Clear();*/

            dgv_Client.DataSource = callBL.searchClient(int.Parse(txt_ClientID.Text));
        }

        private void btn_endCall_Click(object sender, EventArgs e)
        {
            txt_ClientID.Clear();
        }

        private void btn_approve_Click(object sender, EventArgs e)
        {
            String message = "Claim has been approved";
            MessageBox.Show(message);
        }

        private void btn_decline_Click(object sender, EventArgs e)
        {
            String message = "Claim has been declined";
            MessageBox.Show(message);
        }
    }
}
