using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetHopital
{
    class Visite
    {
        private int id;
        private int idpatient;
        private string date;
        private Medecin medecin;
        private int num_salle;
        private int tarif;

        public Visite(int id, int idpatient, string date, Medecin medecin, int num_salle, int tarif)
        {
            this.idpatient = idpatient;
            this.date = date;
            this.medecin = medecin;
            this.num_salle = num_salle;
            this.tarif = tarif;
            this.id = id;
        }
        public Visite()
        {

        }

        public int Id
        {
            get
            {
                return id;
            }
        }
        public int Idpatient
        {
            get
            {
                return idpatient;
            }
        }

        public Medecin Medecin
        {
            get
            {
                return medecin;
            }
        }

        public int Num_salle
        {
            get
            {
                return num_salle;
            }
        }

        public int Tarif
        {
            get
            {
                return tarif;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }
        }
        public override string ToString()
        {

            return id + "    " + idpatient + "    " + date + "    " + medecin + "   " + num_salle + "   " + tarif;
        }
    }
}
