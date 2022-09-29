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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp S1 = new SignUp();
            S1.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login L1 = new Login();
            L1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin Ad = new AdminLogin();
            Ad.Show();
        
        }
    }
}
