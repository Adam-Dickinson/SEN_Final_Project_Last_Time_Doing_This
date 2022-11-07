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
            cb_RoleID.Text = "1: Main 2: Beneficiary";
            cb_PolicyID.Text = "Auto Filled In";
            btn_AddFamily.Visible = false;
            btn_UpdateFamily.Visible = false;
            btn_DeletFamily.Visible = false;

            this.dgv_Client.Columns["Client_ID"].Visible = false;
            this.dgv_Client.Columns["Role_ID"].Visible = false;
            this.dgv_Client.Columns["Policy_ID"].Visible = false;
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
            txt_Age.Clear();
            cb_CFamily.SelectedIndex = -1;
            cb_CPolicy.Text = "Select a Policy";
            cb_RoleID.Text = "1: Main 2: Beneficiary";
            cb_PolicyID.Text = "Auto Filled In";
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
            cb_RoleID.Text = "1: Main 2: Beneficiary";
        }

        private void btn_CAdd_Click(object sender, EventArgs e)
        {


            if (cb_CFamily.Text == "Individual")
            {
                client.addClient(int.Parse(txt_CID.Text), txt_CName.Text, txt_CSurname.Text, txt_Age.Text, txt_CAddress.Text, txt_CPhoneNumber.Text, cb_CFamily.Text, int.Parse(cb_RoleID.Text),int.Parse(cb_PolicyID.Text), cb_CPolicy.Text);
                MessageBox.Show("Client Has been added");

                txt_CID.Clear();
                txt_CName.Clear();
                txt_CSurname.Clear();
                txt_CAddress.Clear();
                txt_Age.Clear();
                txt_CPhoneNumber.Clear();
                cb_CFamily.SelectedIndex = -1;
                cb_CPolicy.Text = "Select a Policy";
                cb_RoleID.Text = "1: Main 2: Beneficiary";
            }
            else if (cb_CFamily.Text == "Family")
            {
                btn_AddFamily.Visible = true;
                client.addClient(int.Parse(txt_CID.Text), txt_CName.Text, txt_CSurname.Text, txt_Age.Text, txt_CAddress.Text, txt_CPhoneNumber.Text, cb_CFamily.Text, int.Parse(cb_RoleID.Text), int.Parse(cb_PolicyID.Text), cb_CPolicy.Text);   
            }
        }

        private void btn_CUpdate_Click(object sender, EventArgs e)
        {
            client.updateClient(int.Parse(txt_CID.Text), txt_CName.Text, txt_CSurname.Text, txt_Age.Text.ToString(), txt_CAddress.Text, txt_CPhoneNumber.Text, cb_CFamily.Text, int.Parse(cb_RoleID.Text), int.Parse(cb_PolicyID.Text), cb_CPolicy.Text);

            txt_CID.Clear();
            txt_CName.Clear();
            txt_CSurname.Clear();
            txt_CAddress.Clear();
            txt_Age.Clear();
            txt_CPhoneNumber.Clear();
            cb_CFamily.SelectedIndex = -1;
            cb_RoleID.SelectedIndex = -1;
            cb_CPolicy.SelectedIndex = -1;

            cb_CPolicy.Text = "Select a Policy";
            cb_RoleID.Text = "1: Main 2: Beneficiary";

            dgv_Client.DataSource = client.displayClient();
        }

        private void btn_CDelete_Click(object sender, EventArgs e)
        {
            client.deleteClient(int.Parse(txt_CID.Text));
            dgv_Client.DataSource = client.displayClient();

            txt_CID.Clear();
            txt_CName.Clear();
            txt_CSurname.Clear();
            txt_CAddress.Clear();
            txt_Age.Clear();
            txt_CPhoneNumber.Clear();
            cb_CFamily.SelectedIndex = -1;
            cb_RoleID.SelectedIndex = -1;
            cb_CPolicy.SelectedIndex = -1;
        }

        private void cb_RoleID_Enter(object sender, EventArgs e)
        {
            if (cb_RoleID.Text == "1: Main 2: Beneficiary")
            {
                cb_RoleID.DataSource = client.displayRoles();
                cb_RoleID.DisplayMember = "Role_ID";
            }
        }

        private void btn_AddFamily_Enter(object sender, EventArgs e)
        {
            
        }

        private void cb_CFamily_TextUpdate(object sender, EventArgs e)
        {
            
        }

        private void btn_AddFamily_Click(object sender, EventArgs e)
        {
            client.addFamily(int.Parse(txt_CID.Text), int.Parse(cb_RoleID.Text), txt_CName.Text, txt_CSurname.Text, txt_CPhoneNumber.Text);

            txt_CID.Clear();
            txt_CName.Clear();
            txt_CSurname.Clear();
            txt_CAddress.Clear();
            txt_Age.Clear();
            txt_CPhoneNumber.Clear();
            cb_CFamily.SelectedIndex = -1;
            cb_RoleID.SelectedIndex = -1;
            cb_CPolicy.SelectedIndex = -1;

        }

        private void cb_PolicyID_Enter(object sender, EventArgs e)
        {
            if(cb_PolicyID.Text == "Auto Filled In")
            {
                cb_PolicyID.DataSource = Policy.showAllPolicys();
                cb_PolicyID.DisplayMember = "Policy_ID";
            }
            
        }

        private void cb_PolicyID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_CPolicy_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < cb_CPolicy.Items.Count; i++)
            {
                if (cb_CPolicy.SelectedIndex == i)
                {
                    cb_PolicyID.SelectedIndex = i;
                }
            }
        }

        private void dgv_Client_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgv_Client.Rows[e.RowIndex];

                txt_CID.Text = dgvRow.Cells[0].Value.ToString();
                txt_CName.Text = dgvRow.Cells[1].Value.ToString();
                txt_CSurname.Text = dgvRow.Cells[2].Value.ToString();
                txt_CAddress.Text = dgvRow.Cells[4].Value.ToString();
                txt_CPhoneNumber.Text = dgvRow.Cells[5].Value.ToString();
                txt_Age.Text = dgvRow.Cells[3].Value.ToString();
                cb_CFamily.Text = dgvRow.Cells[6].Value.ToString();
                cb_RoleID.Text = dgvRow.Cells[7].Value.ToString();
                cb_CPolicy.Text = dgvRow.Cells[8].Value.ToString();
                cb_PolicyID.Text = dgvRow.Cells[9].Value.ToString();
            }
        }

        private void dgv_Family_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgv_Family.Rows[e.RowIndex];

                txt_FID.Text = dgvRow.Cells[1].Value.ToString();
                txt_RoleType.Text = dgvRow.Cells[2].Value.ToString();
                txt_FName.Text = dgvRow.Cells[3].Value.ToString();
                txt_FSurname.Text = dgvRow.Cells[4].Value.ToString();
                txt_FPhoneNumber.Text = dgvRow.Cells[5].Value.ToString();
            }
        }

        private void btn_FSearch_Click(object sender, EventArgs e)
        {
            dgv_Family.DataSource = client.searchFamily(txt_FSearch.Text);

            this.dgv_Family.Columns["Family_ID"].Visible = false;
            this.dgv_Family.Columns["Client_ID"].Visible = false;
            this.dgv_Family.Columns["Role_ID"].Visible = false;


        }

        private void btn_UpdateFamily_Click(object sender, EventArgs e)
        {

        }

        private void btn_DeletFamily_Click(object sender, EventArgs e)
        {

        }
    }
}
