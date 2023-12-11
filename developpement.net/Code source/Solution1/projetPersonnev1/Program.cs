using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetPersonnev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test15();
        }
        static void Test15()
        {
            Personne p1 = new Personne("dupond", "toto", 10);
            Console.WriteLine(p1.GetInfo());
            p1.age = 10;

            Console.WriteLine(new Personne("dupond", "toto", 10).GetInfo());


        }
        static void Test14()
        {

            Personne[] tab = {
             new Personne("dupond","a",10),
             new Personne("dupond","b",10),
             new Personne("dupond","c",10)};
            for (int i = 0; i < tab.Length; i++)
                if (tab[i] != null)
                    Console.WriteLine(tab[i].GetInfo());





        }
        static void Test13()
        {
            Personne p1 = new Personne();
            Personne p2 = new Personne("dupond", "toto", 10);
            Personne p3 = new Personne("dupond", "titi");
            Console.WriteLine(p1.GetInfo());
            Console.WriteLine(p2.GetInfo());
            Console.WriteLine(p3.GetInfo());
            p3.age = 25;
            Console.WriteLine(p3.GetInfo());
        }
        static void Test12()
        {
            Personne p1 = new Personne();
            Personne p2 = new Personne("dupond", "toto", 10);
            Console.WriteLine(p1.GetInfo());
            Console.WriteLine(p2.GetInfo());
        }
        static void Test11()
        {
            Personne p1 = new Personne();
            p1.nom = "dupond";
            p1.prenom = "a";
            p1.age = 10;


            Personne p2 = new Personne();
            p2.nom = "dupond";
            p2.prenom = "b";
            p2.age = 15;

            Personne p3 = new Personne();
            p3.nom = "dupond";
            p3.prenom = "c";
            p3.age = 20;

            Personne[] tab = { p1, p2, null, p3 };
            for (int i = 0; i < tab.Length; i++)
                if (tab[i] != null)
                    Console.WriteLine(tab[i].GetInfo());





        }
        static void Test10()
        {
            Personne p1 = new Personne();
            p1.nom = "dupond";
            p1.prenom = "a";
            p1.age = 10;


            Personne p2 = new Personne();
            p2.nom = "dupond";
            p2.prenom = "b";
            p2.age = 15;

            Personne p3 = new Personne();
            p3.nom = "dupond";
            p3.prenom = "c";
            p3.age = 20;

            Personne[] tab = new Personne[3];
            tab[0] = p1;
            tab[1] = p2;
            tab[2] = p3;

            for (int i = 0; i < tab.Length; i++)
                if (tab[i] != null)
                    Console.WriteLine(tab[i].GetInfo());




        }
        static void Test9()
        {
            Personne p1 = new Personne();
            p1.nom = "dupond";
            p1.prenom = "titi";
            p1.age = 10;
            Personne p2 = p1;
            p1 = null;
            p2 = null;

            if (p1 != null)
                Console.WriteLine(p1.GetInfo());
            else
                Console.WriteLine("p1 null");

            if (p2 != null)
                Console.WriteLine(p2.GetInfo());
            else
                Console.WriteLine("p2 null");


            //Console.WriteLine(p1.GetInfo());
            //Console.WriteLine(p2.GetInfo());


        }
        static void Test8()
        {
            Personne p1 = new Personne();
            p1.nom = "dupond";
            p1.prenom = "titi";
            p1.age = 10;
            Console.WriteLine(p1.GetInfo());

            p1 = new Personne();
            Console.WriteLine(p1.GetInfo());

        }
        static void Test7()
        {
            Personne p1 = new Personne();
            p1.nom = "dupond";
            p1.prenom = "titi";
            p1.age = 10;
            Personne p2 = p1;


            p1 = null;
            p1 = p2;
            Console.WriteLine("-------------------------");

            Console.WriteLine(p2.GetInfo());
            Console.WriteLine(p1.GetInfo());


        }
        static void Test6()
        {
            Personne p1 = new Personne();
            p1.nom = "dupond";
            p1.prenom = "titi";
            p1.age = 10;
            Personne p2 = p1;

            Console.WriteLine(p1.GetInfo());
            Console.WriteLine(p2.GetInfo());

            p1 = null;
            p2 = null;
            Console.WriteLine("-------------------------");

            Console.WriteLine(p2.GetInfo());
            Console.WriteLine(p1.GetInfo());


        }
        static void Test5()
        {
            Personne p1 = new Personne();
            p1.nom = "dupond";
            p1.prenom = "titi";
            p1.age = 10;
            Personne p2 = p1;

            Console.WriteLine(p1.GetInfo());
            Console.WriteLine(p2.GetInfo());


        }
        static void Test4()
        {
            Personne p1 = new Personne();
            Console.WriteLine(p1.GetInfo());//t

            Personne p2 = new Personne();
            p2.nom = "dupond";
            p2.prenom = "titi";
            p2.age = 10;
            Console.WriteLine(p2.GetInfo());//t


        }
        static void Test3()
        {
            Personne p1 = new Personne();
            p1.nom = "dupond";
            p1.prenom = "toto";
            p1.age = 10;
            Console.WriteLine(p1.GetInfo());//t

            Personne p2 = new Personne();
            p2.nom = "dupond";
            p2.prenom = "titi";
            p2.age = 10;
            Console.WriteLine(p2.GetInfo());//t


        }
    }
    //static void Test2()
    //    {
    //        Personne p = new Personne();
    //        p.nom = "dupond";
    //        p.prenom = "toto";
    //        p.age = 10;
    //        Console.WriteLine(p.GetInfo());

    //    }
    }

