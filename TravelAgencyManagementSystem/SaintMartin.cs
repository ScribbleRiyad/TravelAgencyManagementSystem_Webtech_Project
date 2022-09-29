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
    public partial class SaintMartin : Form
    {
        public SaintMartin()
        {
            InitializeComponent();
        }

        private void btnSaintMartinBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Event E = new Event();
            E.Show();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
