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

        private void btn_provider_Click(object sender, EventArgs e)
        {
            this.Hide();
            fProvider_Management provider = new fProvider_Management();
            provider.Show();
        }
    }
}
