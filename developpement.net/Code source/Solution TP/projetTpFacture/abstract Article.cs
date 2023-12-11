using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTpFacture
{
    class abstract_Article
    {
        private string nom;
        public double prix;

        public abstract_Article(string nom, double prix)
        {
            this.nom = nom;
            this.prix = prix;
        }


        public override string ToString()
        {
            string reponse = nom + ":" + prix + " EUR";

            return reponse;
        }
    }
}

