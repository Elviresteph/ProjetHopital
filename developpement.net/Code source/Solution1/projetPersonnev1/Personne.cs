using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetPersonnev1
{
    class Personne
    {
        //attributs --variable global --variable de la classe
        public string nom;//null != ""
        public string prenom;
        public int age;//0


        //constructeur:
        //1. implicite non codé
        //2. constructeur par defaut: sans parametre

        public Personne()
        {
            // Console.WriteLine("coucou");
        }
        //3.constr d initialisation: avec parametres
        public Personne(string n, string p, int a)
        {
            nom = n;
            prenom = p;
            age = a;
        }
        public Personne(string n, string p)
        {
            nom = n;
            prenom = p;
            
        }


        //methodes-- (properties getter/setter)
        public string GetInfo()
        {
            string reponse = "";
            reponse += (nom == null) ? " NOM NULL" : nom + "  ";
            reponse += (prenom == null) ? " PRENOM NULL" : prenom + "  ";
            reponse += "  " + age;
            return reponse;
        }
    }
}
