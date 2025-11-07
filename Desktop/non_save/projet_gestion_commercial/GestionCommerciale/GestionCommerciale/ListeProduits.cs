using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionCommerciale
{
    public partial class ListeProduits : Form
    {
        public ListeProduits()
        {
            InitializeComponent();
        }

        private void ChargerProduits()
        {
            string connectionString = "Data Source=psl23-p06;Initial Catalog=GestionCommerciale;Integrated Security=True;";
            string query = @"
        SELECT 
            p.libelle_produit, 
            p.prix_ht_produit, 
            c.nom_categorie
        FROM produit p
        JOIN categorie c ON p.code_categorie = c.code_categorie";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // désactive l'auto-génération
                    dtgProduit.AutoGenerateColumns = false;
                    dtgProduit.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }
        private void FormListeProduits_Load(object sender, EventArgs e)
        {
            dtgProduit.AllowUserToAddRows = false;
            ChargerProduits();
        }

        private void btnProduit_Click(object sender, EventArgs e)
        {
            // ouvre le formulaire d'ajout de produit
            ajouterProduits formAjout = new ajouterProduits();
            formAjout.ShowDialog();

            //recharger les produits pour afficher la nouvelle ligne
            ChargerProduits();
        }
    }
}
