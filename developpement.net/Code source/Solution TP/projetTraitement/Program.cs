using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            tpTraitementTexte();
        }
            static void tpTraitementTexte()
            {
                Console.Write("Saisissez une phrase : ");
                string phrase = Console.ReadLine();
                string reponse = traitementText(phrase);
                Console.Write("reponse: " + reponse.ToUpper());
                Console.WriteLine();

            }

           
    }
    }

