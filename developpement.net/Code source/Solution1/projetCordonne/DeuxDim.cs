using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetCoordonnees
{
    class DeuxDim
    {
        protected int x;
        protected int y;

        //private int x;
        //private int y;

        public DeuxDim(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public DeuxDim()
        {

        }

        public override string ToString()
        {
            return x + "     " + y;
        }

    }
}
