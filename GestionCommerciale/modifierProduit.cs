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
    public partial class modifierProduit : Form
    {
        private int _codeProduit;
        private ProduitBLL produitBLL = new ProduitBLL();
        private CategorieBLL categorieBLL = new CategorieBLL();
        public modifierProduit(int codeProduit)
        {
            InitializeComponent();
            _codeProduit = codeProduit;
        }

        private void modifierProduit_Load(object sender, EventArgs e)
        {
            
            cbxProduit.DataSource = categorieBLL.ChargerCategories();
            cbxProduit.DisplayMember = "nom_categorie";
            cbxProduit.ValueMember = "code_categorie";

            Produit produit = produitBLL.GetProduitById(_codeProduit);
            if (produit != null)
            {
                txtNomProduit.Text = produit.libelle_produit;
                txtPrixHtProduit.Text = produit.prix_vente_ht_produit.ToString();
                cbxProduit.SelectedValue = produit.code_categorie;
            }

        }

        private void btnModifierProduit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomProduit.Text) || !decimal.TryParse(txtPrixHtProduit.Text, out decimal prixHt))
            {
                MessageBox.Show("Veuillez saisir un nom de produit et un prix HT valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbxProduit.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner une catégorie.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Produit produit = new Produit
            {
                code_produit = _codeProduit,
                libelle_produit = txtNomProduit.Text.Trim(),
                prix_vente_ht_produit = prixHt,
                code_categorie = Convert.ToInt32(cbxProduit.SelectedValue)
            };

            try
            {
                produitBLL.UpdateProduit(produit);
                MessageBox.Show("Produit modifié avec succès !", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification : " + ex.Message, "Erreur SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }  
    }
}
