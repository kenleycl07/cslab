using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPApp2
{
    public partial class SignUp : Form
    {
        public static string fName;
        public static string lName;
        public static string emailAdress;

        public static Boolean sms;
        public static Boolean reports;
        public static Boolean transactions;

        Confirmation c = new Confirmation();

        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            fName = txtFirstName.Text;
            lName = txtLastName.Text;
            emailAdress = txtEmailAddress.Text;

            this.Hide();
            c.Show();
        }

        private void chkSMS_CheckedChanged(object sender, EventArgs e)
        {
            // if (chkSMS.Checked == true)
            if (chkSMS.Checked)
            {
                sms = true;

                lblSMSMessage.Text = "Services Charges may Apply for SMS.";
            }
            else 
            {
                sms = false;

                lblSMSMessage.Text = "..."; 
            }
        }

        private void chkReports_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReports.Checked)
            {
                reports = true;
            }
            else
            {
                reports = false;
            }

        }

        private void chkTransactions_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTransactions.Checked)
            {
                transactions = true;

                lblTransactionMessage.Text = "Services Charges may Apply for Transaction.";
            }
            else 
            { 
                transactions = false;
                lblTransactionMessage.Text = "...";
            }

        }
    }
}
