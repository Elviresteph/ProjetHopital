using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace projetAdo3
{
    class DB
    {
        public static int SelectCount()
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "select count(*) from personnes";

            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection1);

            connection1.Open();

            int count = (int)command.ExecuteScalar();

            connection1.Close();
            return count;
        }

        public static string SelectByNom(string nom)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "select * from personnes where nom = '" + nom + "'";

            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection1);

            connection1.Open();

            SqlDataReader reader = command.ExecuteReader();
            string resultat = "ID\tNOM\tPRENOM\tAGE\n";

            while (reader.Read())
                resultat += reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t" + reader.GetValue(2) + "\t"
                    + reader.GetValue(3) + "\n";

            connection1.Close();
            return resultat;
        }
        public static string SelectById1(int id)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "select * from personnes where id=" + id;

            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection1);

            connection1.Open();

            SqlDataReader reader = command.ExecuteReader();

            string resultat = "ID\tNOM\tPRENOM\tAGE\n";

            if (reader.Read() == true)
                resultat += reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t" + reader.GetValue(2) + "\t"
                     + reader.GetValue(3) + "\n";

            connection1.Close();

            return resultat;

        }
        public static string SelectAll1()
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "select * from personnes";

            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection1);

            connection1.Open();

            SqlDataReader reader = command.ExecuteReader();
            string resultat = "ID\tNOM\tPRENOM\tAGE\n";

            while (reader.Read())
                resultat += reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t" + reader.GetValue(2) + "\t"
                    + reader.GetValue(3) + "\n";

            connection1.Close();
            return resultat;
        }
        public static void SelectById(int id)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "select * from personnes where id=" + id;

            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection1);

            connection1.Open();

            SqlDataReader reader = command.ExecuteReader();
            Console.WriteLine("ID\tNOM\tPRENOM\tAGE");

            if (reader.Read() == true)
                Console.WriteLine(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t" + reader.GetValue(2) + "\t"
                    + reader.GetValue(3) + "\t");

            connection1.Close();

        }

        public static void SelectAllOld()
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "select * from personnes";

            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection1);

            connection1.Open();

            SqlDataReader reader = command.ExecuteReader();
            Console.WriteLine("ID\tNOM\tPRENOM\tAGE");
            while (reader.Read())
            {
                Console.WriteLine(reader.GetInt32(0) + "\t" + reader.GetString(1) + "\t" + reader.GetString(2) + "\t"
                    + reader.GetValue(3) + "\t");

                int a = reader.GetInt32(0);
                int b = (int)reader.GetValue(3);
            }

            connection1.Close();

        }

        public static bool Updatev2(int id, string nom, string prenom, int age)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "update personnes set nom=@nom,prenom=@prenom,age=@age where id=@id ";

            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = connection1.CreateCommand();
            command.CommandText = sql;

            command.Parameters.Add("id", SqlDbType.Int).Value = id;
            command.Parameters.Add("nom", SqlDbType.NVarChar).Value = nom;
            command.Parameters.Add("prenom", SqlDbType.NVarChar).Value = prenom;
            command.Parameters.Add("age", SqlDbType.Int).Value = age;

            connection1.Open();
            int nb = command.ExecuteNonQuery();
            connection1.Close();
            if (nb > 0)
                return true;

            return false;

        }
        public static void Insertv2(int i, string n, string p, int a)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "insert into personnes values(@id,@nom,@prenom,@age)";


            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = connection1.CreateCommand();
            command.CommandText = sql;

            command.Parameters.Add("id", SqlDbType.Int).Value = i;
            command.Parameters.Add("nom", SqlDbType.NVarChar).Value = n;
            command.Parameters.Add("prenom", SqlDbType.NVarChar).Value = p;
            command.Parameters.Add("age", SqlDbType.Int).Value = a;



            connection1.Open();
            command.ExecuteNonQuery();
            connection1.Close();



        }
        public static void Insert(int id, string nom, string prenom, int age)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "insert into personnes values(" + id + ",'" + nom + "','" + prenom + "'," + age + ")";

            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection1);

            connection1.Open();
            command.ExecuteNonQuery();
            connection1.Close();

        }
        public static bool Update(int id, string nom, string prenom, int age)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connectionString);
            connection1.Open();
            //traitement
            string sql = "update personnes set nom = '" + nom + "',prenom='" + prenom + "',age=" + age + " where id=" + id;
            SqlCommand command = new SqlCommand(sql, connection1);
            int nb = command.ExecuteNonQuery();
            connection1.Close();
            if (nb > 0)
                return true;

            return false;

        }
        public static bool Delete(int id)
        {
            string connectionString = @"Data Source=PC-JACKY2\SQLEXPRESS;Initial Catalog=cs-db;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connectionString);
            connection1.Open();
            //traitement
            string sql = "delete personnes where id = " + id;
            SqlCommand command = new SqlCommand(sql, connection1);
            int nb = command.ExecuteNonQuery();
            connection1.Close();

            if (nb > 0)
                return true;

            return false;

        }
    }
}
