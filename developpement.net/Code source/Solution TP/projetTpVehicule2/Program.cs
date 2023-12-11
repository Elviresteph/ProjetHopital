using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTpVehicule2
{
    class Program
    {
        static void Main()
        {
            Vehicule vehicule = new Vehicule("Peeugeot", 30000);
            Console.WriteLine(vehicule);
            Console.WriteLine(vehicule.Avancer());

            Console.WriteLine();

            Voiture voiture = new Voiture("Yaris", 9000);
            Console.WriteLine(voiture);
            Console.WriteLine(voiture.Avancer());
            voiture.GpsOnOff();
            Console.WriteLine(voiture.Avancer());

            Console.WriteLine();

            Velo velo = new Velo("Mancon", 1000);
            Console.WriteLine(velo);
            Console.WriteLine(velo.Avancer());

            Console.WriteLine();

            Bateau bateau = new Bateau("Bat", 50000, taille.petit);
            Console.WriteLine(bateau);
            Console.WriteLine(bateau.Avancer());
        }
    }
}
