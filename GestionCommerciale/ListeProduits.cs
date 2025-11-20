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

        private void ChargerProduits()
        {
            var produits = produitBLL.ChargerProduits();

            dtgProduit.AutoGenerateColumns = false;
            dtgProduit.DataSource = produits;
        }
        private void FormListeProduits_Load(object sender, EventArgs e)
        {
            dtgProduit.AllowUserToAddRows = false;
            ChargerProduits();
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
                    produitBLL.SupprimerProduit(produit.code_produit);
                    ChargerProduits();
                }
            }
            //modifier
            if (dtgProduit.Columns[e.ColumnIndex].Name == "Modifier")
            {
                Produit produit = (Produit)dtgProduit.Rows[e.RowIndex].DataBoundItem;
                int codeProduit = produit.code_produit;

                modifierProduit formModifier = new modifierProduit(codeProduit);
                formModifier.ShowDialog();

                ChargerProduits();
            }

        } 
        }
    }
