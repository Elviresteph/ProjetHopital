using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpDico
{
    class Personne : Complement
    {
        private string nom;
        private string prenom;

        public Personne(string nom, string prenom, string adresse, string telephone) : base(adresse, telephone)
        {
            this.nom = nom;
            this.prenom = prenom;   

        }
        public override string ToString()
        {
            string res = "nom: " + nom + "\t" + "prenom: " + prenom + "\t" + base.ToString();
            
            return res;
        }
    }
}
