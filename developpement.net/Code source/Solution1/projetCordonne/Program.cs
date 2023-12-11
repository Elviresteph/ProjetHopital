using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetCoordonnees
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();
        }
        static void Test1()
        {
           DeuxDim a = new DeuxDim(10, 20);
            Console.WriteLine(a.ToString());

            TroisDim b = new TroisDim(10, 20, 30);
            Console.WriteLine(b.ToString());

        }
    }
}
