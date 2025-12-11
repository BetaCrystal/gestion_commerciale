using GestionCommercialeBO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionCommercialeBO;

namespace GestionCommercialeDAL
{
    public class DevisDAL
    {
        private readonly string connectionString =
             ConfigurationManager.ConnectionStrings["GestionCommerciale.Properties.Settings.Gestion_commercialeConnectionString"].ConnectionString;

        public int InsertDevis(Devis devis)
        {
            int codeDevis;

            string query = @"
                INSERT INTO Devis (date_devis, taux_tva_devis, montant_total_ht_devis, taux_remise_global_devis, code_client, code_statut)
                OUTPUT INSERTED.code_devis
                VALUES (@DateDevis, @TauxTVA, @MontantHT, @Remise, @CodeClient, @CodeStatut)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@DateDevis", devis.DateDevis);
                cmd.Parameters.AddWithValue("@TauxTVA", devis.TauxTVADevis);
                cmd.Parameters.AddWithValue("@MontantHT", devis.MontantTotalHTDevis);
                cmd.Parameters.AddWithValue("@Remise", devis.TauxRemiseGlobalDevis);
                cmd.Parameters.AddWithValue("@CodeClient", devis.CodeClient);
                cmd.Parameters.AddWithValue("@CodeStatut", devis.CodeStatut);

                conn.Open();
                codeDevis = (int)cmd.ExecuteScalar(); // récupère le code auto-généré
            }

            return codeDevis;
        }

        public List<Statut> GetStatuts()
        {
            var statuts = new List<Statut>();
            string query = "SELECT code_statut, nom_statut FROM Statut";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    statuts.Add(new Statut(
                        Convert.ToInt32(reader["code_statut"]),
                        reader["nom_statut"].ToString()
                    ));
                }
            }

            return statuts;
        }

        public Devis GetDevisByCode(int codeDevis)
        {
            Devis devis = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                //  Récupérer les infos du devis
                string queryDevis = @"
                SELECT code_devis, date_devis, taux_tva_devis, montant_total_ht_devis,
                       taux_remise_global_devis, code_client, code_statut
                FROM Devis
                WHERE code_devis = @CodeDevis";

                using (SqlCommand cmd = new SqlCommand(queryDevis, conn))
                {
                    cmd.Parameters.AddWithValue("@CodeDevis", codeDevis);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            devis = new Devis
                            {
                                CodeDevis = (int)reader["code_devis"],
                                DateDevis = (DateTime)reader["date_devis"],
                                TauxTVADevis = Convert.ToDouble(reader["taux_tva_devis"]),
                                MontantTotalHTDevis = Convert.ToDouble(reader["montant_total_ht_devis"]),
                                TauxRemiseGlobalDevis = Convert.ToDouble(reader["taux_remise_global_devis"]),
                                CodeClient = (int)reader["code_client"],
                                CodeStatut = (int)reader["code_statut"],
                                Produits = new List<ContientTemp>()
                            };
                        }
                    }
                }

                if (devis != null)
                {
                    //  Récupérer les produits liés au devis
                    string queryProduits = @"
                    SELECT code_produit, quantite_produit, remise_produit
                    FROM Contient
                    WHERE code_devis = @CodeDevis";

                    using (SqlCommand cmdProd = new SqlCommand(queryProduits, conn))
                    {
                        cmdProd.Parameters.AddWithValue("@CodeDevis", codeDevis);
                        using (SqlDataReader reader = cmdProd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                devis.Produits.Add(new ContientTemp
                                {
                                    CodeProduit = (int)reader["code_produit"],
                                    Quantite = Convert.ToInt32(reader["quantite_produit"]),
                                    Remise = Convert.ToDouble(reader["remise_produit"])
                                });
                            }
                        }
                    }
                }
            }

            return devis;
        }
        public List<Devis> ChargerDevis()
        {
            var liste = new List<Devis>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                @"SELECT d.code_devis, d.code_client, c.nom_client
          FROM Devis d
          JOIN Client c ON d.code_client = c.code_client", conn))
            {

namespace GestionCommercialeDAL
{
    internal class DevisDAL
    {
        private readonly string connectionString =
                ConfigurationManager.ConnectionStrings["GestionCommerciale.Properties.Settings.Gestion_commercialeConnectionString"].ConnectionString;

        public List<Devis> GetDevis()
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
                        liste.Add(new Devis
                        {
                            CodeDevis = (int)reader["code_devis"],
                            CodeClient = (int)reader["code_client"],
                            NomClient = reader["nom_client"].ToString()
                        });
                    }
                }
            }
            return liste;
        }

        public void ModifierDevis(Devis devis)
        {
            string query = @"
        UPDATE Devis
        SET date_devis = @DateDevis,
            code_client = @CodeClient,
            montant_total_ht_devis = @MontantHT,
            taux_tva_devis = @TauxTVA,
            taux_remise_global_devis = @Remise,
            code_statut = @CodeStatut
        WHERE code_devis = @CodeDevis";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@DateDevis", devis.DateDevis);
                cmd.Parameters.AddWithValue("@CodeClient", devis.CodeClient);
                cmd.Parameters.AddWithValue("@MontantHT", devis.MontantTotalHTDevis);
                cmd.Parameters.AddWithValue("@TauxTVA", devis.TauxTVADevis);
                cmd.Parameters.AddWithValue("@Remise", devis.TauxRemiseGlobalDevis);
                cmd.Parameters.AddWithValue("@CodeStatut", devis.CodeStatut);
                cmd.Parameters.AddWithValue("@CodeDevis", devis.CodeDevis);

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

        }

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
