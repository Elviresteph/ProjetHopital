using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace projetDaoPersonne
{
    class DaoPersonne
    {
        public bool Delete(int id)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
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

        public bool Update(Personne p)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "update personnes set nom=@nom,prenom=@prenom,age=@age where id=@id ";

            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = connection1.CreateCommand();
            command.CommandText = sql;

            command.Parameters.Add("id", SqlDbType.Int).Value = p.Id;
            command.Parameters.Add("nom", SqlDbType.NVarChar).Value = p.Nom;
            command.Parameters.Add("prenom", SqlDbType.NVarChar).Value = p.Prenom;
            command.Parameters.Add("age", SqlDbType.Int).Value = p.Age;

            connection1.Open();
            int nb = command.ExecuteNonQuery();
            connection1.Close();
            if (nb > 0)
                return true;

            return false;

        }

        public bool Insert(Personne p)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "insert into personnes values(@id,@nom,@prenom,@age)";


            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = connection1.CreateCommand();
            command.CommandText = sql;

            command.Parameters.Add("id", SqlDbType.Int).Value = p.Id;
            command.Parameters.Add("nom", SqlDbType.NVarChar).Value = p.Nom;
            command.Parameters.Add("prenom", SqlDbType.NVarChar).Value = p.Prenom;
            command.Parameters.Add("age", SqlDbType.Int).Value = p.Age;



            connection1.Open();
            command.ExecuteNonQuery();
            connection1.Close();

            return true;

        }
        public Personne SelectById(int id)
        {
            Personne p = null;
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "select * from personnes where id=" + id;

            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection1);

            connection1.Open();

            SqlDataReader reader = command.ExecuteReader();



            if (reader.Read())

                p = new Personne(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));


            connection1.Close();

            return p;

        }

        public List<Personne> SelectAll()
        {

            List<Personne> liste = new List<Personne>();


            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "select * from personnes";

            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection1);

            connection1.Open();

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                Personne p = new Personne(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));
                liste.Add(p);

            }


            connection1.Close();
            return liste;
        }
    }
}
