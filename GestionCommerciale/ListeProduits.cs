using GestionCommercialeBLL;
using GestionCommercialeBO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCommerciale
{
    public partial class ListeProduits : Form
    {
        private ProduitBLL produitBLL = new ProduitBLL();
        public ListeProduits()
        {
            InitializeComponent();
        }

        private void FormListeProduits_Load(object sender, EventArgs e)
        {
            dtgProduit.AllowUserToAddRows = false;
            dtgProduit.AutoGenerateColumns = false;
            dtgProduit.DataSource = bindingSource1;
            ChargerProduits();
        }

        //On vient charger nos produit afin de les afficher dans le datagridview
        private void ChargerProduits()
        {
            var produits = produitBLL.ChargerProduits();
            bindingSource1.DataSource = produits;
        }

        private void btnProduit_Click(object sender, EventArgs e)
        {
            ajouterProduits formAjout = new ajouterProduits();
            formAjout.ShowDialog();

            //recharger les produits pour afficher la nouvelle ligne
            ChargerProduits();
        }

        private void dtgProduit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Récupère le produit correspondant à la ligne
            Produit produit = (Produit)dtgProduit.Rows[e.RowIndex].DataBoundItem;
            int codeProduit = produit.CodeProduit;
            // supprimer
            if (dtgProduit.Columns[e.ColumnIndex].Name == "Supprimer" && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show(
                    "Voulez-vous vraiment supprimer ce produit ?",
                    "Confirmation de suppression",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        produitBLL.SupprimerProduit(produit.CodeProduit);
                        ChargerProduits();
                        MessageBox.Show("Le produit a été supprimé avec succès.", "Suppression effectuée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message, "Suppresion impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            //modifier
            if (dtgProduit.Columns[e.ColumnIndex].Name == "Modifier")
            {
                modifierProduit formModifier = new modifierProduit(codeProduit);
                formModifier.ShowDialog();

                ChargerProduits();
            }

        }

        private void btnOuvrirClient_Click(object sender, EventArgs e)
        {
            // Instancie le Form ListeClients
            ListeClients listeClientsForm = new ListeClients();

            //(permet de terminer proprement l'application)
            listeClientsForm.FormClosed += (s, args) => this.Close();

            // Ouvre le Form Client
            listeClientsForm.Show();
            this.Hide();
        }

        private void btnListeDevis_Click(object sender, EventArgs e)
        {
            ListeDevisTemp listeDevisTemp = new ListeDevisTemp();

            listeDevisTemp.FormClosed += (s, args) => this.Close();

            listeDevisTemp.Show();
            this.Hide();
        }
    }
    }
