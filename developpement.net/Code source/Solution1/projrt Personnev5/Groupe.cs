using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Groupe
    {
        private string nom;
        private Personne[] tab;//null
        //  private Personne[] tab=new Personne[10]; 
        private const int defaut_size = 10;

        public Groupe(string nom)
        {
            this.nom = nom;
            tab = new Personne[defaut_size];
        }
        public Groupe(string nom, int taille)
        {
            this.nom = nom;
            tab = new Personne[taille];
        }

        public bool Ajouter(Personne p)
        {
            bool reponse = false;
            for (int i = 0; i < tab.Length; i++)
                if (tab[i] == null)
                {
                    tab[i] = p;
                    reponse = true;
                    break;
                }

            return reponse;

        }
        public int GetCountByNom(string nom)
        {
            int count = 0;
            foreach (Personne p in tab)
                if (p != null && p.Nom == nom)
                    count++;

            return count;
        }
        public int GetCount()
        {
            int count = 0;
            foreach (Personne p in tab)
                if (p != null)
                    count++;

            return count;
        }
        

        public override string ToString()
        {
            string reponse = nom + "\n";
            foreach (Personne p in tab)
                if (p != null)
                    reponse += p + "\n";
            return reponse;
        }
        public bool Supprimer(int id)
        {
            
            bool reponse = false;
            for (int i = 0; i < tab.Length; i++)
                if (tab[i] != null && id == tab[i].Id)
                {
                    tab[i] = null;
                    reponse = true;
                }
            return reponse;

        }
        

            

        }

    }

