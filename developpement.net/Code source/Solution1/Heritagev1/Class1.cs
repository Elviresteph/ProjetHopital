using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetHeritagev1
{
    class A
    {
        public void M1()
        {
            Console.WriteLine("je suis m1 de A");
        }
        public void M()
        {
            Console.WriteLine("je suis m de A");
        }

        public virtual void P()
        {
            Console.WriteLine("je suis p de A");
        }

        public override string ToString()
        {
            return "je suis la TS de A";
        }

    }

    class B : A
    {
        public void M2()
        {
            Console.WriteLine("je suis m2 de B");
        }
       
        //override

        public override void P()
        {
            Console.WriteLine("je suis p de B");
        }
        public void M()
        {
            Console.WriteLine("je suis m de B");
        }
        //public override void P()
        //{
        //    Console.WriteLine("je suis p de B");
        //}
    }
    class C : A
    {
        public void M3()
        {
            Console.WriteLine("je suis m3 de C");
        }
    }
    class D : B
    {
        public void M4()
        {
            Console.WriteLine("je suis m4 de D");
        }
        public override void P()
        {
            base.P();
            Console.WriteLine("je suis p de D");

        }
    }

}
