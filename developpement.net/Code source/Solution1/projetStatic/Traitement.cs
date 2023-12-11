using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetStatic
{
    class Traitement
    {
        //mrthode static = de classe
        public static void M1()
        {
            Console.WriteLine("je suis M1 static");
            M2();
        }
        public static void M2()
        {
            Console.WriteLine("je suis M2 static");
        }
        //methode non static = d'instance
        public void M3()
        {
            Console.WriteLine("je suis M3 non static");
            M4();
        }
        public void M4()
        {
            Console.WriteLine("je suis M4 non static");
            M2();
        }
    }
}
