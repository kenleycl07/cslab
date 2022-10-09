using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text))
                return;
            ListViewItem item = new ListViewItem(txtID.Text);
            item.SubItems.Add(txtName.Text);
            listView.Items.Add(item);
            txtID.Clear();
            txtName.Clear();
            txtID.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count > 0) 
            {
                listView.Items.Remove(listView.SelectedItems[0]);
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "All files|*.*",
                ValidateNames = true, Multiselect = true})
            {
                if (ofd.ShowDialog() == DialogResult.OK) 
                {
                    foreach (string f in ofd.FileNames) 
                    { 
                        FileInfo fi = new FileInfo(f);
                        ListViewItem item = new ListViewItem(fi.Name);
                        item.SubItems.Add(fi.FullName);
                        listViewFile.Items.Add(item);
                    }
                }
            }
           
        }
    }
}
