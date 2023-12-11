using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTpCompte
{
    class Program
    {
        static void Main(string[] args)
        {
            TpCompte();
        }
        static void TpCompte()
        {
            //CompteSimple s1 = new CompteSimple("Elvire", 10003);
            //CompteSimple s2 = new CompteSimple("Marie");

            //Console.WriteLine(s1); 
            //Console.WriteLine(s2);

            //s1.virement(500,s2);

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);

            compteCB s3 = new compteCB("Elvire", 1000, CB.VISA);
            Console.WriteLine(s3);
            s3.debiter(30);
            Console.WriteLine(s3);
        }
    }
}
