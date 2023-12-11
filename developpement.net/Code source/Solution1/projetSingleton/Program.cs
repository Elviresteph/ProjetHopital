using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();
        }
        static void Test1()
        {
            //Singleton s1 = new Singleton();

            //Singleton s2 = new Singleton();
            //s1.M1();

            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;

            s1.M1();
            s2.M1();
        }
       
    }
}
