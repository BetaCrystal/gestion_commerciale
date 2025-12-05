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
    public class StatutDAL
    {
        private readonly string connectionString =
        ConfigurationManager.ConnectionStrings["GestionCommerciale.Properties.Settings.Gestion_commercialeConnectionString"].ConnectionString;

        public List<Statut> GetStatuts()
        {
            List<Statut> statuts = new List<Statut>();

            string query = @"
                SELECT code_statut, nom_statut FROM Statut";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Code de Copilot car la création d'un Statut ne fonctionnait pas
                    // Récupération sécurisée des colonnes (gestion des valeurs NULL)
                    int code = reader["code_statut"] != DBNull.Value
                        ? Convert.ToInt32(reader["code_statut"])
                        : 0;

                    string nom = reader["nom_statut"] != DBNull.Value
                        ? Convert.ToString(reader["nom_statut"])
                        : null;

                    // Utiliser le constructeur attendu par la classe Statut
                    statuts.Add(new Statut(code, nom));
                }
            }

            return statuts;

        }
    }
}
