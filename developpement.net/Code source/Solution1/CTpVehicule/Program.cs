using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTpVehicule
{
    class Program
    {
        static void Main(string[] args)
        {
            Test3();
        }
        static void Test11()
        {

            Vehicule v = new Vehicule("xx", 1);
            Voiture v1 = new Voiture("b", 2000);
            Velo v2 = new Velo("bmx", 100);
            Bateau v3 = new Bateau("abcd", 10000, Taille.grand);

            TestAvancer(v);
            TestAvancer(v1);
            TestAvancer(v2);
            TestAvancer(v3);

        }

        static void TestAvancer(Vehicule x)
        {
            Console.WriteLine(x.Avancer());
        }
        static void Test7bis()
        {

            Vehicule v = new Vehicule("xx", 1);
            Voiture v1 = new Voiture("b", 2000);
            Velo v2 = new Velo("bmx", 100);
            Bateau v3 = new Bateau("abcd", 10000, Taille.grand);

            Vehicule[] tab = new Vehicule[4];
            tab[0] = v;
            tab[1] = v1;
            tab[2] = v2;
            tab[3] = v3;

            foreach (Vehicule x in tab)
                Console.WriteLine(x.Avancer());


        }

        static void Test10()
        {

            Object[] tab = { new Vehicule("xx", 1), new Voiture("b", 2000),
            new Velo("bmx", 100),new Bateau("abcd", 10000, Taille.grand)};

            foreach (Object x in tab)
                Console.WriteLine(x.ToString());


        }
        static void Test9()
        {

            Vehicule[] tab = { new Vehicule("xx", 1), new Voiture("b", 2000),
            new Velo("bmx", 100),new Bateau("abcd", 10000, Taille.grand)};

            foreach (Vehicule x in tab)
                Console.WriteLine(x);


        }

        static void Test8()
        {

            Vehicule[] tab = { new Vehicule("xx", 1), new Voiture("b", 2000),
            new Velo("bmx", 100),new Bateau("abcd", 10000, Taille.grand)};

            foreach (Vehicule x in tab)
                Console.WriteLine(x.Avancer());


        }
        static void Test7()
        {

            Vehicule v = new Vehicule("xx", 1);
            Vehicule v1 = new Voiture("b", 2000);
            Vehicule v2 = new Velo("bmx", 100);
            Vehicule v3 = new Bateau("abcd", 10000, Taille.grand);

            Vehicule[] tab = new Vehicule[4];
            tab[0] = v;
            tab[1] = v1;
            tab[2] = v2;
            tab[3] = v3;

            foreach (Vehicule x in tab)
                Console.WriteLine(x.Avancer());
        }
        static void Test6()
        {

            Vehicule v = new Vehicule("xx", 1);
            Vehicule v1 = new Voiture("b", 2000);
            Vehicule v2 = new Velo("bmx", 100);
            Vehicule v3 = new Bateau("abcd", 10000, Taille.grand);

            Console.WriteLine("v " + v.Avancer());
            Console.WriteLine("v1 " + v1.Avancer());
            Console.WriteLine("v2 " + v2.Avancer());
            Console.WriteLine("v3 " + v3.Avancer());


        }
        static void Test5()
        {
            Voiture v1 = new Voiture("bmw", 1000);

            Voiture v2 = v1;
            v2.GpsONOff();
            Console.WriteLine(v1);
            Console.WriteLine(v2);

            Vehicule v3 = v2;// cast implicite on n a plus acces a gpsOnOff

            Voiture v4 = (Voiture)v3; //cast explicite
            v4.GpsONOff();

        }
        static void Test4()
        {
            Voiture v1 = new Voiture("a", 1000);
            v1.GpsONOff();

            Vehicule v2 = new Voiture("b", 2000);


            //  Voiture v3 = new  Vehicule("b", 2000);

        }
        static void Test3()
        {
            Velo velo = new Velo("Honda", 500);
            Console.WriteLine(velo.Avancer());
            Console.WriteLine(velo);
            Bateau b1 = new Bateau("Rhapsody", 2000000, Taille.grand);
            Console.WriteLine(b1.Avancer());
            Console.WriteLine(b1);
            Bateau b2 = new Bateau("Beneteau", 10000, Taille.petit);
            Console.WriteLine(b2);
            Bateau b3 = new Bateau("Malibu", 80000, Taille.moyen);
            Console.WriteLine(b3);

        }
        static void Test2()
        {
            Voiture v = new Voiture("Renault", 20000);
            Console.WriteLine(v);
            v.GpsONOff();
            Console.WriteLine(v);
            v.GpsONOff();
            Console.WriteLine(v);
            Console.WriteLine(v.Avancer());
        }
    }
}
