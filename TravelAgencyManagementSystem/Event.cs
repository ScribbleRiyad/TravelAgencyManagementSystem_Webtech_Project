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
    public partial class Event : Form
    {
        public Event()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            CoxBazar Cb = new CoxBazar();
            Cb.Show();

        }

        private void label9_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSaintMartinCheck_Click(object sender, EventArgs e)
        {
            this.Hide();
            SaintMartin sm = new SaintMartin();
            sm.Show();
        }

        private void btnSajekCheck_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sajek Sk = new Sajek();
            Sk.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Information I = new Information();
            I.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Information I = new Information();
            I.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Information I = new Information();
            I.Show();
        }
    }
}
