using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetEnumere
{
    class Program
    {
        static void Main(string[] args)
        {
            Test4();
        }
        static void Test4()
        {
            Console.WriteLine("java csharp cpp pyhton");
            string choix = Console.ReadLine();

            Formation f = (Formation)Enum.Parse(typeof(Formation), choix);

            Console.WriteLine("prix   " + (int)f);
        }
        static void Test3()
        {
            string nom = Formation.csharp.ToString();
            int prix = (int)Formation.csharp;
            Console.WriteLine(nom + "     " + prix);
        }
        static void Test2()
        {
            int a = (int)Civilite.mme;
            Console.WriteLine(a);
        }
        static void Test1()
        {
            Console.WriteLine(Civilite.mme.ToString());
            string str = Civilite.mr + "";

            Civilite x = Civilite.mr;
            Civilite y = Civilite.mr;

            Console.WriteLine(x.ToString());

        }
    }
}
