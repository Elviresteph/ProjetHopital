using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Parking
    {
        private string nom;
        private Voiture[] tab;
        private  int taille;

        public Parking()
        {
        }

        public Parking(string nom, int taille)
        {
            this.nom = nom;
            this.taille = taille;
            tab = new Voiture[taille];
        }

        public override string ToString()
        {
            string reponse = "nom: " + nom + " " + "taille: " + taille +  "\n";
            foreach (Voiture v in tab)
                if (v != null)
                    reponse += "Vitesse: " + v.Vitesse + " " + "Matricule: " + v.Matricule + " " + "Prix: " + v.Prix + " " + "Marque: " + v.Marque + "\n";
            return reponse;
        }

        public bool Ajouter(Voiture v)
        {
            bool reponse = false;
            for (int i = 0; i < tab.Length; i++)
                if (tab[i] == null)
                {
                    tab[i] = v;
                    v.Vitesse = 0;
                    reponse = true;
                    break;
                }

            return reponse;

        }

        public bool Supprimer(string Matricule)
        {
            bool reponse = false;
            for (int i = 0; i < tab.Length; i++)
                if (tab[i] != null && Matricule == tab[i].Matricule)
                {
                    tab[i] = null;
                    reponse = true;
                    break;
                }
            return reponse;
        }

    }
}
