using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTpVehicule2
{
    class Voiture : Vehicule
    {
        private bool gpsAllume;

        public Voiture(string marque, double prix) : base(marque, prix)
        {
        }

        public void GpsOnOff()
        {
            gpsAllume = !gpsAllume; 
        }

        public override string Avancer()
        {
            return "Je roule en voiture";
        }

        public override string ToString()
        {
            string gpsStatus = gpsAllume ? "Allumé" : "Éteint";
            return  base.ToString() + " " + "GPS :" + gpsStatus;
        }
    }
}
