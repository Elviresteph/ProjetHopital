using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetHeritagev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test5();
        }
        //static void Test4()
        //{
        //    A monA = new A();
        //    Console.Writeline (monA.ToString());
        //}
        static void Test5()
        {

            A monA = new A();
            B monB = new B();
            C monC = new C();
            D monD = new D();

            monA.P();//je suis p de A
            monB.P();//je suis  de B
            monC.P();//je suis p de A
            monD.P();// je suis p de B je suis p de D

        }
        static void Test3()
        {

            A monA = new A();
            B monB = new B();


            monA.M();
            monB.M();

            monA.P();
            monB.P();


        }
        static void Test2()
        {

            A monA = new A();
            B monB = new B();
            C monC = new C();
            D monD = new D();
            monD.M1();
            monD.M2();
            monD.M4();

            

        }
    }
}
