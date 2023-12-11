using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            TpParkingv1();
        }
        static void TpParkingv1()
        {
            Parking parking = new Parking("Parking A", 5);
            Voiture voiture1 = new Voiture("456bgc", "Carina", 2000);
            Voiture voiture2 = new Voiture("aaa521", "Peugeot", 25000, 150);
            parking.Ajouter(voiture1);
            parking.Ajouter(voiture2);
            Console.WriteLine(parking.ToString());
            parking.Supprimer ("456bgc");
            Console.WriteLine(parking.ToString());
        }
    }
}
