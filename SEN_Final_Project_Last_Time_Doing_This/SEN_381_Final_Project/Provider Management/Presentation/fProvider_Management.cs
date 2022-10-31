using SEN_381_Final_Project.BLL;
using SEN_381_Final_Project.BusinessLayer.BL;
using SEN_381_Final_Project.DAL;
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
            provider.insertProvider(int.Parse(txt_ID.Text), txt_Name.Text, cb_Location.Text, txt_Address.Text, cb_Status.Text);
            dgvPolicyDetails.DataSource = provider.ShowAllProviders();
            txt_ID.Clear();
            txt_Name.Clear();
            cb_Location.SelectedIndex = -1;
            txt_Address.Clear();
            cb_Status.SelectedIndex = -1;
        }

        private void dgvPolicyDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgvPolicyDetails.Rows[e.RowIndex];
                txt_ID.Text = dgvRow.Cells[0].Value.ToString();
                txt_Name.Text = dgvRow.Cells[1].Value.ToString();
                cb_Location.Text = dgvRow.Cells[2].Value.ToString();    
                txt_Address.Text = dgvRow.Cells[3].Value.ToString();
                cb_Status.Text = dgvRow.Cells[4].Value.ToString();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dgvPolicyDetails.DataSource =  provider.searchProvider(txt_Search.Text);
            txt_Search.Clear();

        }
        private void fProvider_Management_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_ID.Clear();
            txt_Name.Clear();
            cb_Location.SelectedIndex = -1;
            txt_Address.Clear();
            cb_Status.SelectedIndex = -1;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            provider.updateProviders(int.Parse(txt_ID.Text), txt_Name.Text, cb_Location.Text, txt_Address.Text, cb_Status.Text);
            dgvPolicyDetails.DataSource = provider.ShowAllProviders();
            txt_ID.Clear();
            txt_Name.Clear();
            cb_Location.SelectedIndex = -1;
            txt_Address.Clear();
            cb_Status.SelectedIndex = -1;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            provider.deleteProvider(int.Parse(txt_ID.Text));
            dgvPolicyDetails.DataSource = provider.ShowAllProviders();
            txt_ID.Clear();
            txt_Name.Clear();
            cb_Location.SelectedIndex = -1;
            txt_Address.Clear();
            cb_Status.SelectedIndex = -1;
        }

        private void txt_Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_callcentre_Click(object sender, EventArgs e)
        {
            this.Hide();
            fCall_Center CallCenter = new fCall_Center();
            CallCenter.Show();
        }

        private void dgvPolicyDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}