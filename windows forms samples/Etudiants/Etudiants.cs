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
using System.IO;

namespace Etudiants
{
    public partial class Etudiants : Form
    {
        List<Personne> Personnes = new List<Personne>();

        public Etudiants()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtNom.Text = String.Empty;
            txtPrenom1.Text = String.Empty;
            txtPrenom2.Text = String.Empty;
            txtAge.Text = String.Empty;
            txtNationalite.Text = String.Empty;
            txtAdresseRue.Text = String.Empty;
            txtVille.Text = String.Empty;
            txtPays.Text = String.Empty;
            txtTelephone.Text = String.Empty;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string prenom1 = txtPrenom1.Text;
            string prenom2 = txtPrenom2.Text;
            int age = int.Parse(txtAge.Text);
            string nationalite = txtNationalite.Text;
            string adresse = txtAdresseRue.Text;
            string ville = txtVille.Text;
            string pays = txtPays.Text;
            string telephone = txtTelephone.Text;
            DateTime date = DateTime.Now;


            Personne personne = new Personne(nom, prenom1, prenom2, age, nationalite, adresse, ville, pays, telephone, date);

            Personnes.Add(personne);

            if (string.IsNullOrEmpty(personne.Nom)
                || string.IsNullOrEmpty(personne.Prenom1 + " " + personne.Prenom2)
                || string.IsNullOrEmpty(personne.Age.ToString())
                || string.IsNullOrEmpty(personne.Telephone))
                return;

            ListViewItem item = new ListViewItem(personne.Nom);
            item.SubItems.Add(personne.Prenom1 + " " + personne.Prenom2);
            item.SubItems.Add(personne.Age.ToString());
            item.SubItems.Add(personne.Telephone);

            listViewEtudiants.Items.Add(item);

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
                sw.WriteLine(p.Nom + ", " + p.Prenom1 + ", " + p.Prenom2 + ", " + p.Age.ToString() + ", " + p.Telephone);
           
            sw.Close();

        }
    }
}


