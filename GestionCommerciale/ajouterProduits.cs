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
using System.Data;

namespace GestionCommerciale
{
    public partial class ajouterProduits : Form
    {
        public ajouterProduits()
        {
            InitializeComponent();
        }

        private void ChargerCategoriesDansComboBox()
        {
            string connectionString = "Data Source=psl23-p06;Initial Catalog=GestionCommerciale;Integrated Security=True";
            string query = "SELECT code_categorie, nom_categorie FROM dbo.categorie";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbxProduit.DataSource = dt;
                    cbxProduit.DisplayMember = "nom_categorie";
                    cbxProduit.ValueMember = "code_categorie";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }


        private void ajouterProduits_Load(object sender, EventArgs e)
        {
            ChargerCategoriesDansComboBox();
        }

        private void btnAjouterProduit_Click(object sender, EventArgs e)
        {
                // récupération des données depuis les contrôles du formulaire
                string nomProduit = txtNomProduit.Text.Trim();
                string prixTexte = txtPrixHtProduit.Text.Trim();
                decimal prixHt;
                int codeCategorie;

                // validation des données
                if (string.IsNullOrWhiteSpace(nomProduit) || !decimal.TryParse(prixTexte, out prixHt))
                {
                    MessageBox.Show("Veuillez saisir un nom de produit et un prix HT valide.");
                    return;
                }

                if (cbxProduit.SelectedValue == null)
                {
                    MessageBox.Show("Veuillez sélectionner une catégorie.");
                    return;
                }

                codeCategorie = Convert.ToInt32(cbxProduit.SelectedValue);

                // connexion et insertion dans la base de données
                string connectionString = "Data Source=psl23-p06;Initial Catalog=GestionCommerciale;Integrated Security=True;";
                string query = "INSERT INTO produit (libelle_produit, prix_ht_produit, code_categorie) " +
                               "VALUES (@libelle, @prix, @categorie)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            // paramètres pour éviter l'injection SQL
                            cmd.Parameters.AddWithValue("@libelle", nomProduit);
                            cmd.Parameters.AddWithValue("@prix", prixHt);
                            cmd.Parameters.AddWithValue("@categorie", codeCategorie);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Produit ajouté avec succès !");
                                // vider les champs
                                txtNomProduit.Clear();
                                txtPrixHtProduit.Clear();
                                cbxProduit.SelectedIndex = -1;
                            }
                            else
                            {
                                MessageBox.Show("L'ajout du produit a échoué.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur : " + ex.Message);
                    }
                }
            

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {

        }
    }
}
