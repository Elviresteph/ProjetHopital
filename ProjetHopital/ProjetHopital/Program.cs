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
            string login = "elvire";
            string mdp = "1234";
            //Authentification a = new Authentification(login, mdp);
            //DaoAuthentification d = new DaoAuthentification();
            //Authentification  o = d.connexion(a);


            DaoAuthentification d = new DaoAuthentification();
            Authentification o = d.connexion(login, mdp);


        }
    }
}
