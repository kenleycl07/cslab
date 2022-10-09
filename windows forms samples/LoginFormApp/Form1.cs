using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            // Display text
            lblHello.Text = "Hello World !";
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            // Display text 
            lblHello.Text = "Hello World Again Again...";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Display text 
            lblHello.Text = "Text has been Canceled";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Hide previous form
            this.Hide();

            // Show LoginForm 
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
