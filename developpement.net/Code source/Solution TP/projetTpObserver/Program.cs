using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTpObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            TpObserver();
        }
        static void TpObserver()
        { 
        Prof p = new Prof("Jacky");

        Eleve e1 = new Eleve("e1", p);
        Eleve e2 = new Eleve("e2", p);
        Eleve e3 = new Eleve("e3", p);

        p.Abo(e1);
        p.Abo(e2);

        Console.WriteLine(e1);
        Console.WriteLine(e2);
        Console.WriteLine(e3);
        Console.WriteLine("--------------------------------");

        p.Note = 18;

        Console.WriteLine(e1);
        Console.WriteLine(e2);
        Console.WriteLine(e3);
    }
}
}
