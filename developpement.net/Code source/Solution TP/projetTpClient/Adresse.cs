using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Adresse
    {
        private string rue;
        private string ville;
        private string pays;

        public Adresse()
        {

        }

        public Adresse(string rue, string ville, string pays)
        {
            this.rue = rue;
            this.ville = ville;
            this.pays = pays;
        }
        public string Rue
        {

            get
            {
                return rue;
            }
            set
            {
                rue = value;
            }
        }

        public override string ToString()
        {
            return ville + "  " + rue + "  " + pays;
        }
    }
}
