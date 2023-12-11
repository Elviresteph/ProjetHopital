using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace projetAdo1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDelete();
        }
        static void TestDelete()
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connectionString);
            connection1.Open();
            //traitement
            string sql = "delete personnes where id = 11";
            SqlCommand command = new SqlCommand(sql, connection1);
            command.ExecuteNonQuery();

            Console.WriteLine("delete  ok");
            connection1.Close();



        }
        static void TestUpdate()
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connectionString);
            connection1.Open();
            //traitement
            string sql = "update personnes set nom = 'aaa', prenom = 'bbb', age = 30 where id = 10";
            SqlCommand command = new SqlCommand(sql, connection1);
            command.ExecuteNonQuery();

            Console.WriteLine("update  ok");
            connection1.Close();



        }

        static void TestInsert()
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connectionString);
            connection1.Open();
            //traitement
            string sql = "insert into personnes values(11,'DURAND','jean',30)";
            SqlCommand command = new SqlCommand(sql, connection1);
            command.ExecuteNonQuery();

            Console.WriteLine("insert  ok");
            connection1.Close();



        }
        static void testConnexion()
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("test connexion ok");
            connection.Close();
        }
    }
}
