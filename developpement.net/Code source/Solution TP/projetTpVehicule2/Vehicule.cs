using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTpVehicule2
{
    class Vehicule

    {
        private string marque;
        private double prix;
       

        public virtual string Avancer()
        {
            return "je roule";
        }
        public Vehicule(string marque, double prix)
        {
            this.marque = marque;
            this.prix = prix;
        }
        public override string ToString()
        {
            return "marque :" + marque + " " + "prix: " + prix;
        }
    }
    enum taille
    {
        petit = 2,
        mooyen = 4,
        grand = 10
    }
}
