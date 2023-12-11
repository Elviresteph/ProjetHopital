using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetGeneric
{
    class Generix<X, Y>
    {
        private X a;
        private Y b;

        public Generix(X a, Y b)
        {
            this.a = a;
            this.b = b;
        }

        public X A
        {
            get
            {
                return a;
            }
        }

        public Y B
        {
            get
            {
                return b;
            }
        }


    }
}
