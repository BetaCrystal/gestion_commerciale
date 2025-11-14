using GestionCommercialeBO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeDAL
{
    public class ProduitDAL
    {
        private readonly string connectionString =
            "Data Source=psl23-p16;Initial Catalog=Gestion_commerciale;Integrated Security=True;";

        public List<Produit> GetProduits()
        {
            List<Produit> produits = new List<Produit>();

            string query = @"
                SELECT p.code_produit, p.libelle_produit, p.prix_vente_ht_produit, c.nom_categorie
                FROM produit p
                JOIN categorie c ON p.code_categorie = c.code_categorie";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    produits.Add(new Produit
                    {
                        code_produit = Convert.ToInt32(reader["code_produit"]),
                        libelle_produit = Convert.ToString(reader["libelle_produit"]),
                        prix_vente_ht_produit = Convert.ToDecimal(reader["prix_vente_ht_produit"]),
                        nom_categorie = Convert.ToString(reader["nom_categorie"])
                    });
                }
            }

            return produits;
        }

        public void SupprimerProduit(int codeProduit)
        {
            string query = "DELETE FROM produit WHERE code_produit = @code";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@code", codeProduit);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void InsertProduit(Produit p)
        {
            string query = @"INSERT INTO produit (libelle_produit, prix_vente_ht_produit, code_categorie) 
                         VALUES (@libelle, @prix, @categorie)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@libelle", p.libelle_produit);
                cmd.Parameters.AddWithValue("@prix", p.prix_vente_ht_produit);
                cmd.Parameters.AddWithValue("@categorie", p.code_categorie);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public Produit GetProduitById(int codeProduit)
        {
            Produit produit = null;
            string query = "SELECT code_produit, libelle_produit, prix_vente_ht_produit, code_categorie FROM produit WHERE code_produit = @code";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@code", codeProduit);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        produit = new Produit
                        {
                            code_produit = Convert.ToInt32(reader["code_produit"]),
                            libelle_produit = Convert.ToString(reader["libelle_produit"]),
                            prix_vente_ht_produit = Convert.ToDecimal(reader["prix_vente_ht_produit"]),
                            code_categorie = Convert.ToInt32(reader["code_categorie"])
                        };
                    }
                }
            }
            return produit;
        }

        public void UpdateProduit(Produit p)
        {
            string query = @"UPDATE produit 
                     SET libelle_produit = @libelle, 
                         prix_vente_ht_produit = @prix, 
                         code_categorie = @categorie
                     WHERE code_produit = @code";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@libelle", p.libelle_produit);
                cmd.Parameters.AddWithValue("@prix", p.prix_vente_ht_produit);
                cmd.Parameters.AddWithValue("@categorie", p.code_categorie);
                cmd.Parameters.AddWithValue("@code", p.code_produit);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
