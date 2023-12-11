using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetHopital
{
    class DaoVisite
    {
        public bool Insert(Visite v)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=cs-db;Integrated Security=True";
            string sql = "insert into Visites values(@id,@idpatient,@date,@medecin,@num-salle,@tarif)";


            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand command = connection1.CreateCommand();
            command.CommandText = sql;

            command.Parameters.Add("id", SqlDbType.Int).Value = v.Id;
            command.Parameters.Add("idpatient", SqlDbType.NVarChar).Value = v.Idpatient;
            command.Parameters.Add("date", SqlDbType.NVarChar).Value = v.Date;
            command.Parameters.Add("medecin", SqlDbType.Int).Value = v.Medecin;
            command.Parameters.Add("num-salle", SqlDbType.NVarChar).Value = v.Num_salle;
            command.Parameters.Add("tarif", SqlDbType.NVarChar).Value = v.Tarif;

            connection1.Open();
            command.ExecuteNonQuery();
            connection1.Close();

            return true;
        }
    }
}
