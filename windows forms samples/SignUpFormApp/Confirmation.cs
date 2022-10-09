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
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            lblFName.Text = SignUp.fName;
            lblLName.Text = SignUp.lName;
            lblEmailAddress.Text = SignUp.emailAdress;

            if (SignUp.sms) 
            {
                lblSMS.Text = "✓";
            }
            if (SignUp.reports)
            {
                lblReports.Text = "✓";
            }
            if (SignUp.transactions)
            {
                lblTransactions.Text = "✓";
            }

        }
    }
}
