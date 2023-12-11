using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTpCompte
{
    class CompteVIP : CompteSimple
    {
        public CompteVIP(string titulaire, double solde) : base(titulaire, solde)
        {
            
        }

        public override bool crediter(int somme)
        {
            bool reponse = false;
            if (somme > 0)
            {
                this.solde = solde + somme;
                reponse = true;
            }

            return reponse;

        }

        public override bool debiter(int somme)
        {
            bool reponse = false;

            if (somme > 0)
            {
                solde = solde - somme;
                reponse = true;
            }

            return reponse;

        }

        public override bool virement(int somme, CompteSimple c)
        {
            bool reponse = false;

            if (somme > 0)
            {
                solde = solde - somme;
                c.solde = c.solde + somme;
                reponse = true;
            }

            return reponse;

        }
    }
}
