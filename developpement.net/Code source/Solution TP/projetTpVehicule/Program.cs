using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTpVehicule
{
    class Program
    {
        static void Main(string[] args)
        {
            TpVhicule();
        }
        static void TpVhicule()
        {
            // Instanciation des différentes classes
            Voiture voiture = new Voiture();
            Velo velo = new Velo();
            Bateau bateau = new Bateau();
            Console.WriteLine(voiture.Avancer());
            Console.WriteLine(velo.Avancer());
            Console.WriteLine(bateau.Avancer());


        }
    }
}
