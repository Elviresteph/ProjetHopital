using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetGeneric
{
    class Generic
    {
        private object a;


        public Generic(object a)
        {
            this.a = a;
        }

        public object A
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
