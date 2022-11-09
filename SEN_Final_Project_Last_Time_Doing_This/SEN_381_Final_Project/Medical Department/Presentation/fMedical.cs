using SEN_381_Final_Project.BusinessLayer.BL;
using SEN_381_Final_Project.Client_and_Policy_Management.Client_Management.Presentation;
using SEN_381_Final_Project.Medical_Department.BLL.Buisness_Object;
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

namespace SEN_381_Final_Project.Medical_Department.Presentation
{
    public partial class fMedical : Form
    {
        public fMedical()
        {
            InitializeComponent();
        }

        MedicalBL Condition = new MedicalBL();
        cPolicyBL policy = new cPolicyBL();

        private void btn_AddMC_Click(object sender, EventArgs e)
        {
            Condition.insertCondition(int.Parse(txt_CID.Text), txt_MCName.Text, rtxt_MCInformation.Text);
            dgv_MC.DataSource = Condition.displayConditions();
            txt_CID.Clear();
            txt_MCName.Clear();
            rtxt_MCInformation.Clear();
            cb_TreatmentMC.Text = "Medcial Condition ID";
            cb_Condition.Text = "Medcial Condition";
            cb_PID.Text = "Policy ID";
            cb_PName.Text = "Policy Name";
        }

        private void dgv_MC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fMedical_Load(object sender, EventArgs e)
        {
            dgv_MC.DataSource = Condition.displayConditions();
            dgv_Treatment.DataSource = Condition.displayTreatments();

            cb_TreatmentMC.Text = "Medcial Condition ID";
            cb_Condition.Text = "Medcial Condition";
            cb_PID.Text = "Policy ID";
            cb_PName.Text = "Policy Name";

            this.dgv_Treatment.Columns["Treatment_ID"].Visible = false;
            this.dgv_Treatment.Columns["Condition_ID"].Visible = false;
            this.dgv_MC.Columns["Condition_ID"].Visible = false;
            this.dgv_Treatment.Columns["Policy_ID"].Visible = false;
        }

        private void dgv_MC_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_MC_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgv_MC.Rows[e.RowIndex];
                txt_CID.Text = dgvRow.Cells[0].Value.ToString();
                txt_MCName.Text = dgvRow.Cells[1].Value.ToString();
                rtxt_MCInformation.Text = dgvRow.Cells[2].Value.ToString();
            }
        }

        private void btn_AddTreatment_Click(object sender, EventArgs e)
        {
            Condition.insertTreatment(int.Parse(txt_TID.Text), txt_TreatmentName.Text, rtxt_TreatmentDescription.Text,cb_Condition.Text, int.Parse(cb_TreatmentMC.Text), cb_PName.Text, int.Parse(cb_PID.Text));
            Condition.insertCTP(int.Parse(txt_TID.Text),txt_TreatmentName.Text, int.Parse(cb_TreatmentMC.Text), cb_Condition.Text, int.Parse(cb_PID.Text), cb_PName.Text);
            dgv_Treatment.DataSource = Condition.displayTreatments();
            txt_TID.Clear();
            txt_TreatmentName.Clear();
            rtxt_TreatmentDescription.Clear();
            cb_TreatmentMC.Text = "Medcial Condition ID";
            cb_Condition.Text = "Medcial Condition";
            cb_PID.Text = "Policy ID";
            cb_PName.Text = "Policy Name";
        }

        private void cb_TreatmentMC_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_TreatmentMC_Enter(object sender, EventArgs e)
        {

                cb_TreatmentMC.DataSource = Condition.displayConditions();
                cb_TreatmentMC.DisplayMember = "Condition_ID";

        }

        private void cb_TreatmentMC_Leave(object sender, EventArgs e)
        {
            
        }

        private void dgv_Treatment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgv_Treatment.Rows[e.RowIndex];
                txt_TID.Text = dgvRow.Cells[0].Value.ToString();
                txt_TreatmentName.Text = dgvRow.Cells[1].Value.ToString();
                rtxt_TreatmentDescription.Text = dgvRow.Cells[2].Value.ToString();
                cb_TreatmentMC.Text = dgvRow.Cells[4].Value.ToString();
                cb_Condition.Text = dgvRow.Cells[3].Value.ToString();
                cb_PName.Text = dgvRow.Cells[5].Value.ToString();
                cb_PID.Text = dgvRow.Cells[6].Value.ToString();
            }
        }

        private void btn_SearchTreatment_Click(object sender, EventArgs e)
        {
            dgv_Treatment.DataSource = Condition.searchTreatment(txt_TreatmentNameSearch.Text);

            this.dgv_Treatment.Columns["Treatment_ID"].Visible = false;
            this.dgv_Treatment.Columns["Condition_ID"].Visible = false;
        }

        private void btn_SearchMC_Click(object sender, EventArgs e)
        {
            dgv_MC.DataSource = Condition.searchCondition(txt_MCNameSearch.Text);
        }

        private void btn_UpdateTreatment_Click(object sender, EventArgs e)
        {
            Condition.updateTreatment(int.Parse(txt_TID.Text), txt_TreatmentName.Text, rtxt_TreatmentDescription.Text, cb_Condition.Text, int.Parse(cb_TreatmentMC.Text), cb_PName.Text, int.Parse(cb_PID.Text));
            dgv_Treatment.DataSource = Condition.displayTreatments();
            txt_TID.Clear();
            txt_TreatmentName.Clear();
            rtxt_TreatmentDescription.Clear();
            cb_TreatmentMC.Text = "Medcial Condition ID";
            cb_Condition.Text = "Medcial Condition";
            cb_PID.Text = "Policy ID";
            cb_PName.Text = "Policy Name";
        }

        private void btn_UpdateMC_Click(object sender, EventArgs e)
        {
            Condition.TestUpdate(int.Parse(txt_CID.Text), txt_MCName.Text, rtxt_MCInformation.Text, txt_MCName.Text);
            dgv_Treatment.DataSource = Condition.displayTreatments(); 
            dgv_MC.DataSource = Condition.displayConditions();
        }

        private void btn_DeleteTreatment_Click(object sender, EventArgs e)
        {
            Condition.deleteTreatment(int.Parse(txt_TID.Text));
            dgv_Treatment.DataSource = Condition.displayTreatments();
            txt_TID.Clear();
            txt_TreatmentName.Clear();
            rtxt_TreatmentDescription.Clear();
            cb_TreatmentMC.Text = "Medcial Condition ID";
            cb_Condition.Text = "Medcial Condition";
            cb_PID.Text = "Policy ID";
            cb_PName.Text = "Policy Name";
        }

        private void btn_DeleteMC_Click(object sender, EventArgs e)
        {
            Condition.deleteCondition(int.Parse(txt_CID.Text));
            dgv_MC.DataSource = Condition.displayConditions();
            txt_CID.Clear();
            txt_MCName.Clear();
            rtxt_MCInformation.Clear();
            cb_TreatmentMC.Text = "Medcial Condition ID";
            cb_Condition.Text = "Medcial Condition";
            cb_PID.Text = "Policy ID";
            cb_PName.Text = "Policy Name";
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

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            txt_TID.Clear();
            txt_TreatmentName.Clear();
            rtxt_TreatmentDescription.Clear();
            dgv_Treatment.DataSource = Condition.displayTreatments();
            txt_TreatmentNameSearch.Clear();

            cb_TreatmentMC.Text = "Medcial Condition ID";
            cb_Condition.Text = "Medcial Condition";
            cb_PID.Text = "Policy ID";
            cb_PName.Text = "Policy Name";

            this.dgv_Treatment.Columns["Treatment_ID"].Visible = false;
            this.dgv_MC.Columns["Condition_ID"].Visible = false;
        }

        private void btn_reload2_Click(object sender, EventArgs e)
        {
            dgv_MC.DataSource = Condition.displayConditions();
            txt_CID.Clear();
            txt_MCName.Clear();
            rtxt_MCInformation.Clear();
            txt_MCNameSearch.Clear();

            this.dgv_Treatment.Columns["Treatment_ID"].Visible = false;
            this.dgv_MC.Columns["Condition_ID"].Visible = false;
        }

        private void cb_TreatmentMC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_Condition_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cb_Condition.Items.Count; i++)
            {
                if (cb_Condition.SelectedIndex == i)
                {
                    cb_TreatmentMC.SelectedIndex = i;
                }
            }
        }

        private void cb_Condition_Enter(object sender, EventArgs e)
        {
                cb_Condition.DataSource = Condition.displayConditions();
                cb_Condition.DisplayMember = "Condition_Name";
        }

        private void cb_PID_Enter(object sender, EventArgs e)
        {
            cb_PID.DataSource = policy.showAllPolicys();
            cb_PID.DisplayMember = "Policy_ID";
        }

        private void cb_PName_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < cb_PName.Items.Count; i++)
            {
                if(cb_PName.SelectedIndex == i)
                {
                    cb_PID.SelectedIndex = i;
                }
            }
        }

        private void cb_PName_Enter(object sender, EventArgs e)
        {
            cb_PName.DataSource = policy.showAllPolicys();
            cb_PName.DisplayMember = "Policy_Name";
        }
    }
}
