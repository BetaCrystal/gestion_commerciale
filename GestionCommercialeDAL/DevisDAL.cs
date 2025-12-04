using GestionCommercialeBO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeDAL
{
    internal class DevisDAL
    {
        private readonly string connectionString =
                ConfigurationManager.ConnectionStrings["GestionCommerciale.Properties.Settings.Gestion_commercialeConnectionString"].ConnectionString;

        /*public List<Devis> GetDevis()
        {
            // Méthode pour récupérer la liste des devis depuis la base de données
            List<Devis> devis = new List<Devis>();

            string query = @"
                SELECT
                code_devis, date_devis, taux_tva_devis, montant_total_ht_devis, taux_remise_global_devis, code_client,
                code_statut FROM Devis";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        devis.Add(new Devis
                        {
                            CodeDevis = reader.GetInt32(0),
                            DateDevis = reader.GetDateTime(1),
                            TauxTVA = (float)reader.GetDouble(2),
                            MontantHTHorsRemise = (float)reader.GetDouble(3),
                            TauxRemiseGlobal = (float)reader.GetDouble(4),
                            Client = new Client { CodeClient = reader.GetInt32(5) },
                            Statut = new Statut { CodeStatut = reader.GetInt32(6) },
                        });
                    }
                }
                return devis;
            }

        }*/

        public void SupprimerDevis(int codeDevis)
        {
            // Méthode pour supprimer un devis par son code
            string query = "DELETE FROM Devis WHERE code_devis = @codeDevis";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@codeDevis", codeDevis);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
