using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTpVehicule
{
    class Vehicule
    {
        public virtual string Avancer()
        {
            return "je roule";
        }
    }

    class Voiture : Vehicule
    {
        public override string Avancer()
        {
            return "je roule";
        }
    }

    class Velo : Vehicule
    {
        public override string Avancer()
        {
            return "je roule à 2 roues";
        }
    }

    class Bateau : Vehicule
    {
        public override string Avancer()
        {
            return "je flotte";
        }
    }
}

   