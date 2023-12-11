using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTpObserver
{
    class Eleve
    {
        private string nom;
        private Prof prof;

        public Eleve(string nom, Prof prof)
        {
            this.nom = nom;
            this.prof = prof;
        }

        public void Update()
        {
            Console.WriteLine($"Notification pour l'élève {nom}: La note du professeur a été mise à jour.");
        }

        public override string ToString()
        {
            return $"{nom} - Note reçue du professeur: {prof.Note}";
        }
    }
}
