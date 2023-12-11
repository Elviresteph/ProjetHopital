using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetSingleton
{
    class Singleton
    {
        ////etape 2 a
        //private static Singleton instance = new Singleton();

        //etape 2 b
        private static Singleton instance = null;


        // etape 1
        private Singleton()
        {

        }

        ////etape 3 a
        //public static Singleton Instance
        //{
        //    get
        //    {
        //        return instance;
        //    }
        //}


        //etape 3 b
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
        public void M1()
        {
            Console.WriteLine("je suis M1 d instance");
        }
    }
}
