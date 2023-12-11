using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTpVehicule2
{
    class Bateau : Vehicule
    {
        private taille taille;

        public override string Avancer()
        {
            return "je flotte";
        }
       
        public taille Taille { get; set; }

        public Bateau(string marque, double prix, taille taille) : base(marque, prix)
        {
            this.taille = taille;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Taille: {Taille}";
        }
    }
    
    

}
