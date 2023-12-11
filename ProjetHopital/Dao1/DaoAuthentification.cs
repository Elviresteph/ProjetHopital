using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Gestions;

namespace Dao
{
    public class DaoAuthentification
    {
        public bool Insert(Authentification aut)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=HOPITAL;Integrated Security=True";
            string sql = "insert into Authentification values(@login,@password,@nom,@metier)";


            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = connection1.CreateCommand();
            command.CommandText = sql;

            command.Parameters.Add("login", SqlDbType.NVarChar).Value = aut.login;
            command.Parameters.Add("password", SqlDbType.NVarChar).Value = aut.password;
            command.Parameters.Add("nom", SqlDbType.NVarChar).Value = aut.nom;
            command.Parameters.Add("metier", SqlDbType.Int).Value = aut.metier;

            connection1.Open();
            command.ExecuteNonQuery();
            connection1.Close();

            return true;
        }

        public bool Update(Authentification aut)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=HOPITAL;Integrated Security=True";
            string sql = "update Authentification set login=@login,password=@password,nom=@nom,metier=@metier where login=@login ";


            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = connection1.CreateCommand();
            command.CommandText = sql;

            command.Parameters.Add("login", SqlDbType.NVarChar).Value = aut.login;
            command.Parameters.Add("password", SqlDbType.NVarChar).Value = aut.password;
            command.Parameters.Add("nom", SqlDbType.NVarChar).Value = aut.nom;
            command.Parameters.Add("metier", SqlDbType.Int).Value = aut.metier;

            connection1.Open();
            command.ExecuteNonQuery();
            connection1.Close();

            return true;
        }

        public Authentification selectById(string login, string password)
        {
            Authentification a = null;
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=HOPITAL;Integrated Security=True";
            string sql = "select * from Authentification where login= '" + login + "'" + " " + "and password = '" + password + "'";

            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection1);

            connection1.Open();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())

                a = new Authentification(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));

            connection1.Close();

            return a;
        }

        public List<Authentification> SelectAll()
        {
            List<Authentification> liste = new List<Authentification>();

            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=HOPITAL;Integrated Security=True";
            string sql = "select * from Authentification";

            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection1);

            connection1.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Authentification a = new Authentification(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));
                liste.Add(a);
            }

            connection1.Close();
            return liste;
        }

        public bool Delete(int id)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=HOPITAL;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connectionString);
            connection1.Open();
            //traitement
            string sql = "delete Authentification where id = " + id;
            SqlCommand command = new SqlCommand(sql, connection1);
            int nb = command.ExecuteNonQuery();
            connection1.Close();

            if (nb > 0)
                return true;

            return false;
        }
    }
}
    

