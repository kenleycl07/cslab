using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etudiants
{
    public class Personne
    {
        private string _nom;
        private string _prenom1;
        private string _prenom2;
        private int _age;
        private string _nationalite;
        private string _adresseRue;
        private string _ville;
        private string _pays;
        private string _telephone;
        private DateTime _dateCreee;

        public string Nom
        {
            get { return _nom; }
            set { _nom = char.ToUpper(value[0]) + value.Substring(1); }
        }
        public string Prenom1
        {
            get { return _prenom1; }
            set { _prenom1 = char.ToUpper(value[0]) + value.Substring(1); }
        }
        public string Prenom2
        {
            get { return _prenom2; }
            set { _prenom2 = char.ToUpper(value[0]) + value.Substring(1); }
        }
        public int Age
        {
            get { return _age; }
            set
            {
                if (_age > 0 || _age < 150)
                    _age = value;
                else
                    _age = -1;
            }
        }
        public string Nationalite
        {
            get { return _nationalite; }
            set { _nationalite = value; }
        }
        public string AdresseRue 
        { 
            get { return _adresseRue; }
            set { _adresseRue = value; }
        }
        public string Ville 
        { 
            get { return _ville; }
            set { _ville = value;  }
        }
        public string Pays
        {
            get { return _pays; }
            set { _pays = value; }
        }
        public string Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }
        public DateTime DateCreee
        {
            get { return _dateCreee; }
            set { _dateCreee = DateTime.Now; }
        }

        public Personne(string ceNom, string cePrenom1, string cePrenom2, int cetAge)
        {
            Nom = ceNom; Prenom1 = cePrenom1; Prenom2 = cePrenom2; Age = cetAge; 
        }
        public Personne(string ceNom, string cePrenom1, string cePrenom2,int cetAge,
            string cetteNationalite, string cetteAdresseRue, string cetteVille, 
            string cePays, string ceTelephone, DateTime cetteDate)
        {
            Nom = ceNom; Prenom1 = cePrenom1; Prenom2 = cePrenom2; Age = cetAge;
            Nationalite = cetteNationalite; AdresseRue = cetteAdresseRue; Ville = cetteVille;
            Pays = cePays; Telephone = ceTelephone; DateCreee = cetteDate; 
        }
        public override string ToString() => $"{Prenom1} {Prenom2} {Nom}";


    }
}
