using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Article
    {

        private int reference;
        private string marque;
        private int prix;

        public Article(int reference, string marque, int prix)
        {
            this.marque = marque;
            this.prix = prix;
            this.reference = reference;
        }
        public Article()
        {

        }

        public int Reference
        {
            get
            {
                return reference;
            }
        }
        public string Marque
        {
            get
            {
                return marque;
            }
        }

        public int Prix
        {
            get
            {
                return prix;
            }
        }


        public override string ToString()
        {

            return reference + "    " + marque + "    " + prix;
        }
    }
}
