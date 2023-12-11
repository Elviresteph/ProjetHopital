using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTpCommande
{
    class Program
    {
        static void Main(string[] args)
        {
            TpCommande2();
        }
        static void TpCommande1()
        {
            Commande C = new Commande("tata", Boisson.coca, Plat.dujour, Dessert.gateau);
            Console.WriteLine(C);
        }
        static void TpCommande2()
        {
            Console.WriteLine("comment vous vous appelez?");
            string client = Console.ReadLine();
            Console.WriteLine("choisissez une boisson: eau, coca ou jus");
            string boisson = Console.ReadLine();
            Boisson b = (Boisson)Enum.Parse(typeof(Boisson), boisson);
            Console.WriteLine("choisissez un plat: dujour ou sandwitch");
            string plat = Console.ReadLine();
            Plat p = (Plat)Enum.Parse(typeof(Plat), plat);
            Console.WriteLine("choisissez un dessert: gateau ou glace");
            string dessert = Console.ReadLine();
            Dessert d = (Dessert)Enum.Parse(typeof(Dessert), dessert);
            Commande C = new Commande(client, b, p, d);

            Console.WriteLine("---------------------------");

            Console.WriteLine(C);
        }
    }
}
