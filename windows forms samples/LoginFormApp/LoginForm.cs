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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        // This code have been cut from inside the btnLogin_Click method 
        // for multiple usage purpose
        private void login() 
        {
            // store user's data
            string id = txtUserID.Text;
            string pass = txtPassword.Text;

            // if id and password are correct, show Form1 and Hide previous form
            // else, display warning
            if (id == "07" && pass == "jesus")
            {
                // Hide previous form
                this.Hide();

                Form1 f = new Form1();
                f.Show();
            }
            else
            {
                MessageBox.Show("Password or Email is incorrect");
            }
        }
        // This code have been cut from inside the btnReset_Click method 
        // for multiple usage purpose
        public void ResetMyForm() 
        {
            // Clear text fields
            txtUserID.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetMyForm();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if Enter key is clicked, Perform Login   
            if (e.KeyChar == (char)Keys.Enter) 
            {  
                login();
            }
            // if F1 key is clicked, Perform Reset 
            if (e.KeyChar == (char)Keys.F1)
            { 
                ResetMyForm();
            }
        }
    }
}
