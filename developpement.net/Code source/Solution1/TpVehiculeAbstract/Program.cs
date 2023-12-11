using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace TpVehiculeAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();
        }
        static void Test1()
        {

            //  Vehicule v = new Vehicule("xx", 1);
            Vehicule v1 = new Voiture("b", 2000);
            Vehicule v2 = new Velo("bmx", 100);
            Vehicule v3 = new Bateau("abcd", 10000, Taille.grand);

            //  Console.WriteLine("v " + v.Avancer());
            Console.WriteLine("v1 " + v1.Avancer());
            Console.WriteLine("v2 " + v2.Avancer());
            Console.WriteLine("v3 " + v3.Avancer());


        }

        static void Test2()
        {

            Vehicule[] tab = {  new Voiture("b", 2000),
            new Velo("bmx", 100),new Bateau("abcd", 10000, Taille.grand)};

            foreach (Vehicule x in tab)
                Console.WriteLine(x);


        }

    }
}
