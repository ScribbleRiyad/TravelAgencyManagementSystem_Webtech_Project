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
    public partial class Information : Form
    {
        public static string fName;
        public static string fEmail;
        public static string fPhoneNumber;
        public static string fMemberNo;
        public static string fNIDnumber;
        public static string fAddress;
        public Information()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp2_Click(object sender, EventArgs e)
        {
            fName = txtfName.Text;
            fEmail = txtfEmail.Text;
            fPhoneNumber = txtfPhoneNumber.Text;
            fMemberNo = txtMemberNo.Text;
            fAddress = txtAddress.Text;
            fNIDnumber = txtNIDnumber.Text;

            this.Hide();
            HotelBooking HB = new HotelBooking();
            HB.Show();
        }

        private void btnSaintMartinBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Event E = new Event();
            E.Show();
        }

        private void Information_Load(object sender, EventArgs e)
        {

        }

        private void txtfName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtfPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNIDnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNIDnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMemberNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
