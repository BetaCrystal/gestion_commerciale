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
        private readonly string connectionString;

        public ContientDAL()
        {
            var cs = ConfigurationManager.ConnectionStrings["GestionCommerciale.Properties.Settings.Gestion_commercialeConnectionString"];
            if (cs == null) throw new InvalidOperationException("Chaîne de connexion introuvable.");
            connectionString = cs.ConnectionString;
        }

        public List<Contient> GetLignesByDevis(int codeDevis)
        {
            var lignes = new List<Contient>();
            string query = @"SELECT code_produit, quantite_produit, remise_produit FROM Contient WHERE code_devis = @codeDevis";

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@codeDevis", codeDevis);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    var produitDal = new ProduitDAL(); // supposez que ProduitDAL existe avec GetProduitById
                    while (reader.Read())
                    {
                        int codeProduit = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                        int quantite = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                        float remise = reader.IsDBNull(2) ? 0f : (float)reader.GetDouble(2); // adapter selon type en base

                        Produit produit = null;
                        try
                        {
                            produit = produitDal.GetProduitById(codeProduit); // méthode à implémenter si nécessaire
                        }
                        catch
                        {
                            produit = new Produit() { CodeProduit = codeProduit };
                        }

                        var contient = new Contient(produit, null, remise, quantite);
                        lignes.Add(contient);
                    }
                }
            }

            return lignes;
        }
    }
}
