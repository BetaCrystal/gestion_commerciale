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

        public void InsertContients(int codeDevis, List<ContientTemp> produits)
        {
            string query = @"
                INSERT INTO Contient (code_produit, code_devis, remise_produit, quantite_produit)
                VALUES (@CodeProduit, @CodeDevis, @Remise, @Quantite)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                foreach (var p in produits)
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CodeProduit", p.CodeProduit);
                        cmd.Parameters.AddWithValue("@CodeDevis", codeDevis);
                        cmd.Parameters.AddWithValue("@Remise", p.Remise);
                        cmd.Parameters.AddWithValue("@Quantite", p.Quantite);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public void SupprimerContients(int codeDevis)
        {
            string query = "DELETE FROM Contient WHERE code_devis = @CodeDevis";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CodeDevis", codeDevis);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}
