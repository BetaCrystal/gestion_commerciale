using GestionCommercialeBLL;
using GestionCommercialeBO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
=======
>>>>>>> f8d224008bb874cc497a689787bf50114e583130
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using System.Data.SqlClient;
=======
>>>>>>> f8d224008bb874cc497a689787bf50114e583130

namespace GestionCommerciale
{
    public partial class ListeProduits : Form
    {
        private ProduitBLL produitBLL = new ProduitBLL();
        public ListeProduits()
        {
            InitializeComponent();
        }

        private void ChargerProduits()
        {
            var produits = produitBLL.ChargerProduits();

            dtgProduit.AutoGenerateColumns = false;
            dtgProduit.DataSource = produits;
<<<<<<< HEAD
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
=======
>>>>>>> f8d224008bb874cc497a689787bf50114e583130
        }
        private void FormListeProduits_Load(object sender, EventArgs e)
        {
            dtgProduit.AllowUserToAddRows = false;
            ChargerProduits();
        }

        private void btnProduit_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            // ouvre le formulaire d'ajout de produit
=======
>>>>>>> f8d224008bb874cc497a689787bf50114e583130
            ajouterProduits formAjout = new ajouterProduits();
            formAjout.ShowDialog();

            //recharger les produits pour afficher la nouvelle ligne
            ChargerProduits();
        }

        private void dtgProduit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // supprimer
            if (dtgProduit.Columns[e.ColumnIndex].Name == "Supprimer" && e.RowIndex >= 0)
            {
                Produit produit = (Produit)dtgProduit.Rows[e.RowIndex].DataBoundItem;

                DialogResult result = MessageBox.Show(
                    "Voulez-vous vraiment supprimer ce produit ?",
                    "Confirmation de suppression",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
<<<<<<< HEAD
                    produitBLL.SupprimerProduit(produit.code_produit);
=======
                    produitBLL.SupprimerProduit(produit.CodeProduit);
>>>>>>> f8d224008bb874cc497a689787bf50114e583130
                    ChargerProduits();
                }
            }
            //modifier
            if (dtgProduit.Columns[e.ColumnIndex].Name == "Modifier")
            {
                Produit produit = (Produit)dtgProduit.Rows[e.RowIndex].DataBoundItem;
<<<<<<< HEAD
                int codeProduit = produit.code_produit;
=======
                int codeProduit = produit.CodeProduit;
>>>>>>> f8d224008bb874cc497a689787bf50114e583130

                modifierProduit formModifier = new modifierProduit(codeProduit);
                formModifier.ShowDialog();

                ChargerProduits();
            }

        } 
        }
    }
<<<<<<< HEAD
        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            //Comme dans la connexion, on ferme la page ListeProduits pour revenir sur la page Connexion sans fermer l'application
            Connexion connexion = new Connexion();
            connexion.FormClosed += (s, args) => this.Close();
            connexion.Show();
            this.Hide();
        }
    }
}
=======
>>>>>>> f8d224008bb874cc497a689787bf50114e583130
