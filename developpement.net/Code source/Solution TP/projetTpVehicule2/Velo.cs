using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTpVehicule2
{
    class Velo : Vehicule
    {
        public Velo(string marque, double prix) : base(marque, prix)
        {
        }

        public override string Avancer()
        {
            return base.Avancer() + " à 2 roues...";
        }
    }
}
