using System;using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoletpville
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------test1-----------");
            //Test1();
            Console.WriteLine("------------test2-----------");
            //Test2();
            Console.WriteLine("------------test3------------");
            Test3();
            Console.ReadKey();
        }

        // Test avec une ville
        static void Test1()
        {
            Ville paris = new Ville("Paris", "France", 9.1);
            
            Console.WriteLine(paris.ToString());
        }

        // Test avec deux villes en utilisant les constructeurs
        static void Test2()
        {
            Ville Toulouse = new Ville("Toulouse", "France", 2.3);
            Ville Nante = new Ville("Nante", "France", 3.2);
            Console.WriteLine(Toulouse.ToString());
            Console.WriteLine(Nante.ToString());
        }

        // Test avec un tableau de villes
        static void Test3()
        {
            Ville[] villes = new Ville[]
            {
                new Ville("Douala", "Cameroun", 4),
                new Ville("Yaoundé", "Cameroun", 9.3),
                new Ville("Berlin", "Allemagne", 5.3)
            };

            foreach (var ville in villes)
            {

                Console.WriteLine(ville.ToString());
            }
        }
        //{
        //    tpVille();
        //}
        //static void tpVille()
        //{
        //    Ville v1 = new Ville();
        //    v1.nom = "Paris";
        //    v1.pays = "France";
        //    v1.nbHabitant = 5.2;
        //    Console.WriteLine(v1.GetInfo());//t

        //    Ville v2 = new Ville();
        //    v2.nom = "Toulon";
        //    v2.pays = "France";
        //    v2.nbHabitant = 10;
        //    Console.WriteLine(v2.GetInfo());//t


        //}
    }
}
