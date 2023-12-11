using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetPersonnev2
{
    class Personne
    {
        private string nom = null;
        private string prenom = null;
        private int age = 0;


        //property Age get et set
        public int Age
        {

            //lecture
            get
            {
                return age;
            }
            //ecriture 0 et 120
            set
            {
                if (value > 0 && value < 120)
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

        public Personne(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.Age = age;

        }
        public Personne()
        {

        }

        public string GetInfo()
        {


            return this.nom + "   " + prenom + "  " + age;
        }
    }



}
    

        //public Personne(string n, string p, int a)
        //{
        //    nom = n;
        //    prenom = p;
        //    age = a;
        //}
        //public Personne(string nom, string prenom, int age)
        //{
        //    this.nom = nom;
        //    this.prenom = prenom;
        //}

        //public Personne()
        //{

        //}

        //public string GetInfo()
        //{

        //    return nom + "   " + prenom + "  " + age;
        //}

    

