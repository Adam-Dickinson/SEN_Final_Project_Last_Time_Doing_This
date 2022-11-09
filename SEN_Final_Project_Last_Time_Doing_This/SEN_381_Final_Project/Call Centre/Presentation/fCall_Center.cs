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

        CallBL call = new CallBL();

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
            for(int i = 0; i < cb_Condition.Items.Count; i++)
            {
                if(cb_Condition.SelectedIndex == i || cb_Treatment.SelectedIndex == i)
                {
                    cb_Provider.SelectedIndex = i;
                }
            }
        }

        private void btn_StartCall_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = callBL.displayRecord(int.Parse(txt_ClientID.Text));

            dgv_Client.DataSource = callBL.searchClient(int.Parse(txt_ClientID.Text));

            call_timer.Enabled = true;
            Minutes = 0;
            Seconds = 0;

            this.groupBox2.Visible = true;
            this.groupBox3.Visible = true;
            this.btn_approve.Visible = true;
            this.btn_decline.Visible = true;
            this.btn_pending.Visible = true;
        }

        private void btn_endCall_Click(object sender, EventArgs e)
        {
            txt_ClientID.Clear();

            

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

            callBL.insertRecord(int.Parse(txt_ClientID.Text), txt_Name.Text, txt_Surname.Text, cb_Condition.Text, cb_Treatment.Text, cb_Provider.Text);

            txt_ClientID.Clear();
            txt_Name.Clear();
            txt_Surname.Clear();
        }

        private void btn_decline_Click(object sender, EventArgs e)
        {
            String message = "Claim has been declined";
            MessageBox.Show(message);

            txt_ClientID.Clear();
            txt_Name.Clear();
            txt_Surname.Clear();
        }

        private void btn_pending_Click(object sender, EventArgs e)
        {
            String message = "Claim will be pending";
            MessageBox.Show(message);

            txt_ClientID.Clear();
            txt_Name.Clear();
            txt_Surname.Clear();
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

        private void call_timer_Tick_1(object sender, EventArgs e)
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

        private void cb_Provider_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_Treatment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_Condition_Enter(object sender, EventArgs e)
        {
            cb_Condition.DataSource = call.displayClient();
            cb_Condition.DisplayMember = "Condition_Name";
        }

        private void cb_Provider_Enter(object sender, EventArgs e)
        {
            cb_Provider.DataSource = call.displayClient();
            cb_Provider.DisplayMember = "Policy_Name";
        }

        private void cb_Treatment_Enter(object sender, EventArgs e)
        {
            cb_Treatment.DataSource = call.displayClient();
            cb_Treatment.DisplayMember = "Treatment_Name";
        }

        private void fCall_Center_Load(object sender, EventArgs e)
        {
            this.groupBox2.Visible = false;
            this.groupBox3.Visible = false;
            this.btn_approve.Visible = false;
            this.btn_decline.Visible = false;
            this.btn_pending.Visible = false;
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            this.groupBox2.Visible = false;
            this.groupBox3.Visible = false;
            this.btn_approve.Visible = false;
            this.btn_decline.Visible = false;
            this.btn_pending.Visible = false;
        }
    }
}
