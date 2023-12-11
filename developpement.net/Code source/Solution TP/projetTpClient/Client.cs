using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Client
    {
        private string nom;
        private string prenom;
        private Adresse adr;
        private Compte compte;

        public Client()
        {

        }

        public Client(string nom, string prenom, Adresse adr, Compte compte)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.compte = compte;
            this.adr = adr;

        }

        public string Nom
        {
            set
            {
                nom = value;
            }
        }
        public Compte Compte
        {
            get
            {
                return compte;
            }
            set
            {
                compte = value;
            }
        }
        public Client(string nom, string prenom, Adresse adr)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adr = adr;

        }
        public override string ToString()
        {
            string res = this.nom + "   " + prenom + " \n";
            if (adr != null)
                res += adr.ToString();
            if (compte != null)
                res += compte.ToString();
            return res;
        }
    }
}
