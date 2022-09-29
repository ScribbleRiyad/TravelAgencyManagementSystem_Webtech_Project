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
    public partial class HotelBooking : Form
    {
        public static string fNumberOfRoom;
        public HotelBooking()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSaintMartinBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Information I = new Information();
            I.Show();
        }

        private void btnSignUp2_Click(object sender, EventArgs e)
        {
            fNumberOfRoom = txtNumberOfRoom.Text;
            this.Hide();
            Payment p = new Payment();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Advance Booking Has Been Confirm");
        }

        private void HotelBooking_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumberOfRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
