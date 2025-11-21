using GestionCommercialeBO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public void SupprimerClient(int codeClient)
        {
            string query = "DELETE FROM client WHERE code_client = @CodeClient";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CodeClient", codeClient);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void InsertClient(Client c)
        {
            string query = @"
            INSERT INTO client (
                nom_client, num_telephone_client, num_fax_client, adresse_mail_client,
                num_adresse_facturation_client, rue_facturation_client, code_postal_facturation_client, ville_facturation_client,
                num_adresse_livraison_client, rue_livraison_client, code_postal_livraison_client, ville_livraison_client
            ) VALUES (
                @NomClient, @NumTelephoneClient, @NumFaxClient, @AdresseMailClient,
                @NumAdresseFacturationClient, @RueFacturationClient, @CodePostalFacturationClient, @VilleFacturationClient,
                @NumAdresseLivraisonClient, @RueLivraisonClient, @CodePostalLivraisonClient, @VilleLivraisonClient
            )";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@NomClient", c.NomClient);
                cmd.Parameters.AddWithValue("@NumTelephoneClient", c.NumTelephoneClient);
                cmd.Parameters.AddWithValue("@NumFaxClient", c.NumFaxClient);
                cmd.Parameters.AddWithValue("@AdresseMailClient", c.AdresseMailClient);
                cmd.Parameters.AddWithValue("@NumAdresseFacturationClient", c.NumAdresseFacturationClient);
                cmd.Parameters.AddWithValue("@RueFacturationClient", c.RueFacturationClient);
                cmd.Parameters.AddWithValue("@CodePostalFacturationClient", c.CodePostalFacturationClient);
                cmd.Parameters.AddWithValue("@VilleFacturationClient", c.VilleFacturationClient);
                cmd.Parameters.AddWithValue("@NumAdresseLivraisonClient", c.NumAdresseLivraisonClient);
                cmd.Parameters.AddWithValue("@RueLivraisonClient", c.RueLivraisonClient);
                cmd.Parameters.AddWithValue("@CodePostalLivraisonClient", c.CodePostalLivraisonClient);
                cmd.Parameters.AddWithValue("@VilleLivraisonClient", c.VilleLivraisonClient);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Client GetClientById(int codeClient)
        {
            Client client = null;
            string query = @"
            SELECT 
                code_client, nom_client, num_telephone_client, num_fax_client, adresse_mail_client,
                num_adresse_facturation_client, rue_facturation_client, code_postal_facturation_client, ville_facturation_client,
                num_adresse_livraison_client, rue_livraison_client, code_postal_livraison_client, ville_livraison_client
            FROM client
            WHERE code_client = @CodeClient";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CodeClient", codeClient);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    client = new Client
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
                    };
                }
            }
            return client;
        }

        public void UpdateClient(Client c)
        {
            string query = @"
            UPDATE client SET
                nom_client = @NomClient,
                num_telephone_client = @NumTelephoneClient,
                num_fax_client = @NumFaxClient,
                adresse_mail_client = @AdresseMailClient,
                num_adresse_facturation_client = @NumAdresseFacturationClient,
                rue_facturation_client = @RueFacturationClient,
                code_postal_facturation_client = @CodePostalFacturationClient,
                ville_facturation_client = @VilleFacturationClient,
                num_adresse_livraison_client = @NumAdresseLivraisonClient,
                rue_livraison_client = @RueLivraisonClient,
                code_postal_livraison_client = @CodePostalLivraisonClient,
                ville_livraison_client = @VilleLivraisonClient
            WHERE code_client = @CodeClient";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@NomClient", c.NomClient);
                cmd.Parameters.AddWithValue("@NumTelephoneClient", c.NumTelephoneClient);
                cmd.Parameters.AddWithValue("@NumFaxClient", c.NumFaxClient);
                cmd.Parameters.AddWithValue("@AdresseMailClient", c.AdresseMailClient);
                cmd.Parameters.AddWithValue("@NumAdresseFacturationClient", c.NumAdresseFacturationClient);
                cmd.Parameters.AddWithValue("@RueFacturationClient", c.RueFacturationClient);
                cmd.Parameters.AddWithValue("@CodePostalFacturationClient", c.CodePostalFacturationClient);
                cmd.Parameters.AddWithValue("@VilleFacturationClient", c.VilleFacturationClient);
                cmd.Parameters.AddWithValue("@NumAdresseLivraisonClient", c.NumAdresseLivraisonClient);
                cmd.Parameters.AddWithValue("@RueLivraisonClient", c.RueLivraisonClient);
                cmd.Parameters.AddWithValue("@CodePostalLivraisonClient", c.CodePostalLivraisonClient);
                cmd.Parameters.AddWithValue("@VilleLivraisonClient", c.VilleLivraisonClient);
                cmd.Parameters.AddWithValue("@CodeClient", c.CodeClient);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

        }
    }
}
