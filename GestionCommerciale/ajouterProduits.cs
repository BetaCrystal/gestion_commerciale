using GestionCommercialeBLL;
using GestionCommercialeBO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCommerciale
{
    public partial class ajouterProduits : Form
    {
        private ProduitBLL produitBLL = new ProduitBLL();
        private CategorieBLL categorieBLL = new CategorieBLL();
        public ajouterProduits()
        {
            InitializeComponent();
        }

        

        private void ajouterProduits_Load(object sender, EventArgs e)
        {
            cbxProduit.DataSource = categorieBLL.ChargerCategories();
            cbxProduit.DisplayMember = "nom_categorie";
            cbxProduit.ValueMember = "code_categorie";
        }

        private void btnAjouterProduit_Click(object sender, EventArgs e)
        {
            string nomProduit = txtNomProduit.Text.Trim();
            string prixTexte = txtPrixHtProduit.Text.Trim();
            decimal prixHt;

            if (string.IsNullOrWhiteSpace(nomProduit) || !decimal.TryParse(prixTexte, out prixHt))
            {
                MessageBox.Show("Veuillez saisir un nom de produit et un prix HT valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbxProduit.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner une catégorie.");
                return;
            }

            Produit p = new Produit
            {
                libelle_produit = nomProduit,
                prix_vente_ht_produit = prixHt,
                code_categorie = Convert.ToInt32(cbxProduit.SelectedValue)
            };

            try
            {
                produitBLL.AjouterProduit(p);
                MessageBox.Show("Produit ajouté avec succès !", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNomProduit.Clear();
                txtPrixHtProduit.Clear();
                cbxProduit.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout : " + ex.Message);
            }
        }
        

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
