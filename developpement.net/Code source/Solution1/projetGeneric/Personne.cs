using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetGeneric
{
    class Personne
    {
        private string nom;
        private string prenom;
        private int age;

        public string Nom
        {
            get { return nom; }
        }


        public Personne(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }
        

        public override string ToString()
        {

            string reponse = nom + "   " + prenom + "   " + age;

            return reponse;
        }
    }
}
