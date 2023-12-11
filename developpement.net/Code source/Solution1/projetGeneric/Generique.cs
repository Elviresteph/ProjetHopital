using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetGeneric
{
    class Generique<T>
    {
        private T a;


        public Generique(T a)
        {
            this.a = a;
        }

        public T A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
    }
}
