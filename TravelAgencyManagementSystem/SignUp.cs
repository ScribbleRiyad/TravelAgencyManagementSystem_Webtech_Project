using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TravelAgencyManagementSystem
{
    public partial class SignUp : Form
    {
        string connectionString = @"Data Source=RIYAD\SQLEXPRESS;Initial Catalog=UserLogin;Integrated Security=True";
        public SignUp()
        {
            InitializeComponent();
            txtPassword.Text = "";

            txtPassword.PasswordChar = '*';

            txtPassword.MaxLength = 14;
            txtConfirmPassword.Text = "";

            txtConfirmPassword.PasswordChar = '*';

            txtConfirmPassword.MaxLength = 14;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp2_Click(object sender, EventArgs e)
        {


            if (txtName.Text == "" || txtPassword.Text == "")
                MessageBox.Show("please fill mandatory fields");
            else if (txtPassword.Text != txtConfirmPassword.Text)
                MessageBox.Show("Password do not match");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                    sqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Account Created Successfully");
                    this.Hide();
                    Login L = new Login();
                    L.Show();

                    Clear();

                }
            }

        }
        void Clear()
        {
            txtName.Text = txtEmail.Text = txtPassword.Text = txtConfirmPassword.Text = "";

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
