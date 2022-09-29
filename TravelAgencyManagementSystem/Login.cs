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
    public partial class Login : Form
    {
        string connectionString = @"Data Source=RIYAD\SQLEXPRESS;Initial Catalog=UserLogin;Integrated Security=True";
       
        public Login()
        {
            InitializeComponent();
            txtPassword.Text = "";

            txtPassword.PasswordChar = '*';

            txtPassword.MaxLength = 14;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Event E = new Event();
            E.Show();






        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
