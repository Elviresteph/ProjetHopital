using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTpParkingv1
{
    class Proprio
    {
        public string nom;
        public string prenom;

        public string Nom
        {
            get { return nom; }

        }
        public string Prenom
        {
            get { return prenom; }

        }
        public Proprio(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;

        }
        public override string ToString()
        {
            return "nom: " + nom + " " + "prenom: " + prenom;
        }
    }
}
