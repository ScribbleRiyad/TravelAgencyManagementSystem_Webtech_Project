using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgencyManagementSystem
{
    public partial class UserInformation : Form
    {
        SqlConnection connection;
        private int tempID;
        public UserInformation()
        {
            InitializeComponent();
            
            txtPassword.Text = "";

            txtPassword.PasswordChar = '*';

            txtPassword.MaxLength = 14;
            connection = new SqlConnection(@"Data Source=RIYAD\SQLEXPRESS;Initial Catalog=UserLogin;Integrated Security=True");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserInformation_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            display();
        }
        public void display()
            {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select *from tblUser", connection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            connection.Open();
            String sqlQuery = "INSERT INTO tblUser(Name,Email,Password) VALUES (@Name,@Email,@Password)";
            cmd = new SqlCommand(sqlQuery, connection);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            display();
            MessageBox.Show("Data Successfully Inserted to Database");


        }
        public void clearFeild()
            {
            txtName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            connection.Open();
            String sqlQuery = "Update tblUser set Name=@Name,Email=@Email,Password=@Password where id ='" + tempID + "'";
            cmd = new SqlCommand(sqlQuery, connection);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            display();
            MessageBox.Show("Data Successfully Updated to database");
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            connection.Open();
            for (int i = 0; i<dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow delRow = dataGridView1.Rows[i];
                if(delRow.Selected == true)
                {
                    String sqlQuery = "DELETE FROM tblUser Where ID = '" + dataGridView1.Rows[i].Cells[0].Value + "'";
                    SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection);
                    sqlCommand.ExecuteNonQuery();
                    dataGridView1.Rows.RemoveAt(i);
                    display();
                    clearFeild();
                    MessageBox.Show("Data Successfully Deleted");
                }
            }
                connection.Close();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                tempID = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtPassword.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
