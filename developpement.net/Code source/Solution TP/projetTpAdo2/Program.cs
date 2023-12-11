using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace projetTpAdo2
{
    class Program
    {
        static void Main(string[] args)
        {
            testConnexionArticle();
           // TestInsertDur();
            //TestInsertClavier();
            //TestUpdateDur();
            //TestUpdateClavier();
            //TestDeleteDur();
            //TestDeleteClavier();
        }
        static void TestInsertDur()
        {
            InsertDur(11, "Nothing", 699);
        }


        static void InsertDur(int reference, string marque, int prix)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connectionString);
            connection1.Open();
            //traitement
            string sql = "insert into articles values(" + reference + ",'" + marque + "'," + prix + ")";
            SqlCommand command = new SqlCommand(sql, connection1);
            int nb = command.ExecuteNonQuery();
            if (nb > 0)
                Console.WriteLine("Insertion  OK");
            else
                Console.WriteLine("Insertion  KO");
            connection1.Close();
        }

        static void TestInsertClavier()
        {
            Console.WriteLine("Saisissez la référence : ");
            int reference = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saisissez la marque : ");
            string marque = Console.ReadLine();
            Console.WriteLine("Saisissez le prix : ");
            int prix = Convert.ToInt32(Console.ReadLine());
            InsertClavier(reference, marque, prix);
        }

        static void InsertClavier(int reference, string marque, int prix)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connectionString);
            connection1.Open();
            //traitement            
            string sql = "insert into articles values(" + reference + ",'" + marque + "'," + prix + ")";
            SqlCommand command = new SqlCommand(sql, connection1);
            int nb = command.ExecuteNonQuery();
            if (nb > 0)
                Console.WriteLine("Insertion  OK");
            else
                Console.WriteLine("Insertion  KO");
            connection1.Close();
        }
        static void TestUpdateDur()
        {
            UpdateDur(11, "Nothing", 659);
        }
        static void UpdateDur(int reference, string marque, int prix)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connectionString);
            connection1.Open();
            //traitement
            string sql = "update articles set marque = '" + marque + "',prix=" + prix + " where reference=" + reference;
            SqlCommand command = new SqlCommand(sql, connection1);
            command.ExecuteNonQuery();
            int nb = command.ExecuteNonQuery();
            //Console.WriteLine(sql);
            if (nb > 0)
                Console.WriteLine("Mise à jour OK");
            else
                Console.WriteLine("Mise à jour KO");
            connection1.Close();
        }
        static void TestUpdateClavier()
        {
            Console.WriteLine("Saisissez la référence : ");
            int reference = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saisissez la marque : ");
            string marque = Console.ReadLine();
            Console.WriteLine("Saisissez le prix : ");
            int prix = Convert.ToInt32(Console.ReadLine());
            UpdateClavier(reference, marque, prix);
        }
        static void UpdateClavier(int reference, string marque, int prix)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connectionString);
            connection1.Open();
            //traitement
            string sql = "update articles set marque = '" + marque + "',prix=" + prix + " where reference=" + reference;
            SqlCommand command = new SqlCommand(sql, connection1);
            command.ExecuteNonQuery();
            int nb = command.ExecuteNonQuery();
            //Console.WriteLine(sql);
            if (nb > 0)
                Console.WriteLine("Mise à jour OK");
            else
                Console.WriteLine("Mise à jour KO");
            connection1.Close();
        }
        static void TestDeleteDur()
        {
            DeleteDur(11);
        }
        static void DeleteDur(int reference)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connectionString);
            connection1.Open();
            //traitement
            string sql = "delete articles where reference = " + reference;
            SqlCommand command = new SqlCommand(sql, connection1);
            int nb = command.ExecuteNonQuery();
            if (nb > 0)
                Console.WriteLine("Suppression  OK");
            else
                Console.WriteLine("Suppression  KO");
            connection1.Close();
        }
        static void TestDeleteClavier()
        {
            Console.WriteLine("Saisissez la référence : ");
            int reference = Convert.ToInt32(Console.ReadLine());
            DeleteClavier(reference);
        }
        static void DeleteClavier(int reference)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connectionString);
            connection1.Open();
            //traitement
            string sql = "delete articles where reference = " + reference;
            SqlCommand command = new SqlCommand(sql, connection1);
            int nb = command.ExecuteNonQuery();
            if (nb > 0)
                Console.WriteLine("Suppression  OK");
            else
                Console.WriteLine("Suppression  KO");
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


