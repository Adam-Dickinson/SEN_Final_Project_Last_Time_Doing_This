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
        }

        private void btn_PUpdate_Click(object sender, EventArgs e)
        {
            policy.updatePolicy(int.Parse(txt_PID.Text), txt_PName.Text, txt_PPrice.Text, cb_Status.Text, cb_CoverLevel.Text);
            dgv_Policy.DataSource = policy.showAllPolicys();
        }

        private void btn_PDelete_Click(object sender, EventArgs e)
        {
            policy.deletePolicy(int.Parse(txt_PID.Text));
            dgv_Policy.DataSource = policy.showAllPolicys();
        }
    }
}
