using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace projetAdo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestUpdate();
            //TestInsert();
            TestDelete();
        }
        static void TestDelete()
        {
            Delete(12);
        }
        static void Delete(int id)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connectionString);
            connection1.Open();
            //traitement
            string sql = "delete personnes where id = " + id;
            SqlCommand command = new SqlCommand(sql, connection1);
            int nb = command.ExecuteNonQuery();

            if (nb > 0)
                Console.WriteLine("delete  OK");
            else
                Console.WriteLine("delete  KO");
            connection1.Close();



        }
        static void TestUpdate()
        {
            Update(15, "aaa", "bbb", 34);
        }
        static void Update(int id, string nom, string prenom, int age)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connectionString);
            connection1.Open();
            //traitement
            string sql = "update personnes set nom = '" + nom + "',prenom='" + prenom + "',age=" + age + " where id=" + id;
            SqlCommand command = new SqlCommand(sql, connection1);
            int nb = command.ExecuteNonQuery();
            //Console.WriteLine(sql);
            if (nb > 0)
                Console.WriteLine("update  OK");
            else
                Console.WriteLine("update  KO");
            connection1.Close();



        }
        static void TestInsert()
        {
            Insert (12, "DURANT", "pierre", 38);
        }
        static void Insert(int id, string nom, string prenom, int age)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connectionString);
            connection1.Open();
            //traitement
            string sql = "insert into personnes values(" + id + ",'" + nom + "','" + prenom + "'," + age + ")";
            SqlCommand command = new SqlCommand(sql, connection1);
            command.ExecuteNonQuery();
            //Console.WriteLine(sql);
            Console.WriteLine("insert  ok");
            connection1.Close();



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



        
        
        //static void TestUpdate()
        //{
        //    string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
        //    SqlConnection connection1 = new SqlConnection(connectionString);
        //    connection1.Open();
        //    //traitement
        //    string sql = "update personnes set nom = 'aaa', prenom = 'bbb', age = 30 where id = 10";
        //    SqlCommand command = new SqlCommand(sql, connection1);
        //    command.ExecuteNonQuery();

        //    Console.WriteLine("update  ok");
        //    connection1.Close();



        //}

        
    }
}

