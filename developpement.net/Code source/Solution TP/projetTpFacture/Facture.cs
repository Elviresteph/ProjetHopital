using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTpFacture
{
    class Facture
    {
        private List<Ligne> listeDeLigne;
        private string nomClient;

        public Facture(List<Ligne> listeDeLigne, string nomClient)
        {
            this.listeDeLigne = listeDeLigne;
            this.nomClient = nomClient;
        }

        public bool ajouter(Ligne L)
        {
            listeDeLigne.Add(L);
            return true;
        }


        public override string ToString()
        {
            string reponse = "Facture client :" + nomClient + "\n";
            double prixTotal =0;

            foreach (Ligne l in listeDeLigne)
            {
                prixTotal = prixTotal + l.prixligne;
                reponse = reponse + l.ToString() + "\n";
            }

            reponse = reponse + "\n" + "total :" + prixTotal + "EUR(S)";

            return reponse;
        }
    }
}
