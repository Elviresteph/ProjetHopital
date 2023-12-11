using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    abstract class Vehicule
    {
        private string marque;
        private double prix;

        public Vehicule(string marque, double prix)
        {
            this.marque = marque;
            this.prix = prix;
        }
        public abstract string Avancer();

        public override string ToString()
        {
            return Avancer() + " en " + marque + " qui a couté " + prix + " euros";
        }
    }
}
