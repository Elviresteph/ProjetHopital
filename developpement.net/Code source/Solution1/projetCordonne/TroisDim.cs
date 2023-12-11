using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetCoordonnees
{
    class TroisDim : DeuxDim
    {
        private int z;


        //appel implicite ou vers un const par defaut ou vers un const implicite
        public TroisDim(int x, int y, int z) //: base()
        {

            this.x = x;
            this.y = y;
            this.z = z;
        }

        //public TroisDim() : base()
        //{

        //}


        // cest la meilleure version
        //public TroisDim(int x, int y, int z):base (x,y)
        //{

        //    //this.x = x;
        //    //this.y = y;
        //    this.z = z;
        //}

        //public TroisDim(int x, int y, int z)
        //{
        //    this.x = x;
        //    this.y = y;
        //    this.z = z;
        //}

        public override string ToString()
        {
            return base.ToString() + "    " + z;
        }

    }
}
