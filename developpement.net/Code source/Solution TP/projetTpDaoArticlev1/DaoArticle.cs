using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    class DaoArticle
    {
        public static string SelectByPrixBetween(int min, int max)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "SELECT reference, marque FROM articles WHERE reference BETWEEN" + " " + min + " " + "AND" + " " + max;

            Console.WriteLine(sql);

            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection1);

            connection1.Open();

            SqlDataReader reader = command.ExecuteReader();

            string resultat = "reference\tmarque\n";

            while (reader.Read() == true)
                resultat += reader.GetValue(0) + "\t" + reader.GetValue(1) + "\n";

            connection1.Close();

            return resultat;


        }
        public static string SelectByMarqueLike(string m)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "SELECT marque, prix FROM articles WHERE marque like " + "'" + m + "%'";

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
        public static string selectByPrixMinMax(int min, int max)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "SELECT marque, prix FROM articles WHERE prix BETWEEN" + " " + min + " " + "AND" + " " + max;

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
        public bool Delete(int reference)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connectionString);
            connection1.Open();
            //traitement
            string sql = "delete Articles where reference = " + reference;
            SqlCommand command = new SqlCommand(sql, connection1);
            int nb = command.ExecuteNonQuery();
            connection1.Close();

            if (nb > 0)
                return true;

            return false;

        }
        public bool Update(Article a)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "update Articles set marque=@marque, prix=@prix where reference=@reference";

            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = connection1.CreateCommand();
            command.CommandText = sql;

            command.Parameters.Add("reference", SqlDbType.Int).Value = a.Reference;
            command.Parameters.Add("marque", SqlDbType.NVarChar).Value = a.Marque;
            command.Parameters.Add("prix", SqlDbType.NVarChar).Value = a.Prix;

            connection1.Open();
            int nb = command.ExecuteNonQuery();
            connection1.Close();
            if (nb > 0)
                return true;

            return false;

        }
        public bool Insert(Article a)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "insert into Articles values(@reference,@marque,@prix)";


            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = connection1.CreateCommand();
            command.CommandText = sql;

            command.Parameters.Add("reference", SqlDbType.Int).Value = a.Reference;
            command.Parameters.Add("marque", SqlDbType.NVarChar).Value = a.Marque;
            command.Parameters.Add("prix", SqlDbType.NVarChar).Value = a.Prix;



            connection1.Open();
            command.ExecuteNonQuery();
            connection1.Close();

            return true;

        }
        public Article SelectByReference(int reference)
        {
            Article p = null;
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "select * from Articles where reference=" + reference;

            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection1);

            connection1.Open();

            SqlDataReader reader = command.ExecuteReader();



            if (reader.Read())

                p = new Article(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));


            connection1.Close();

            return p;

        }
        public List<Article> SelectAll1()
        {
            List<Article> liste = new List<Article>();
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "select * from articles";

            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection1);

            connection1.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Article p = new Article(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
                liste.Add(p);

            }

            connection1.Close();
            return liste;
        }
    }
}
