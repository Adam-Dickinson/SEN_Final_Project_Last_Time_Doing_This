using SEN_381_Final_Project.BusinessLayer.BL;
using SEN_381_Final_Project.Client_and_Policy_Management.Client_Management.Presentation;
using SEN_381_Final_Project.Medical_Department.BLL.Buisness_Object;
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

        private void btn_AddMC_Click(object sender, EventArgs e)
        {
            Condition.insertCondition(int.Parse(txt_CID.Text), txt_MCName.Text, rtxt_MCInformation.Text);
            dgv_MC.DataSource = Condition.displayConditions();
            txt_CID.Clear();
            txt_MCName.Clear();
            rtxt_MCInformation.Clear();
            cb_TreatmentMC.DataSource = Condition.displayConditions();
            cb_TreatmentMC.DisplayMember = "Condition_Name";
        }

        private void dgv_MC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fMedical_Load(object sender, EventArgs e)
        {
            dgv_MC.DataSource = Condition.displayConditions();
            dgv_Treatment.DataSource = Condition.displayTreatments();

            cb_TreatmentMC.Text = "Select a medical Condition";
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
            Condition.insertTreatment(int.Parse(txt_TID.Text), txt_TreatmentName.Text, rtxt_TreatmentDescription.Text, cb_TreatmentMC.Text);
            dgv_Treatment.DataSource = Condition.displayTreatments();
            txt_TID.Clear();
            txt_TreatmentName.Clear();
            rtxt_TreatmentDescription.Clear();
            cb_TreatmentMC.Text = "Select a medical Condition";
        }

        private void cb_TreatmentMC_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_TreatmentMC_Enter(object sender, EventArgs e)
        {
            if(cb_TreatmentMC.Text == "Select a medical Condition")
            {
                cb_TreatmentMC.DataSource = Condition.displayConditions();
                cb_TreatmentMC.DisplayMember = "Condition_Name";
            }
        }

        private void cb_TreatmentMC_Leave(object sender, EventArgs e)
        {
            if( cb_TreatmentMC.Text == " ")
            {
                cb_TreatmentMC.Text = "Select a medical Condition";
            }
        }

        private void dgv_Treatment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgv_Treatment.Rows[e.RowIndex];
                txt_TID.Text = dgvRow.Cells[0].Value.ToString();
                txt_TreatmentName.Text = dgvRow.Cells[1].Value.ToString();
                rtxt_TreatmentDescription.Text = dgvRow.Cells[2].Value.ToString();
                cb_TreatmentMC.Text = dgvRow.Cells[3].Value.ToString();
            }
        }

        private void btn_SearchTreatment_Click(object sender, EventArgs e)
        {
            dgv_Treatment.DataSource = Condition.searchTreatment(txt_TreatmentNameSearch.Text);
        }

        private void btn_SearchMC_Click(object sender, EventArgs e)
        {
            dgv_MC.DataSource = Condition.searchCondition(txt_MCNameSearch.Text);
        }

        private void btn_UpdateTreatment_Click(object sender, EventArgs e)
        {
            Condition.updateTreatment(int.Parse(txt_TID.Text), txt_TreatmentName.Text, rtxt_TreatmentDescription.Text, cb_TreatmentMC.Text);
            txt_TID.Clear();
            txt_TreatmentName.Clear();
            rtxt_TreatmentDescription.Clear();
            cb_TreatmentMC.Text = "Select a medical Condition";
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
            cb_TreatmentMC.Text = "Select a medical Condition";
        }

        private void btn_DeleteMC_Click(object sender, EventArgs e)
        {
            Condition.deleteCondition(int.Parse(txt_CID.Text));
            dgv_MC.DataSource = Condition.displayConditions();
            txt_CID.Clear();
            txt_MCName.Clear();
            rtxt_MCInformation.Clear();
            cb_TreatmentMC.DataSource = Condition.displayConditions();
            cb_TreatmentMC.DisplayMember = "Condition_Name";
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
