using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Class1
    {
        public static string traitementText(string str)
        {
            string[] mots = str.Split(' ');
            string[] tabStringReverse = Reverse(mots);
            string reponse = "";

            foreach (string e in tabStringReverse)
            {
                reponse = reponse + " " + e;
            }
            return reponse;
        }
        static string[] Reverse(string[] x)
        {
            string[] y = new string[x.Length];

            for (int i = 0; i < y.Length; i++)
                y[i] = x[(y.Length - 1) - i];
            return y;

        }
    }
}
