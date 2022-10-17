using SEN_381_Final_Project.DAL;
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
    public partial class fProvider_Management : Form
    {
        public fProvider_Management()
        {
            InitializeComponent();
        }

        DataHandler_Provider handler = new DataHandler_Provider();

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var MainMenu = new fMainMenu();
            MainMenu.Show();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dgvPolicyDetails.DataSource = handler.displayProvider();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            handler.insertProvider(int.Parse(txt_ID.Text), txt_Name.Text, cb_Location.Text, txt_Address.Text, cb_Status.Text);
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
            dgvPolicyDetails.DataSource = handler.searchProvider(txt_Search.Text);
            txt_Search.Clear();

        }

        private void fProvider_Management_Load(object sender, EventArgs e)
        {
            dgvPolicyDetails.DataSource = handler.displayProvider();
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
            handler.updateProvider(int.Parse(txt_ID.Text), txt_Name.Text, cb_Location.Text, txt_Address.Text, cb_Status.Text);
            txt_ID.Clear();
            txt_Name.Clear();
            cb_Location.SelectedIndex = -1;
            txt_Address.Clear();
            cb_Status.SelectedIndex = -1;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            handler.deleteProvider(int.Parse(txt_ID.Text));
            txt_ID.Clear();
            txt_Name.Clear();
            cb_Location.SelectedIndex = -1;
            txt_Address.Clear();
            cb_Status.SelectedIndex = -1;
        }
    }
}