using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTpParkingv1
{
    class Fiche
    {
        public string Matricule;
        public string Marque;
        public decimal Prix;

        public Fiche(string matricule, string marque, decimal prix)
        {
            this.Matricule = matricule;
            this.Marque = marque;
            this.Prix = prix;
        }
        public override string ToString()
        {
            return "Matricule:" + Matricule + " " + "Marque:" + Marque + " " + "Prix:"+ Prix;
        }
    }
}
