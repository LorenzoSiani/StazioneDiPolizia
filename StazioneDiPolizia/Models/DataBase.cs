using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StazioneDiPolizia.Models
{
    public static class DataBase
    {
        public static void AddAnagrafica(string cognome,string nome, string indirizzo, string città, int cap, string cod_fis)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CollegaDataBase"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO [ANAGRAFICA] (cognome, nome, indirizzo, città, cap, cod_fis) VALUES(@cognome, @nome, @indirizzo, @città, @cap, @cod_fis)";
                cmd.Parameters.AddWithValue("cognome", cognome);
                cmd.Parameters.AddWithValue("nome", nome);
                cmd.Parameters.AddWithValue("indirizzo", indirizzo);
                cmd.Parameters.AddWithValue("città", città);
                cmd.Parameters.AddWithValue("cap", cap);
                cmd.Parameters.AddWithValue("cod_fis", cod_fis);
                int Ok = cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                conn.Close();
            }
        }

        public static void AddViolazione(string descrizione)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CollegaDataBase"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO[TIPO_VIOLAZIONE] (descrizione) VALUES(@descrizione)";
                cmd.Parameters.AddWithValue("descrizione", descrizione);
                int Ok = cmd.ExecuteNonQuery();

            }
            catch { }
            finally { conn.Close(); }
        }
    }
}