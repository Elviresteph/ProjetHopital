using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTpFacture
{
    class Ligne
    {
        private abstract_Article Article;
        private int quantite;
        public double prixligne;

        public Ligne(abstract_Article Article, int quantite)
        {
            this.Article = Article;
            this.quantite = quantite;
            this.prixligne = quantite * Article.prix;
        }


        public override string ToString()
        {
            string reponse = "Quantité:" + quantite + " - " + Article.ToString() + " - " + prixligne + "eur(s)";

            return reponse;
        }
    }
}
