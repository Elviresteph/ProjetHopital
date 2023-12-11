using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetHeritagev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();
        }
        static void Test1()
        {
            A monA = new A();
            monA.M1();

            B monB = new B();
            monB.M4();

        }
    }
}
