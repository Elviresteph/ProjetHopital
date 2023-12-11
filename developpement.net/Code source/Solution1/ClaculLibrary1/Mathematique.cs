using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Mathematique
    {
        public static double Calcul(double nb1, double nb2, string op)
        {
            switch (op)
            {
                case "+":
                    return (Add(nb1, nb2));
                case "-":
                    return (Sub(nb1, nb2));
                case "*":
                    return (Mult(nb1, nb2));
                case "/":
                    return (Div(nb1, nb2));


            }
            return 0;
        }
        static double Add(double nb1, double nb2)
        {
            return nb1 + nb2;
        }
        static double Sub(double nb1, double nb2)
        {
            return nb1 - nb2;
        }
        static double Mult(double nb1, double nb2)
        {
            return nb1 * nb2;
        }
        static double Div(double nb1, double nb2)
        {

            return nb1 / nb2;
        }
    }
}
