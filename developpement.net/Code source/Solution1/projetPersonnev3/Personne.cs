using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetPersonnev3
{
    class Personne
    {
        private string nom="NA"; 
        private string prenom="NA";
        private int age;

        private const int ageMin = 0;
        private const int ageMax = 120;

        private const int ageMineur = 18;

        private bool isMajeur=false;


        public Personne(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.Age = age;

        }
        public Personne()
        {

        }
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

                if (value > ageMin && value < ageMax && value > this.age)
                {
                    age = value;
                    isMajeur = (age < ageMineur) ? false : true;
                }
                    
            }
        }
        public override string ToString()
        {
            return this.nom + "   " + prenom + "  " + age + "    " + ((isMajeur) ? " MAJEUR " : " MINEUR");
        }
    }
}
