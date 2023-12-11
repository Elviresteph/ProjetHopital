using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTpFacture
{
    class Gateau : abstract_Article
    {

        EGateau eGateau;
        public Gateau(string nom, double prix, EGateau eGateau) : base(nom, prix)
        {
            this.eGateau = eGateau;
        }

        public override string ToString()
        {
            return  "gateau " + base.ToString() + " - " + "saveur: " + eGateau;
        }
    }
    enum EGateau
    {
        choco = 1,
        vanille = 2,
        fraise = 3
    }
}

