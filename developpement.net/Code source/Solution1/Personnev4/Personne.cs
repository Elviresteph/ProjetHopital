using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    class Personne
    {
        private string nom;
        private string prenom;
        private int age;

        private Adresse adr;//null

        public Personne(string nom, string prenom, int age, Adresse adr)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.adr = adr;

        }

        public Personne(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;

        }
        public Adresse Adr
        {
            get
            {
                return adr;
            }

            set
            {
                adr = value;
            }


        }


        public int Age
        {

            get
            {
                return age;
            }
            set
            {
                age = value;
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
        public override string ToString()
        {
            string res = this.nom + "   " + prenom + "  " + age + " \n";
            if (adr != null)
                res += adr.ToString();
            return res;
        }
    }
}
