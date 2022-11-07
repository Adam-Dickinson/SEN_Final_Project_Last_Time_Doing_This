using SEN_381_Final_Project.BusinessLayer.BL;
using SEN_381_Final_Project.Call_Centre.BLL.Buisness_Object;
using SEN_381_Final_Project.Client_and_Policy_Management.Client_Management.Presentation;
using SEN_381_Final_Project.Medical_Department.Presentation;
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

namespace SEN_381_Final_Project
{
    public partial class fCall_Center : Form
    {
        public fCall_Center()
        {
            InitializeComponent();
        }

        public int Seconds;
        public int Minutes;

        private void btn_provider_Click(object sender, EventArgs e)
        {
            this.Hide();
            fProvider_Management provider = new fProvider_Management();
            provider.Show();
        }

        CallBL callBL = new CallBL();

        private void btn_medical_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMedical medical = new fMedical();
            medical.Show();
        }

        private void cb_Condition_SelectedIndexChanged(object sender, EventArgs e)
        { 

        }

        private void btn_StartCall_Click(object sender, EventArgs e)
        {
            /*dgvPolicyDetails.DataSource = provider.searchProvider(txt_Search.Text);
            txt_Search.Clear();*/

            //dgv_Client.DataSource = callBL.searchClient(int.Parse(txt_ClientID.Text));

            call_timer.Enabled = true;
            Minutes = 0;
            Seconds = 0;
        }

        private void btn_endCall_Click(object sender, EventArgs e)
        {
            //txt_ClientID.Clear();

            call_timer.Enabled = false;

            
            if (int.Parse(CallTimeMinutesLabel.Text) == 0)
            {
                MessageBox.Show("The Call Lasted For " + CallTimeMinutesLabel.Text + ":" + CallTimeSecondsLabel.Text + " Seconds");
            }
            else
            {
                MessageBox.Show("The Call Lasted For " + CallTimeMinutesLabel.Text + ":" + CallTimeSecondsLabel.Text + " Minutes");
            }

            CallTimeMinutesLabel.Text = "0";
            CallTimeSecondsLabel.Text = "00";

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

        private void dgv_Client_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = dgv_Client.Rows[e.RowIndex];
            txt_Name.Text = dgvRow.Cells[1].Value.ToString();
            txt_Surname.Text = dgvRow.Cells[2].Value.ToString();
        }

        private void btn_clientpolicy_Click(object sender, EventArgs e)
        {
            this.Hide();
            fManagment_Client management = new fManagment_Client();
            management.Show();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            this.Hide();
            fPolicy_From policy = new fPolicy_From();
            policy.Show();
        }

        private void btn_callcentre_Click(object sender, EventArgs e)
        {
            this.Hide();
            fCall_Center call = new fCall_Center();
            call.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void call_timer_Tick(object sender, EventArgs e)
        {

            string sMinutes;
            string sSeconds;

            Seconds += 1;
            if (Seconds == 60)
            {
                Seconds = 0;
                Minutes += Minutes + 1;
            }

            sMinutes = Minutes.ToString();
            sSeconds = Seconds.ToString();

            if (Seconds < 10)
            {
                sSeconds = "0" + sSeconds;
                CallTimeMinutesLabel.Text = sMinutes;
                CallTimeSecondsLabel.Text = sSeconds;
            }
            else
            {
                CallTimeMinutesLabel.Text = Minutes.ToString();
                CallTimeSecondsLabel.Text = Seconds.ToString();
            }
        }
    }
}
