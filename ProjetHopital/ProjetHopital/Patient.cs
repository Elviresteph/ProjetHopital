using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetHopital
{
    class Patient
    {
        private int id;
        private string nom;
        private string prenom;
        private int age;
        private string adresse;
        private string telephone;

        public Patient(int id, string nom, string prenom, int age, string adresse, string telephone)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.adresse = adresse;
            this.telephone = telephone;
            this.id = id;
        }
        public Patient()
        {

        }

        public int Id
        {
            get
            {
                return id;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }
        }

        public string Adresse
        {
            get
            {
                return adresse;
            }
        }

        public string Telephone
        {
            get
            {
                return telephone;
            }
        }
        public override string ToString()
        {

            return id + "    " + nom + "    " + prenom + "    " + age + "   " + adresse + "   " + telephone;
        }
    }
}
