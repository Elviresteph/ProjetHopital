using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTpVehicule
{
    class Voiture : Vehicule
    {
        private bool gps;

        public Voiture(string marque, double prix) : base(marque, prix)
        {
        }
        public void GpsONOff()
        {
            gps = !gps;
        }
        public override string ToString()
        {
            string str;
            if (gps)
                str = "allumé";
            else
                str = "éteint";
            return base.ToString() + " avec le gps " + str;
        }
    }
}
