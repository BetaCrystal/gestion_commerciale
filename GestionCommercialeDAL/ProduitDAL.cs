using GestionCommercialeBO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
<<<<<<< HEAD

/*
 * Cette clasee permet la gestion des produits (affichage, ajout, modification, suppresion)
 * 
 */

=======
//git test
>>>>>>> origin/main
namespace GestionCommercialeDAL
{
    public class ProduitDAL
    {
        private readonly string connectionString =
            ConfigurationManager.ConnectionStrings["GestionCommerciale.Properties.Settings.Gestion_commercialeConnectionString"].ConnectionString;

        //Récupération des produits qu'on vient stocker dans une liste
        public List<Produit> GetProduits()
        {
            List<Produit> produits = new List<Produit>();

            // Requete SQL qu'on vient executé si il n'y a pas d'erreur avec la bdd
            string query = @"
                SELECT p.code_produit, p.libelle_produit, p.prix_vente_ht_produit, c.code_categorie, c.nom_categorie
                FROM produit p
                JOIN categorie c ON p.code_categorie = c.code_categorie";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Parcours de notre liste et crée un produit pour chaque ligne
                // On vient crée un objet categorie afin d'associer le produit a une categorie
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
            // Vérifie si le produit est lié à un devis dans la table Contient
            //On compte le nombre de fois ou un produit est liée a un devis 
            string checkQuery = "SELECT COUNT(*) FROM Contient WHERE code_produit = @code";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
            {
                checkCmd.Parameters.AddWithValue("@code", codeProduit);
                conn.Open();
                int count = (int)checkCmd.ExecuteScalar();

                // count = le nombre de fois ou un produit est liée a un devis
                if (count > 0)
                {
                    // Si produit lié à un devis on stoppe la suppression
                    throw new InvalidOperationException(
                        "Ce produit est lié à un devis et ne peut pas être supprimé."
                    );
                }
            }
            // Sinon on supprime
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
            //Insertion dans la bdd d'un nouveau produit
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
            //On vient recupérer le produit selectioner par son id
            //Le but ici est de pouvoir récupérer les info du produit choisit
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
            //On vient modifier les infos d'un produit qu'on a au préalable sélectionner
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
