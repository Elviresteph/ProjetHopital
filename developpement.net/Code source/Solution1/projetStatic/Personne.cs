using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetStatic
{
    class Personne
    {
        private static string nom = "Dupont";
        private string prenom;
        private int age;
        public const int ageMax = 120;
        private static int compteur;

        public static int Compteur
        {
            get { return compteur; }
        }

        public static string Nom
        {
            set
            {
                nom = value;
            }
        }
        public Personne(string prenom, int age)
        {
            compteur++;


            this.prenom = prenom;
            if (age < ageMax)
                this.age = age;

        }

        public Personne()
        {
            compteur++;

        }
        public Personne(string nom, string prenom, int age)
        {
            this.prenom = prenom;
            this.age = age;

        }
        

        public override string ToString()
        {
            return  nom+" "+prenom + "  " + age;
        }
    }
}
