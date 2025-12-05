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
    public class DevisDAL
    {
        private readonly string connectionString;

        public DevisDAL()
        {
            var cs = ConfigurationManager.ConnectionStrings["GestionCommerciale.Properties.Settings.Gestion_commercialeConnectionString"];
            if (cs == null)
            {
                throw new InvalidOperationException("Chaîne de connexion introuvable : vérifiez le nom dans App.config (ConfigurationManager.ConnectionStrings).");
            }
            connectionString = cs.ConnectionString;
        }

        // Retourne la liste des devis, avec informations client et statut si disponibles
        public List<Devis> GetDevis()
        {
            var devis = new List<Devis>();

            // Requête qui récupère les ids et, si disponibles, le nom du client et le libellé du statut
            string query = @"
                    SELECT 
                        d.code_devis,
                        d.date_devis,
                        d.taux_tva_devis,
                        d.montant_total_ht_devis,
                        d.taux_remise_global_devis,
                        d.code_client,
                        c.nom_client AS client_nom,
                        d.code_statut,
                        s.nom_statut AS statut_nom
                    FROM Devis d
                    LEFT JOIN Client c ON d.code_client = c.code_client
                    LEFT JOIN Statut s ON d.code_statut = s.code_statut
                    ORDER BY d.code_devis;";

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    // obtenir ordinals pour sécurité et performance
                    int ordCodeDevis = reader.GetOrdinal("code_devis");
                    int ordDate = reader.GetOrdinal("date_devis");
                    int ordTva = reader.GetOrdinal("taux_tva_devis");
                    int ordMontant = reader.GetOrdinal("montant_total_ht_devis");
                    int ordRemise = reader.GetOrdinal("taux_remise_global_devis");
                    int ordCodeClient = reader.GetOrdinal("code_client");
                    int ordClientNom = reader.GetOrdinal("client_nom");
                    int ordCodeStatut = reader.GetOrdinal("code_statut");
                    int ordStatutLibelle = reader.GetOrdinal("statut_nom");

                    while (reader.Read())
                    {
                        var client = new Client();
                        if (!reader.IsDBNull(ordCodeClient))
                        {
                            client.CodeClient = reader.GetInt32(ordCodeClient);
                        }
                        if (!reader.IsDBNull(ordClientNom))
                        {
                            // Assigne le nom si la propriété existe dans Client
                            try { client.NomClient = reader.GetString(ordClientNom); } catch { /* si propriété différente, ignorer */ }
                        }

                        // Remplacez toutes les instanciations de Statut par le constructeur adéquat
                        // Ancien code : var statut = new Statut();
                        // Nouveau code :
                        var statut = new Statut(
                            !reader.IsDBNull(ordCodeStatut) ? reader.GetInt32(ordCodeStatut) : 0,
                            !reader.IsDBNull(ordStatutLibelle) ? reader.GetString(ordStatutLibelle) : string.Empty
                        );
                        if (!reader.IsDBNull(ordCodeStatut)) statut.CodeStatut = reader.GetInt32(ordCodeStatut);
                        if (!reader.IsDBNull(ordStatutLibelle)) try { statut.NomStatut = reader.GetString(ordStatutLibelle); } catch { }
                        if (!reader.IsDBNull(ordCodeStatut))
                        {
                            statut.CodeStatut = reader.GetInt32(ordCodeStatut);
                        }
                        if (!reader.IsDBNull(ordStatutLibelle))
                        {
                            try { statut.NomStatut = reader.GetString(ordStatutLibelle); } catch { /* si propriété différente, ignorer */ }
                        }

                        var d = new Devis(
                            codeDevis: !reader.IsDBNull(ordCodeDevis) ? reader.GetInt32(ordCodeDevis) : 0,
                            dateDevis: !reader.IsDBNull(ordDate) ? reader.GetDateTime(ordDate) : default(DateTime),
                            statutDevis: (reader.IsDBNull(ordStatutLibelle) ? string.Empty : (reader.GetString(ordStatutLibelle) ?? string.Empty)),
                            tauxTVA: !reader.IsDBNull(ordTva) ? (float)reader.GetDouble(ordTva) : 0f,
                            tauxRemiseGlobal: !reader.IsDBNull(ordRemise) ? (float)reader.GetDouble(ordRemise) : 0f,
                            montantHTHorsRemise: !reader.IsDBNull(ordMontant) ? (float)reader.GetDouble(ordMontant) : 0f,
                            client: client,
                            statut: statut
                        );

                        devis.Add(d);
                    }
                }
            }

            return devis;
        }

        // Récupère un devis par son id (null si non trouvé)
        public Devis GetDevisById(int codeDevis)
        {
            string query = @"
                    SELECT 
                        d.code_devis,
                        d.date_devis,
                        d.taux_tva_devis,
                        d.montant_total_ht_devis,
                        d.taux_remise_global_devis,
                        d.code_client,
                        c.nom_client AS client_nom,
                        d.code_statut,
                        s.nom_statut AS statut_nom
                    FROM Devis d
                    LEFT JOIN Client c ON d.code_client = c.code_client
                    LEFT JOIN Statut s ON d.code_statut = s.code_statut
                    WHERE d.code_devis = @codeDevis;";

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@codeDevis", codeDevis);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read()) return null;

                    int ordCodeDevis = reader.GetOrdinal("code_devis");
                    int ordDate = reader.GetOrdinal("date_devis");
                    int ordTva = reader.GetOrdinal("taux_tva_devis");
                    int ordMontant = reader.GetOrdinal("montant_total_ht_devis");
                    int ordRemise = reader.GetOrdinal("taux_remise_global_devis");
                    int ordCodeClient = reader.GetOrdinal("code_client");
                    int ordClientNom = reader.GetOrdinal("client_nom");
                    int ordCodeStatut = reader.GetOrdinal("code_statut");
                    int ordStatutLibelle = reader.GetOrdinal("statut_nom");

                    var client = new Client();
                    if (!reader.IsDBNull(ordCodeClient)) client.CodeClient = reader.GetInt32(ordCodeClient);
                    if (!reader.IsDBNull(ordClientNom)) try { client.NomClient = reader.GetString(ordClientNom); } catch { }

                    // Remplacez toutes les instanciations de Statut par le constructeur adéquat
                    // Ancien code : var statut = new Statut();
                    // Nouveau code :
                    var statut = new Statut(
                        !reader.IsDBNull(ordCodeStatut) ? reader.GetInt32(ordCodeStatut) : 0,
                        !reader.IsDBNull(ordStatutLibelle) ? reader.GetString(ordStatutLibelle) : string.Empty
                    );
                    if (!reader.IsDBNull(ordCodeStatut)) statut.CodeStatut = reader.GetInt32(ordCodeStatut);
                    if (!reader.IsDBNull(ordStatutLibelle)) try { statut.NomStatut = reader.GetString(ordStatutLibelle); } catch { }

                    var d = new Devis(
                        codeDevis: !reader.IsDBNull(ordCodeDevis) ? reader.GetInt32(ordCodeDevis) : 0,
                        dateDevis: !reader.IsDBNull(ordDate) ? reader.GetDateTime(ordDate) : default(DateTime),
                        statutDevis: (reader.IsDBNull(ordStatutLibelle) ? string.Empty : (reader.GetString(ordStatutLibelle) ?? string.Empty)),
                        tauxTVA: !reader.IsDBNull(ordTva) ? (float)reader.GetDouble(ordTva) : 0f,
                        tauxRemiseGlobal: !reader.IsDBNull(ordRemise) ? (float)reader.GetDouble(ordRemise) : 0f,
                        montantHTHorsRemise: !reader.IsDBNull(ordMontant) ? (float)reader.GetDouble(ordMontant) : 0f,
                        client: client,
                        statut: statut
                    );

                    return d;
                }
            }
        }

        // Supprime d'abord les lignes de Contient liées, puis le devis
        public void SupprimerDevis(int codeDevis)
        {
            string deleteContient = "DELETE FROM Contient WHERE code_devis = @codeDevis";
            string deleteDevis = "DELETE FROM Devis WHERE code_devis = @codeDevis";

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(deleteContient, conn))
            {
                cmd.Parameters.AddWithValue("@codeDevis", codeDevis);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(deleteDevis, conn))
            {
                cmd.Parameters.AddWithValue("@codeDevis", codeDevis);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
