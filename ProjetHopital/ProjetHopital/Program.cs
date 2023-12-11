using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetHopital
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
        }

        public void test()
        {
            string login = "mps";
            string mdp = "123654";

            DaoAuthentification d = new DaoAuthentification();
            Authentification o = d.connexion(login, mdp);
            Console.WriteLine(o);
        }

        public void testMenu()
        {

        }


    }

    
}
