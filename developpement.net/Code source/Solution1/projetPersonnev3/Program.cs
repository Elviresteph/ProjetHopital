using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetPersonnev3
{
    class Program
    {
        static void Main(string[] args)
        {
            Test3();
        }
        static void Test3()
        {
            Personne p1 = new Personne("dupond", "toto", 10);
            Console.WriteLine(p1);

            p1.Age = 18;
            p1.Age = 17;
            Console.WriteLine(p1);



        }
        static void Test2()
        {
            Personne p1 = new Personne();
            Console.WriteLine(p1);




        }
        static void Test1()
        {
            Personne p1 = new Personne("dupond", "toto", 10);
            //appel explicite
            Console.WriteLine(p1.ToString());
            string str1 = p1.ToString();

            //appel implicite
            Console.WriteLine(p1);
            string str2 = p1 + "";



        }

    }
}
