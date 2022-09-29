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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
            txtPassword.Text = "";

            txtPassword.PasswordChar = '*';

            txtPassword.MaxLength = 14;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserInformation u = new UserInformation();
            u.Show();
        }
    }
}
