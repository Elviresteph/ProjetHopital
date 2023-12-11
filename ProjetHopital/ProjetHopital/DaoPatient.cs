using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetHopital
{
    class DaoPatient
    {
        public Patient selectById(int id)
        {

            Patient p = null;
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=HOPITAL;Integrated Security=True";
            string sql = "select * from Patient where Id= '" + id;

            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection1);

            connection1.Open();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())

                p = new Patient(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4), reader.GetString(5));

            connection1.Close();

            return p;
        }

        public bool Insert(Patient p)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "insert into Patients values(@id,@nom,@prenom,@age,@adresse,@telephone)";


            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = connection1.CreateCommand();
            command.CommandText = sql;

            command.Parameters.Add("id", SqlDbType.Int).Value = p.Id;
            command.Parameters.Add("nom", SqlDbType.NVarChar).Value = p.Nom;
            command.Parameters.Add("prenom", SqlDbType.NVarChar).Value = p.Prenom;
            command.Parameters.Add("age", SqlDbType.Int).Value = p.Age;
            command.Parameters.Add("adresse", SqlDbType.NVarChar).Value = p.Adresse;
            command.Parameters.Add("telephone", SqlDbType.NVarChar).Value = p.Telephone;


            connection1.Open();
            command.ExecuteNonQuery();
            connection1.Close();

            return true;
        }
    }
}
