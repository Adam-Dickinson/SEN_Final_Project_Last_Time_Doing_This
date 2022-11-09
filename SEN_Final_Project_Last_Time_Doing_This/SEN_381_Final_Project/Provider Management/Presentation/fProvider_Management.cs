using SEN_381_Final_Project.BLL;
using SEN_381_Final_Project.BusinessLayer.BL;
using SEN_381_Final_Project.Client_and_Policy_Management.Client_Management.Presentation;
using SEN_381_Final_Project.DAL;
using SEN_381_Final_Project.Medical_Department.Presentation;
using SEN_381_Final_Project.Product_Management.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SEN_381_Final_Project
{
    public partial class fProvider_Management : Form
    {
        public fProvider_Management()
        {
            InitializeComponent();
        }

        ProviderBL provider = new ProviderBL();

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dgvPolicyDetails.DataSource = provider.ShowAllProviders();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            provider.insertProvider(int.Parse(txt_ID.Text),txt_Name.Text, txt_Address.Text,txt_email.Text ,txt_PhoneNumber.Text, cb_Status.Text);
            dgvPolicyDetails.DataSource = provider.ShowAllProviders();
            txt_ID.Clear();
            txt_Name.Clear();
            txt_email.Clear();
            txt_Address.Clear();
            txt_PhoneNumber.Clear();
            cb_Status.SelectedIndex = -1;
        }

        private void dgvPolicyDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgvPolicyDetails.Rows[e.RowIndex];
                txt_ID.Text = dgvRow.Cells[0].Value.ToString();
                txt_Name.Text = dgvRow.Cells[1].Value.ToString();
                txt_email.Text = dgvRow.Cells[2].Value.ToString();    
                txt_Address.Text = dgvRow.Cells[3].Value.ToString();
                txt_PhoneNumber.Text = dgvRow.Cells[4].Value.ToString();
                cb_Status.Text = dgvRow.Cells[5].Value.ToString();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dgvPolicyDetails.DataSource = provider.searchProvider(txt_Search.Text);
            txt_Search.Clear();

        }
        private void fProvider_Management_Load(object sender, EventArgs e)
        {
            dgvPolicyDetails.DataSource = provider.ShowAllProviders();
            this.dgvPolicyDetails.Columns["Provider_ID"].Visible = false;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_ID.Clear();
            txt_Name.Clear();
            txt_email.Clear();
            txt_Address.Clear();
            txt_Address.Clear();
            cb_Status.SelectedIndex = -1;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            provider.updateProviders(int.Parse(txt_ID.Text), txt_Name.Text, txt_Address.Text, txt_email.Text, txt_PhoneNumber.Text, cb_Status.Text);
            provider.updateProviderToPolicy(int.Parse(txt_ID.Text), txt_Name.Text);
            dgvPolicyDetails.DataSource = provider.ShowAllProviders();
            txt_ID.Clear();
            txt_Name.Clear();
            txt_email.Clear();
            txt_Address.Clear();
            txt_PhoneNumber.Clear();
            cb_Status.SelectedIndex = -1;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            provider.deleteProvider(int.Parse(txt_ID.Text));
            dgvPolicyDetails.DataSource = provider.ShowAllProviders();
            txt_ID.Clear();
            txt_Name.Clear();
            txt_email.Clear();
            txt_Address.Clear();
            txt_PhoneNumber.Clear();
            cb_Status.SelectedIndex = -1;
        }

        private void txt_Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPolicyDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}