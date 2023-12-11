using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetHopital
{
    class Program
    {
        static void Main(string[] args)
        {
            testConnexion();
            TestInsert();
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
