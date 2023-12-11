using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace projet_Personnev5
{
    class Program
    {
        static void Main(string[] args)
        {
            Test4();
        }
        static void Test4()
        {
            Groupe g1 = new Groupe("AJC AIRE C#");
            Personne p1 = new Personne(1, "dupond", "aa", 10);
            Personne p2 = new Personne(3, "dupond", "bb", 15);

            g1.Ajouter(p1);
            g1.Ajouter(p2);

            g1.Ajouter(new Personne(5, "dupond", "cc", 20));
            g1.Ajouter(new Personne(7, "durand", "dd", 25));

            Console.WriteLine(g1.GetCountByNom("dupond"));

        }
        static void Test3()
        {
            Groupe g1 = new Groupe("AJC AIRE C#");
            Personne p1 = new Personne(1, "dupond", "aa", 10);
            Personne p2 = new Personne(3, "dupond", "bb", 15);

            g1.Ajouter(p1);
            g1.Ajouter(p2);

            g1.Ajouter(new Personne(5, "dupond", "cc", 20));
            g1.Ajouter(new Personne(7, "dupond", "dd", 25));

            Console.WriteLine(g1.GetCount());

        }
        static void Test2()
        {
            Groupe g1 = new Groupe("AJC AIRE C#");
            Personne p1 = new Personne(1, "dupond", "aa", 10);
            Personne p2 = new Personne(3, "dupond", "bb", 15);
            g1.Ajouter(p1);
            g1.Ajouter(p2);
            g1.Ajouter(new Personne(5, "dupond", "cc", 20));
            g1.Ajouter(new Personne(7, "dupond", "dd", 25));
            Console.WriteLine(g1);

            Console.WriteLine("------------------------");

            int id = 1;
            bool rep = g1.Supprimer(id);
            if (rep)
                Console.WriteLine("suppression de la personne avec id " + id);
            else
                Console.WriteLine(" de la personne avec id " + id + " nexiste pas ");
                Console.WriteLine(g1);

        }

    }
    //static void Test1()
    //    {
    //        Groupe g1 = new Groupe("AJC AIRE C#", 3);
    //        Personne p1 = new Personne(1, "dupond", "aa", 10);
    //        Personne p2 = new Personne(3, "dupond", "bb", 15);

    //        g1.Ajouter(p1);
    //        g1.Ajouter(p2);

    //        g1.Ajouter(new Personne(5, "dupond", "cc", 20));
    //        g1.Ajouter(new Personne(7, "dupond", "dd", 25));

    //        Console.WriteLine(g1);

    //    }
    //    //static void Test1()
    //    //{
    //    //    Groupe g1 = new Groupe("AJC AIRE C#");
    //    //    Personne p1 = new Personne(1, "dupond", "aa", 10);
    //    //    Personne p2 = new Personne(3, "dupond", "bb", 15);

    //    //    g1.Ajouter(p1);
    //    //    g1.Ajouter(p2);

    //    //    Console.WriteLine(g1);

    //    //}
    //}
}
