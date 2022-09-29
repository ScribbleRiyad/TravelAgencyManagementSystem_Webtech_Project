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
    public partial class Sajek : Form
    {
        public Sajek()
        {
            InitializeComponent();
        }

        private void btnCoxBazarBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Event E3 = new Event();
            E3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Information I = new Information();
            I.Show();
        }
    }
}
