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
    public class ContientDAL
    {
        private readonly string connectionString =
        ConfigurationManager.ConnectionStrings["GestionCommerciale.Properties.Settings.Gestion_commercialeConnectionString"].ConnectionString;

        public List<Contient> GetContientByDevis(int codeDevis)
        {
            List<Contient> contientList = new List<Contient>();
            string query = @"
                SELECT code_devis, code_produit, quantite_produit, remise_produit
                FROM Contient
                WHERE code_devis = @codeDevis";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@codeDevis", codeDevis);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Correction : respecter l'ordre des colonnes et utiliser le constructeur approprié
                        var codeDevisFromDb = reader.GetInt32(0);
                        var codeProduitFromDb = reader.GetInt32(1);
                        var quantiteProduitFromDb = reader.GetInt32(2);
                        var remiseProduitFromDb = (float)reader.GetDouble(3);

                        var produit = new Produit { CodeProduit = codeProduitFromDb };
                        var devis = new Devis(
                            codeDevisFromDb,
                            default(DateTime),
                            string.Empty,
                            0f,
                            0f,
                            0f,
                            null,
                            null //remplacer les valeurs par celles dans la ligne du data grid view
                        );

                        contientList.Add(new Contient(
                            produit,
                            devis,
                            remiseProduitFromDb,
                            quantiteProduitFromDb
                        ));
                    }
                }
            }
            return contientList;
        }

    }
}
