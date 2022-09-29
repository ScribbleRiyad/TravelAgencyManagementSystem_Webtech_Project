using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgencyManagementSystem
{
    public partial class CoxBazar : Form
    {
        public CoxBazar()
        {
            InitializeComponent();
        }

        private void btnCoxBazarBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Event E2 = new Event();
            E2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Information I = new Information();
            I.Show();
        }
    }
}
