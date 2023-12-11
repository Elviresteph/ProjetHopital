using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoletpville
{
    public class Ville
    {

        private string nom = null;
        private string pays = null;
        private double nbHabitant = 0;

        public const double nbHabitantMin = 0;
        public const double nbHabitantMax = 10;

        //public bool isBig => nbHabitant >= 5;

        public bool isBig(double nb)
        {
            if (nb > nbHabitantMin && nbHabitant < 5)
            {
                return false;

            }
            return true;
        }

        public Ville(string nom, string pays, double nbHabitant)
        {
            this.nom = nom;
            this.pays = pays;
            this.nbHabitant = nbHabitant;

        }


        //property Age get et set
        public double NbHabitant
        {

            //lecture
            get
            {
                return nbHabitant;
            }
            //ecriture 0 et 120
            set
            {
                if (value > nbHabitantMin && value < nbHabitantMax && value > this.nbHabitant)
                    nbHabitant = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }
        }

        public string Pays
        {
            get
            {
                return pays;
            }
        }


        // Constructeur par défaut
        public Ville()
        {
        }

        // Constructeur d'initialisation avec tous les paramètres
        
        public override string ToString()
        {
            return this.nom + "   " + pays + "  " + nbHabitant + "    " + ((isBig(nbHabitant)) ? " Grand " : " Petit");
        }

        // Méthode non publique pour déterminer la taille de la ville
        /*private string TailleVille()
        {
            if (NbHabitant < 5)
                return "petite";
            else if (NbHabitant >= 5 && NbHabitant < 10)
                return "moyenne";
            else
                return "grande";
        }*/

        // Méthode pour obtenir les informations de la ville
        //public string GetInfos()
        //{
        //    //return Nom.ToLower() + " " + Pays.ToUpper() + " " + NbHabitant + "M - " + TailleVille();
        //    return nom.ToLower() + " " + pays.ToUpper() + " " + nbHabitant;
        //}
    }
}
            //return nom + " " + pays+" "+nbHabitant;
