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
    public partial class Recipt : Form
    {   
        public Recipt()
        {
            InitializeComponent();
        }

        private void Recipt_Load(object sender, EventArgs e)
        {
            lblYourName.Text = Information.fName;
            lblYourEmail.Text = Information.fEmail;
            lblYourPhoneNo.Text = Information.fPhoneNumber;
            lblNumberOfMember.Text = Information.fMemberNo;
            lblNumberOfRoom.Text = HotelBooking.fNumberOfRoom;
            lblPaymentID.Text = Payment.fPaymentId;
            lblPaymentAc.Text = Payment.fPaymentAc;
            lblYourAddress.Text = Information.fAddress;
            lblYourNIDNumber.Text = Information.fPhoneNumber;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void lblPaymentOption_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnSaintMartinBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Information Has Been Saved ");
        }
    }
}
