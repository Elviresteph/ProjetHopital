using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTpVehicule
{
    class Vehicule
    {
        private string marque;
        private double prix;

        public Vehicule(string marque, double prix)
        {
            this.marque = marque;
            this.prix = prix;
        }
        public virtual string Avancer()
        {
            return "je roule";
        }
        public override string ToString()
        {
            return Avancer() + " en " + marque + " qui a couté " + prix + " euros";
        }
    }
}
