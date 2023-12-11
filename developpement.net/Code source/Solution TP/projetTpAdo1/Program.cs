using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace projetTpAdo1
{
    class Program
    {
        static void Main(string[] args)
        {
            DeleteArticles();
        }
        static void DeleteArticles()
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connectionString);
            connection1.Open();
            //traitement
            string sql = "delete articles where reference = 5";
            SqlCommand command = new SqlCommand(sql, connection1);
            command.ExecuteNonQuery();

            Console.WriteLine("delete  ok");
            connection1.Close();
        }

        static void UpdateArticles()
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connectionString);
            connection1.Open();
            //traitement
            string sql = "update articles set marque = 'itel', prix = 550 where reference = 5";
            SqlCommand command = new SqlCommand(sql, connection1);
            command.ExecuteNonQuery();

            Console.WriteLine("update  ok");
            connection1.Close();
        }

        static void InsertArticles()
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connectionString);
            connection1.Open();
            //traitement
            string sql = "insert into articles values(5,'techno',400)";
            SqlCommand command = new SqlCommand(sql, connection1);
            command.ExecuteNonQuery();

            Console.WriteLine("insert  ok");
            connection1.Close();
        }

        static void testConnexionArticle()
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("test connexion ok");
            connection.Close();
        }
    }
}
