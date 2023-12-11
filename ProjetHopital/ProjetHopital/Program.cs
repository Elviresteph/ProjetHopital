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
           //testMenu();

            //string login = "mps";
            //string mdp = "123654";
            //string nom = "Elvire Stephanie";
            //int metier = 1;
            DaoAuthentification d = new DaoAuthentification();
            // Authentification aut = new Authentification(login, mdp, nom, metier);
            //d.Update(aut);

            List<Authentification> list =  d.SelectAll();
            foreach (Authentification p in list)
                Console.WriteLine(p.login + "\t" + p.metier + "\t" + p.nom + "\t" + p.password);


        }

        public void test()
        {
            //string login = "mps";
            //string mdp = "123654";

            //DaoAuthentification d = new DaoAuthentification();
            //Authentification o = d.connexion(login, mdp);
            //Console.WriteLine(o);
        }

        public void testMenu()
        {
            Console.WriteLine("vous êtes");
            Console.WriteLine("1 - medecin");
            Console.WriteLine("2- sécretaire");         
            Console.WriteLine("Veillez entrer votre choix:");
            Console.WriteLine("Bienvenue à l'hopital");
        }


    }

    
}
