using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace ConsoleCalcul
{
    class Program
    {
        static void Main(string[] args)
        {
            TpCalcul();
        }
        static void TpCalcul()
        {
            Console.WriteLine("Calculatrice élémentaire");
            Console.Write("nb1: ");
            double nb1 = double.Parse(Console.ReadLine());
            Console.Write("nb2: ");
            double nb2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Choisissez votre opérateur parmis les suivants: + - * / ");
            string op = Console.ReadLine();
            Console.WriteLine(Mathematique.Calcul(nb1, nb2, op));

        }
    }
}
