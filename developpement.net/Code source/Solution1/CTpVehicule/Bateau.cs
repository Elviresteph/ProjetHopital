using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTpVehicule
{
    class Bateau : Vehicule
    {
        Taille taille;
        public Bateau(string marque, double prix, Taille taille) : base(marque, prix)
        {
            this.taille = taille;
        }

        public override string Avancer()
        {
            return "je flotte";
        }
        public override string ToString()
        {
            return base.ToString() + " de capacité " + (int)taille + " personnes";
        }

    }
    enum Taille
    {
        petit = 2,
        moyen = 4,
        grand = 10
    }

}
