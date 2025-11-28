using GestionCommercialeBLL;
using GestionCommercialeBO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCommerciale
{
    public partial class AjouterDevis : Form
    {
        private readonly ClientBLL clientBLL = new ClientBLL();
        private readonly ProduitBLL produitBLL = new ProduitBLL();
        
        //Classe Interne pour stocker les informations d'un produit
        private List<ContientTemp> produitsSelectionnes = new List<ContientTemp>();

        private class ContientTemp
        {
            public int CodeProduit { get; set; }
            public int Quantite { get; set; }
            public decimal Remise { get; set; }
        }
        public AjouterDevis()
        {
            InitializeComponent();
        }

        private void AjouterDevis_Load(object sender, EventArgs e)
        {
            // Charger la liste des clients
            cmbClients.DataSource = clientBLL.ChargerClients();
            cmbClients.DisplayMember = "NomClient";
            cmbClients.ValueMember = "CodeClient";

            //Charger la liste des produits
            var produits = produitBLL.ChargerProduits()
                .OrderBy(p => p.CategorieProduit.NomCategorie)
                .ThenBy(p =>p.LibelleProduit)
                .ToList();
            chkProduits.Items.Clear();
            //Variable pour suivre la catégorie en cours
            string categorieCourante = null;

            foreach (var produit in produits)
            {
                if (categorieCourante != produit.CategorieProduit.NomCategorie)
                {
                    categorieCourante = produit.CategorieProduit.NomCategorie;
                    //Ajout d'un item innactif pour la catégorie
                    chkProduits.Items.Add($"--- {categorieCourante}---");
                }
                chkProduits.Items.Add(produit);
            }
        }

        // On vient ouvrir la popup permettant de renseigner la remise et la quantite d'un produit cocher
        private void chkProduits_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Produit produit = (Produit)chkProduits.Items[e.Index];

            if (e.NewValue == CheckState.Checked)
            {
                using (PopupQuantiteProduit popup = new PopupQuantiteProduit(produit))
                {
                    if (popup.ShowDialog() == DialogResult.OK)
                    {
                        produitsSelectionnes.Add(new ContientTemp
                        {
                            CodeProduit = produit.CodeProduit,
                            Quantite = popup.Quantite,
                            Remise = popup.Remise
                        });
                    }
                    else
                    {
                        //decoche le produit en cas d'anulation
                        e.NewValue = CheckState.Unchecked;
                    }
                }
            }
            else
            {
                produitsSelectionnes.RemoveAll(p => p.CodeProduit == produit.CodeProduit);
            }
        }
    }
}
