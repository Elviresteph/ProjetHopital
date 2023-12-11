using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetHeritagev2
{
    class A
    {
        public void M1()
        {
            Console.WriteLine("je suis m1 de de A");
        }
        private void M2()
        {
            Console.WriteLine("je suis m2 de de A");
        }
        protected void M3()
        {
            Console.WriteLine("je suis m3 de de A");
        }
    }

    class B : A
    {

        //protected void M3()
        //{
        //    Console.WriteLine("je suis m3 de de A");
        //}

        //public void M1()
        //{
        //    Console.WriteLine("je suis m1 de de A");
        //}
        public void M4()
        {
            Console.WriteLine("je suis m4 de de B");
            M1();
            M3();
            //M2();
        }
    }
}
