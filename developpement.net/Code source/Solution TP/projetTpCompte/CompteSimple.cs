using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTpCompte
{
    class CompteSimple
    {
        private string titulaire { get; set; }
        private double solde { get; set; }
        private double cadeau = 20;


        public CompteSimple()
        {
        }

        public CompteSimple(string titulaire)
        {
            this.titulaire = titulaire;
            this.solde = cadeau;
        }

        public CompteSimple(string titulaire, double solde)
        {
            this.titulaire = titulaire;
            this.solde = solde + cadeau;
        }

        public override string ToString()
        {
            return "titulaire: " + titulaire + " " + "solde: " + solde;
        }

        public virtual bool crediter(int somme)
        {
            bool reponse = false;
            if (somme > 0)
            {
                solde = solde + somme - 1;
                reponse = true;
            }

            return reponse;

        }

        public virtual bool debiter(int somme)
        {
            bool reponse = false;

            if(somme>0 && somme<= solde)
            {
                solde = solde - somme - 1;
                reponse = true;
            }

            return reponse;

        }

        public virtual bool virement(int somme, CompteSimple c)
        {
            bool reponse = false;

            if (somme > 0 && somme <= solde)
            {
                solde = solde - somme - 1;
                c.solde = c.solde + somme -1;
                reponse = true;
            }

            return reponse;

        }

    }
}
