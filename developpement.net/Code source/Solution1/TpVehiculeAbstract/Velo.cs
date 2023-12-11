using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Velo : Vehicule
    {
        public Velo(string marque, double prix) : base(marque, prix)
        {

        }
        public override string Avancer()
        {
            return " je roule a 2 roues";
        }

    }
}
