using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTpVehicule
{
    class Velo : Vehicule
    {
        public Velo(string marque, double prix) : base(marque, prix)
        {

        }
        public override string Avancer()
        {
            return base.Avancer() + " a 2 roues";
        }

    }
}
