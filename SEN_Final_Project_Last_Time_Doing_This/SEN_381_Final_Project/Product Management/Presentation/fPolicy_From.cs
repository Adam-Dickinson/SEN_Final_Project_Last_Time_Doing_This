using SEN_381_Final_Project.Client_and_Policy_Management.Client_Management.Presentation;
using SEN_381_Final_Project.Medical_Department.Presentation;
using SEN_381_Final_Project.Product_Management.BLL;
using SEN_381_Final_Project.Product_Management.DAL.DataHandler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN_381_Final_Project.Product_Management.Presentation
{
    public partial class fPolicy_From : Form
    {
        public fPolicy_From()
        {
            InitializeComponent();
        }

        cPolicyBL policy = new cPolicyBL();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fPolicy_From_Load(object sender, EventArgs e)
        {
            dgv_Policy.DataSource = policy.showAllPolicys();
            this.dgv_Policy.Columns["Policy_ID"].Visible = false;
            this.dgv_Policy.Columns["Cover_ID"].Visible = false;
        }

        private void btn_PSearch_Click(object sender, EventArgs e)
        {
            policy.searchPolicy(txt_PSearch.Text);
            dgv_Policy.DataSource = policy.searchPolicy(txt_PSearch.Text);
        }

        private void btn_PAdd_Click(object sender, EventArgs e)
        {
            policy.addPolicy(int.Parse(txt_PID.Text), txt_PName.Text, txt_PPrice.Text, cb_Status.Text, cb_CoverLevel.Text);
            dgv_Policy.DataSource = policy.showAllPolicys();

            txt_PID.Clear();
            txt_PName.Clear();
            txt_PPrice.Clear();
            txt_PSearch.Clear();
            cb_Status.SelectedIndex = -1;
            cb_CoverLevel.SelectedIndex = -1;
        }

        private void btn_PUpdate_Click(object sender, EventArgs e)
        {
            policy.updatePolicy(int.Parse(txt_PID.Text), txt_PName.Text, txt_PPrice.Text, cb_Status.Text, cb_CoverLevel.Text);
            dgv_Policy.DataSource = policy.showAllPolicys();

            txt_PID.Clear();
            txt_PName.Clear();
            txt_PPrice.Clear();
            txt_PSearch.Clear();
            cb_Status.SelectedIndex = -1;
            cb_CoverLevel.SelectedIndex = -1;
        }


        private void btn_PDelete_Click(object sender, EventArgs e)
        {
            policy.deletePolicy(int.Parse(txt_PID.Text));
            dgv_Policy.DataSource = policy.showAllPolicys();

            txt_PID.Clear();
            txt_PName.Clear();
            txt_PPrice.Clear();
            txt_PSearch.Clear();
            cb_Status.SelectedIndex = -1;
            cb_CoverLevel.SelectedIndex = -1;
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

        private void dgv_Policy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgv_Policy.Rows[e.RowIndex];

                txt_PID.Text = dgvRow.Cells[0].Value.ToString();
                txt_PName.Text = dgvRow.Cells[1].Value.ToString();
                txt_PPrice.Text = dgvRow.Cells[2].Value.ToString();
                cb_Status.Text = dgvRow.Cells[3].Value.ToString();
                cb_CoverLevel.Text = dgvRow.Cells[5].Value.ToString();
            }
        }

        private void dgv_Policy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {

            dgv_Policy.DataSource = policy.showAllPolicys();

            txt_PID.Clear();
            txt_PName.Clear();
            txt_PPrice.Clear();
            txt_PSearch.Clear();
            cb_Status.SelectedIndex = -1;
            cb_CoverLevel.SelectedIndex = -1;

            this.dgv_Policy.Columns["Policy_ID"].Visible = false;
            this.dgv_Policy.Columns["Cover_ID"].Visible = false;
        }
    }
}
