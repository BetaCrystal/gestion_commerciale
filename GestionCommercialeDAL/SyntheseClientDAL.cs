using GestionCommercialeBO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestionCommercialeDAL
{
    public class SyntheseClientDAL
    {
        private static readonly string connectionString =
            ConfigurationManager.ConnectionStrings["GestionCommerciale.Properties.Settings.Gestion_commercialeConnectionString"].ConnectionString;

        public static List<Devis> GetDevis(DateTime? dateDebut = null, DateTime? dateFin = null)
        {
            List<Devis> listeDevis = new List<Devis>();
            string query = "SELECT * FROM Devis WHERE 1=1";

            if (dateDebut.HasValue)
                query += " AND date_devis >= @DateDebut";
            if (dateFin.HasValue)
                query += " AND date_devis <= @DateFin";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (dateDebut.HasValue)
                    cmd.Parameters.AddWithValue("@DateDebut", dateDebut.Value.Date);
                if (dateFin.HasValue)
                    cmd.Parameters.AddWithValue("@DateFin", dateFin.Value.Date);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listeDevis.Add(new Devis
                    {
                        CodeDevis = (int)reader["code_devis"],
                        DateDevis = (DateTime)reader["date_devis"],
                        MontantTotalHTDevis = Convert.ToDouble(reader["montant_total_ht_devis"]),
                        CodeClient = (int)reader["code_client"],
                        CodeStatut = (int)reader["code_statut"]
                    });
                }
            }

            return listeDevis;
        }

        public static List<Client> GetClients()
        {
            List<Client> listeClients = new List<Client>();
            string query = "SELECT code_client, nom_client FROM Client";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listeClients.Add(new Client
                    {
                        CodeClient = (int)reader["code_client"],
                        NomClient = reader["nom_client"].ToString()
                    });
                }
            }

            return listeClients;
        }
    }

}
