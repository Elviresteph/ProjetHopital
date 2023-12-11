using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Test6();
        }
        static void Test6()
        {
            Personne p1 = new Personne("toto", 10);
            Personne p2 = new Personne();
            new Personne();

            Console.WriteLine(Personne.Compteur);


        }
        static void Test5()
        {
          
            Console.WriteLine(Personne.ageMax);


        }
        static void Test4()
        {
            Personne p1 = new Personne("toto", 10);
            Personne p2 = new Personne("titi", 10);
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Console.WriteLine("----------------------");
            Personne.Nom = "DURAND";
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());

        }
        static void Test2()
        {
            Personne p1 = new Personne("toto", 10);
            Personne p2 = new Personne("titi", 10);
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
        }
        static void Test1()
        {
            Traitement.M1();
            Traitement.M1();

            Traitement t = new Traitement();
            t.M3();
            t.M4();
        }
    }
}
