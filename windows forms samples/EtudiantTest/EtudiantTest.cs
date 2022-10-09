using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.IO;
using static System.Windows.Forms.LinkLabel;


namespace EtudiantTest
{
    public partial class frmEtudiantTest : Form
    {
        List<Personne> Personnes = new List<Personne>();

        public frmEtudiantTest()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtNom.Text = String.Empty;
            txtPrenom1.Text = String.Empty;
            txtPrenom2.Text = String.Empty;
            txtAge.Text = String.Empty;
            txtTelephone.Text = String.Empty;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string prenom1 = txtPrenom1.Text;
            string prenom2 = txtPrenom2.Text;
            int age = int.Parse(txtAge.Text);
            string telephone = txtTelephone.Text;
            DateTime date = DateTime.Now;
            
            // Enregistrer avec personne, setters et getters avec constructeurs
            Personne personne = new Personne(nom, prenom1, prenom2, age, telephone);

            Personnes.Add(personne);

            if (string.IsNullOrEmpty(personne.Nom) || string.IsNullOrEmpty(personne.Prenom1 + " " + personne.Prenom2)
                || string.IsNullOrEmpty(personne.Age.ToString())
                || string.IsNullOrEmpty(personne.Telephone))
                return;
            ListViewItem item = new ListViewItem(personne.Nom);
            item.SubItems.Add(personne.Prenom1 + " " + personne.Prenom2);
            item.SubItems.Add(personne.Age.ToString());
            item.SubItems.Add(personne.Telephone);
            listView.Items.Add(item);
            txtNom.Clear();
            txtPrenom1.Clear();
            txtPrenom2.Clear();
            txtAge.Clear();
            txtTelephone.Clear();
            txtNom.Focus();

            string laDate = date.ToString("dd/MM/yyyy");
            StreamWriter sw = new StreamWriter("personne.txt");
            sw.WriteLine(laDate);
            foreach (Personne p in Personnes)
                sw.WriteLine(p.Nom + "," + p.Prenom1 + "," + p.Prenom2 + "," + p.Age + "," + p.Telephone);
            sw.Close();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {            
        }

        
        private void frmEtudiantTest_Load(object sender, EventArgs e)
        {
            string thefile = @"personne.txt";

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(thefile).ToList();

            foreach (string line in lines)
            {
                string[] items = line.Split(',');

                Personne per = new Personne(items[0], items[1], items[2], int.Parse(items[3]), items[4]);

                Personnes.Add(per);

                if (string.IsNullOrEmpty(items[0]) || string.IsNullOrEmpty(items[1] + " " + items[2])
                || string.IsNullOrEmpty(items[3].ToString())
                || string.IsNullOrEmpty(items[4]))
                    return;
                ListViewItem item = new ListViewItem(items[0]);
                item.SubItems.Add(items[1] + " " + items[2]);
                item.SubItems.Add(items[3].ToString());
                item.SubItems.Add(items[4]);
                listView.Items.Add(item);
                txtNom.Clear();
                txtPrenom1.Clear();
                txtPrenom2.Clear();
                txtAge.Clear();
                txtTelephone.Clear();
                txtNom.Focus();
            }

        }
    }
}
