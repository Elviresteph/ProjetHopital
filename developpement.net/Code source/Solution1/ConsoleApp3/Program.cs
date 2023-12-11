using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
       
        static void Main(string[] args)
        {
            TestCalculate();
        }
        static void TestCalculate()
        {
            int x = 10;
            int y = 15;

            int s;
            int d;

            Calculate(x, y, out s, out d);
            Console.WriteLine(x + "   " + y + "   " + s + "   " + d);
        }
        static void Calculate(int a, int b, out int somme, out int difference)
        {
            somme = a + b;
            difference = a - b;
        }
        static void TestSwap1()
        {
            int nb1 = 10;
            int nb2 = 20;
            Console.WriteLine(nb1 + "      " + nb2);
            Swap(ref nb1, ref nb2);
            Console.WriteLine(nb1 + "      " + nb2);
        }

        static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;

        }

        static void TestSwap()
        {
            int nb1 = 10;
            int nb2 = 20;
            Console.WriteLine(nb1 + "      " + nb2);
            Swap(nb1, nb2);
            Console.WriteLine(nb1 + "      " + nb2);
        }

        static void Swap(int a, int b)
        {
            int tmp = a;
            a = b;
            b = tmp;

        }


        static void TestCalculArticle()
        {
            Console.WriteLine("saisir marque");
            string marque = Console.ReadLine();

            Console.WriteLine("saisir prix  ht avant promo");
            double prix = Convert.ToDouble(Console.ReadLine());

            double prixttc = prix * 1.2;
            double prixfinal = prixttc * 0.75;
            Console.WriteLine("prix final   " + prixfinal);
        }
        static void TestAdd1()
        {
            //1
            double res = Add(10, 20);
            Console.WriteLine("res " + res);

            //2
            Add(10, 20);

            //3
            Console.WriteLine("res " + Add(10, 20));


        }
        static void TestAdd()
        {
            double res = Add(10, 20);
            Console.WriteLine("res " + res);

        }

        static double Add(double a, double b)
        {
            double c = a + b;
            return c;

        }
        static void TestAddition1()
        {
            Addition(10, 20);
            Addition(15.5, 35.6);

        }
        static void Addition(double a, double b)
        {
            double c = a + b;
            Console.WriteLine(c);

        }
        static void TestAddition()
        {
            Addition(10, 20);
            Addition(15, 35);

        }
        static void Addition(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);

        }
        static void TestPrintv2()
        {

            Printv2("dupond", "titi");
            Printv2("dupond", "toto");

            string nom = "DURAND";
            string prenom = "JEAN";
            Printv2(nom, prenom);

        }

        static void Printv2(string nom, string prenom)
        {
            Console.WriteLine("BONJOUR  NOM:" + nom + "    PRENOM:" + prenom);
        }
        static void TestPrint()
        {
            string nom = "jean ";
            Print("toto");
            Print("titi");
            Print(nom);
        }

        static void Print(string str)
        {
            Console.WriteLine("BONJOUR  " + str);
        }

        //user
        static void TestAffiche()
        {
            Affiche();
            Affiche();
            Affiche();


        }

        //dev
        static void Affiche()
        {
            Console.WriteLine("je suis Affiche");
        }
    }
}
