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
    public class ClientDAL
    {
        //connexion avec la BDD
        private readonly string connectionString =
                ConfigurationManager.ConnectionStrings["GestionCommerciale.Properties.Settings.Gestion_commercialeConnectionString"].ConnectionString;

        public List<Client> GetClients()
        {
            //Création d'une nouvelle liste Client
            List<Client> clients = new List<Client>();
            //requete récupérant toute les info de tous client 
            string query = @"
            SELECT 
                code_client, nom_client, num_telephone_client, num_fax_client, adresse_mail_client,
                num_adresse_facturation_client, rue_facturation_client, code_postal_facturation_client, ville_facturation_client,
                num_adresse_livraison_client, rue_livraison_client, code_postal_livraison_client, ville_livraison_client
            FROM client";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                // On stock les d'info des client notre liste
                while (reader.Read())
                {
                    clients.Add(new Client
                    {
                        CodeClient = Convert.ToInt32(reader["code_client"]),
                        NomClient = Convert.ToString(reader["nom_client"]),
                        NumTelephoneClient = Convert.ToString(reader["num_telephone_client"]),
                        NumFaxClient = Convert.ToString(reader["num_fax_client"]),
                        AdresseMailClient = Convert.ToString(reader["adresse_mail_client"]),
                        NumAdresseFacturationClient = Convert.ToString(reader["num_adresse_facturation_client"]),
                        RueFacturationClient = Convert.ToString(reader["rue_facturation_client"]),
                        CodePostalFacturationClient = Convert.ToString(reader["code_postal_facturation_client"]),
                        VilleFacturationClient = Convert.ToString(reader["ville_facturation_client"]),
                        NumAdresseLivraisonClient = Convert.ToString(reader["num_adresse_livraison_client"]),
                        RueLivraisonClient = Convert.ToString(reader["rue_livraison_client"]),
                        CodePostalLivraisonClient = Convert.ToString(reader["code_postal_livraison_client"]),
                        VilleLivraisonClient = Convert.ToString(reader["ville_livraison_client"])
                    });
                }
            }
            // On retourne notre liste comportant nos clients
            return clients;
        }

        // Vérifie si le client est lié à un devis
        private bool EstLieAUnDevis(int codeClient)
        {
            string query = "SELECT COUNT(*) FROM Devis WHERE code_client = @code";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@code", codeClient);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0; // vrai si le client est lié à un devis
            }
        }
        public void SupprimerClient(int codeClient)
        {
            //Si le client est liée a un devis alors on retroune une erreur
            if (EstLieAUnDevis(codeClient))
                throw new InvalidOperationException("Ce client est liée a un devis");

            // Vu que aucun client est liée a un devis alors on supprime le client
            string query = "DELETE FROM client WHERE code_client = @CodeClient";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CodeClient", codeClient);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}
