using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace projetAdo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestSelectById1();
            //TestSelectAll1();
            //TestSelectByNom();
            //SelectAllOld();
            TestSelectCount();
        }
        static void TestSelectCount()
        {
            Console.WriteLine("nombre de ligne : " + DB.SelectCount());


        }
        static void TestSelectByNom()
        {
            Console.WriteLine("saisir le nom");
            string saisie = Console.ReadLine();
            Console.WriteLine(DB.SelectByNom(saisie));


        }
        static void TestSelectById1()
        {
            int id = 1;
            Console.WriteLine(DB.SelectById1(id));


        }
        static void TestSelectAll1()
        {
            Console.WriteLine(DB.SelectAll1());


        }
        static void TestSelectById()
        {
            int id = 1;
            DB.SelectById(id); ;


        }

        static void SelectAllOld()
        {
            DB.SelectAllOld();


        }
        static void TestUpdatev2()
        {
            bool reponse = DB.Updatev2(15, "AAA", "BBB", 40);
            if (reponse)
                Console.WriteLine("update OK");
            else
                Console.WriteLine("update KO");


        }

        static void TestInsertv2()
        {
            DB.Insertv2(16, "aaa", "bbbbb", 38);
        }
        static void TestInsert()
        {
            DB.Insert(15, "DURANT", "pierre", 38);
        }

        static void TestDelete()
        {
            bool reponse = DB.Delete(15);
            if (reponse)
                Console.WriteLine("delete OK");
            else
                Console.WriteLine("delete KO");



        }

        static void TestUpdate()
        {
            bool reponse = DB.Update(15, "aaa", "bbbb", 34);
            if (reponse)
                Console.WriteLine("update OK");
            else
                Console.WriteLine("update KO");


        }

        //static void Insert()
        //{
        //    string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
        //    SqlConnection connection1 = new SqlConnection(connectionString);
        //    connection1.Open();
        //    //traitement
        //    string sql = "insert into personnes values(11,'DURAND','jean',30)";
        //    SqlCommand command = new SqlCommand(sql, connection1);
        //    command.ExecuteNonQuery();

        //    Console.WriteLine("insert  ok");
        //    connection1.Close();


    }
}
