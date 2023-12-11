using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetPersonnev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Test3();
        }
        static void Test3()
        {

            Personne p1 = new Personne("dupond", "toto", 15);
            p1.Age = 123;
            Console.WriteLine(p1.Nom);
            Console.WriteLine(p1.Prenom);
            Console.WriteLine(p1.GetInfo());


        }
        static void Test2()
        {

            Personne p1 = new Personne("aa", "bb", 125);

            Console.WriteLine(p1.Age);


        }

        static void Test1()
        {

            Personne p1 = new Personne("aa", "bb", 10);
            p1.Age = 10;
            Console.WriteLine(p1.Age);
            p1.Age = 121;
            Console.WriteLine(p1.Age);




        }
    }
}
