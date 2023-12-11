using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace projetTpDbArticle
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestInsertv1();
            //UpdateDurv1();
            //TestDeleteDur();
            //TestSelectAll1();
            //TestSelectById1();
            //SelectByPrixBetween();
            //SelectByPrixPGQ();
            SelectByMarqueLike();
            //SelectCount();
        }
        static void SelectCount()
        {
            Console.WriteLine("nombre de ligne : " + DB.SelectCount());


        }
        static void SelectByMarqueLike()
        {
            Console.WriteLine(DB.SelectByMarqueLike("no"));
        }
        static void SelectByPrixPGQ()
        {
            Console.WriteLine(DB.SelectByPrixPGQ(100));
        }
        static void SelectByPrixBetween()
        {
            Console.WriteLine(DB.SelectByPrixBetween(150, 699));
        }
        static void TestSelectById1()
        {
            int reference = 1;
            Console.WriteLine(DB.SelectById1(reference));


        }
        static void TestSelectAll1()
        {
            Console.WriteLine(DB.SelectAll1());


        }
        static void TestInsertv1()
        {
            DB.InsertDurv1(12, "cok", 252);
        }
        static void TestInsertDur()
        {
            DB.InsertDur(11, "Nothing", 699);
        }

        
        static void UpdateDurv1()
        {
            bool reponse = DB.UpdateDurv1(12, "AAA", 250);
            if (reponse)
                Console.WriteLine("update OK");
            else
                Console.WriteLine("update KO");
        }
       
        static void TestDeleteDur()
        {
            bool reponse = DB.DeleteDur(12);
            if (reponse)
                Console.WriteLine("delete OK");
            else
                Console.WriteLine("delete KO");
        }
        
    }
}
