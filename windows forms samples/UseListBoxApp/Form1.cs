using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Person personObject = new Person();

            personObject.Name = txtName.Text;
            personObject.Address = txtAddress.Text;
            personObject.City = txtCity.Text;
            personObject.State = txtState.Text;
            personObject.ZipCode = txtZipCode.Text;

            listBoxResults.Items.Add(personObject.Name);
            listBoxResults.Items.Add(personObject.Address); 
            listBoxResults.Items.Add(personObject.City);
            listBoxResults.Items.Add(personObject.State);
            listBoxResults.Items.Add(personObject.ZipCode);

        }
    }
}
