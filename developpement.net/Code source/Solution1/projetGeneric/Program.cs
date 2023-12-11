using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Test7();
        }
        static void Test7()
        {

            Generix<int, string> x = new Generix<int, string>(10, "toto");

            Console.WriteLine(x.A + "    " + x.B);

        }

        static void Test6()
        {
            Personne p = new Personne("bb", "ccc", 10);

            Generique<Personne> x = new Generique<Personne>(p);
            Personne p2 = x.A;
            Console.WriteLine(p2.Nom);

        }


        static void Test5()
        {

            Generique<int> x = new Generique<int>(2);
            int nb = x.A;
            Console.WriteLine(x.A);

        }
        static void Test3()
        {


            Generic x = new Generic(new Personne("bb", "ccc", 10));
            // Personne p1 = x.A;
            Personne p = (Personne)x.A;
            object o = x.A;
            Console.WriteLine(o.ToString());


        }
        static void Test2()
        {

            Generic x1 = new Generic(10);
            Generic x2 = new Generic(new Personne("bb", "ccc", 10));
            Console.WriteLine(x1.A);
            Console.WriteLine(x2.A);


        }
        static void Test1()
        {

            Generic x = new Generic(10);
            Console.WriteLine(x.A);

        }
    }
}
