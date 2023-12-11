using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetCollection
{
    class Employe
    {
        private string nom;
        private string prenom;
        private int age;

        public Employe(string nom, string prenom, int age)
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
