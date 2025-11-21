using GestionCommercialeBO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
//git test
namespace GestionCommercialeDAL
{
    public class ProduitDAL
    {
        private readonly string connectionString =
            ConfigurationManager.ConnectionStrings["GestionCommerciale.Properties.Settings.Gestion_commercialeConnectionString"].ConnectionString;

        public List<Produit> GetProduits()
        {
            List<Produit> produits = new List<Produit>();

            string query = @"
                SELECT p.code_produit, p.libelle_produit, p.prix_vente_ht_produit, c.code_categorie, c.nom_categorie
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
                        CodeProduit = Convert.ToInt32(reader["code_produit"]),
                        LibelleProduit = Convert.ToString(reader["libelle_produit"]),
                        PrixVenteHT = Convert.ToDecimal(reader["prix_vente_ht_produit"]),

                        CategorieProduit = new Categorie
                        {
                            CodeCategorie = Convert.ToInt32(reader["code_categorie"]),
                            NomCategorie = Convert.ToString(reader["nom_categorie"])
                        }

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
                cmd.Parameters.AddWithValue("@libelle", p.LibelleProduit);
                cmd.Parameters.AddWithValue("@prix", p.PrixVenteHT);
                cmd.Parameters.AddWithValue("@categorie", p.CategorieProduit.CodeCategorie);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public Produit GetProduitById(int codeProduit)
        {
            Produit produit = null;
            string query = @"SELECT p.code_produit, p.libelle_produit, p.prix_vente_ht_produit, 
                            c.code_categorie, c.nom_categorie
                     FROM produit p
                     JOIN categorie c ON p.code_categorie = c.code_categorie
                     WHERE p.code_produit = @code";


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
                            CodeProduit = Convert.ToInt32(reader["code_produit"]),
                            LibelleProduit = Convert.ToString(reader["libelle_produit"]),
                            PrixVenteHT = Convert.ToDecimal(reader["prix_vente_ht_produit"]),

                            CategorieProduit = new Categorie
                            {
                                CodeCategorie = Convert.ToInt32(reader["code_categorie"]),
                                NomCategorie = Convert.ToString(reader["nom_categorie"])
                            }

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
                cmd.Parameters.AddWithValue("@libelle", p.LibelleProduit);
                cmd.Parameters.AddWithValue("@prix", p.PrixVenteHT);
                cmd.Parameters.AddWithValue("@categorie", p.CategorieProduit.CodeCategorie);
                cmd.Parameters.AddWithValue("@code", p.CodeProduit);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
