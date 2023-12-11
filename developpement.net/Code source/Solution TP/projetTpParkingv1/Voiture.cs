using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Voiture
    {
        private int vitesse;
        private string matricule;
        private string marque;
        private double prix;

        public int Vitesse
        {
            get { return vitesse; }
            set { vitesse = (value >= 0 && value <= 300) ? value : 0; }
        }

        public string Matricule
        {
            get { return matricule; }
            
        }

        public string Marque
        {
            get { return marque; }
           
        }

        public double Prix
        {
            get { return prix; }
        }

        public Voiture(string matricule, string marque, double prix, int vitesse = 0)
        {
            this.vitesse = vitesse;
            this.matricule = matricule;
            this.marque = marque;
            this.prix = prix;
        }
    
        public override string ToString()
        {
            return "matricule: " + matricule + " " + "marque: " + marque + " "+ "prix: " + prix;
        }
    }
}
