using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetHopital
{
    class DaoAuthentification
    {
        //public Authentification connexion(Authentification authentification)
        //{
   
        //    Authentification a = null;
        //    string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=HOPITAL;Integrated Security=True";
        //    string sql = "select * from Authentification where login= '" + authentification.login +"'" +" "+ "and password = '" + authentification.password +"'";

        //    SqlConnection connection1 = new SqlConnection(connectionString);
        //    SqlCommand command = new SqlCommand(sql, connection1);

        //    connection1.Open();

        //    SqlDataReader reader = command.ExecuteReader();

        //    if (reader.Read())

        //        a = new Authentification(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));

        //    connection1.Close();

        //    return a;
        //}

        public Authentification connexion(string login, string password)
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
    }
}
