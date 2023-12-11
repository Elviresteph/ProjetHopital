using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace projetTpDbArticle
{
    class DB
    {
       
        public static int SelectCount()
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "select count(*) from articles";

            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection1);

            connection1.Open();

            int count = (int)command.ExecuteScalar();

            connection1.Close();
            return count;
        }
        public static string SelectByMarqueLike(string x)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "SELECT marque, prix FROM articles WHERE marque like " +"'"+ x + "%'";

            Console.WriteLine(sql);

            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection1);

            connection1.Open();

            SqlDataReader reader = command.ExecuteReader();

            string resultat = "MARQUE\tPRIX\n";

            while (reader.Read() == true)
                resultat +=  reader.GetValue(0) + "\t" + reader.GetValue(1) + "\n";

            connection1.Close();

            return resultat;


        }
        public static string SelectByPrixPGQ(int p)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "SELECT marque, prix FROM articles WHERE prix >"+p;

            Console.WriteLine(sql);

            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection1);

            connection1.Open();

            SqlDataReader reader = command.ExecuteReader();

            string resultat = "MARQUE\tPRIX\n";

            while (reader.Read() == true)
                resultat += reader.GetValue(0) + "\t" + reader.GetValue(1) + "\n";

            connection1.Close();

            return resultat;


        }
        public static string SelectByPrixBetween(int min, int max)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "SELECT marque, prix FROM articles WHERE prix BETWEEN" +" "+ min + " "+"AND" +" "+ max;

            Console.WriteLine(sql);

            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection1);

            connection1.Open();

            SqlDataReader reader = command.ExecuteReader();

            string resultat = "MARQUE\tPRIX\n";

            while (reader.Read() == true)
                resultat += reader.GetValue(0) + "\t" + reader.GetValue(1) + "\n";

            connection1.Close();

            return resultat;


        }
        public static string SelectById1(int reference)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "select * from articles where reference=" + reference;

            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection1);

            connection1.Open();

            SqlDataReader reader = command.ExecuteReader();

            string resultat = "REFERENCE\tMARQUE\tPRIX\n";

            if (reader.Read() == true)
                resultat += "\t" +reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t"
                     + reader.GetValue(2) + "\n";

            connection1.Close();

            return resultat;

        }
        public static string SelectAll1()
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "select * from articles";

            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection1);

            connection1.Open();

            SqlDataReader reader = command.ExecuteReader();
            string resultat = "REFERENCE\tMARQUE\tPRIX\n";

            while (reader.Read())
                resultat += reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t"
                    + reader.GetValue(2) + "\n";

            connection1.Close();
            return resultat;
        }
        public static bool UpdateDurv1(int reference, string marque, int prix)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "update articles set marque = @marque, prix=@prix where reference=@reference";
            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection1);
            command.CommandText = sql;

            command.Parameters.Add("reference", SqlDbType.Int).Value = reference;
            command.Parameters.Add("marque", SqlDbType.NVarChar).Value = marque;
            command.Parameters.Add("prix", SqlDbType.NVarChar).Value = prix;

            connection1.Open();
            command.ExecuteNonQuery();
            int nb = command.ExecuteNonQuery();
            connection1.Close();
            //Console.WriteLine(sql);
            if (nb > 0)
                return true;

            return false;

        }
        public static void InsertDurv1(int reference, string marque, int prix)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "insert into articles values(@reference, @marque, @prix)";

            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection1);
            command.CommandText = sql;

            command.Parameters.Add("reference", SqlDbType.Int).Value = reference;
            command.Parameters.Add("marque", SqlDbType.NVarChar).Value = marque;
            command.Parameters.Add("prix", SqlDbType.NVarChar).Value = prix;
            connection1.Open();            
            int nb = command.ExecuteNonQuery();
            if (nb > 0)
                Console.WriteLine("Insertion  OK");
            else
                Console.WriteLine("Insertion  KO");
            connection1.Close();
        }
        public static void InsertDur(int reference, string marque, int prix)
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

        public static bool DeleteDur(int reference)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connectionString);
            connection1.Open();
            //traitement
            string sql = "delete articles where reference = " + reference;
            SqlCommand command = new SqlCommand(sql, connection1);
            int nb = command.ExecuteNonQuery();
            connection1.Close();

            if (nb > 0)
                return true;

            return false;


        }
        public static void UpdateDur(int reference, string marque, int prix)
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
    }
}
