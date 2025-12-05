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
        private readonly DevisBLL devisBLL = new DevisBLL();

        //Classe Interne pour stocker les informations d'un produit
        private List<ContientTemp> produitsSelectionnes = new List<ContientTemp>();

        private int? codeDevisEnCours = null; // null si ajout, sinon modification
        public AjouterDevis()
        {
            InitializeComponent();
        }

        // Constructeur pour modification
        public AjouterDevis(int codeDevis) : this() // appelle le constructeur par défaut
        {
            codeDevisEnCours = codeDevis;
            ChargerDevisExistants(codeDevis);
        }
        // Flag pour bloquer l'ouverture de la popup lors du chargement
        private bool enCoursDeChargement = false;
        private void ChargerDevisExistants(int codeDevis)
        {
            var devis = devisBLL.GetDevisByCode(codeDevis);

            if (devis == null)
            {
                MessageBox.Show($"Le devis {codeDevis} est introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Remplir le client
            cmbClients.DataSource = clientBLL.ChargerClients();
            cmbClients.DisplayMember = "NomClient";
            cmbClients.ValueMember = "CodeClient";
            cmbClients.SelectedValue = devis.CodeClient;

            // Charger la liste des statuts et sélectionner celui du devis
            cmbStatut.DataSource = devisBLL.GetStatuts();
            cmbStatut.DisplayMember = "NomStatut";
            cmbStatut.ValueMember = "CodeStatut";
            cmbStatut.SelectedValue = devis.CodeStatut;


            // Remplir les produits cochés
            var produits = produitBLL.ChargerProduits()
                .OrderBy(p => p.CategorieProduit.NomCategorie)
                .ThenBy(p => p.LibelleProduit)
                .ToList();

            // On bloque l'ouverture de la popup pendant le chargement
            enCoursDeChargement = true;

            chkProduits.Items.Clear();
            string categorieCourante = null;

            foreach (var produit in produits)
            {
                if (categorieCourante != produit.CategorieProduit.NomCategorie)
                {
                    categorieCourante = produit.CategorieProduit.NomCategorie;
                    chkProduits.Items.Add($"--- {categorieCourante} ---");
                }

                chkProduits.Items.Add(produit);

                // Coche si le produit fait partie du devis existant
                var selection = devis.Produits.FirstOrDefault(p => p.CodeProduit == produit.CodeProduit);
                if (selection != null)
                {
                    produitsSelectionnes.Add(new ContientTemp
                    {
                        CodeProduit = produit.CodeProduit,
                        Quantite = selection.Quantite,
                        Remise = selection.Remise
                    });

                    // Coche la case correspondante
                    int index = chkProduits.Items.IndexOf(produit);
                    if (index >= 0)
                        chkProduits.SetItemChecked(index, true);
                }
            }
            enCoursDeChargement = false;
        }

        private void AjouterDevis_Load(object sender, EventArgs e)
        {
            if (codeDevisEnCours == null)
            {
                // Charger la liste des clients
                cmbClients.DataSource = clientBLL.ChargerClients();
                cmbClients.DisplayMember = "NomClient";
                cmbClients.ValueMember = "CodeClient";

                // Charger la liste des statuts disponibles
                cmbStatut.DataSource = devisBLL.GetStatuts();
                cmbStatut.DisplayMember = "NomStatut";
                cmbStatut.ValueMember = "CodeStatut";


                //Charger la liste des produits
                var produits = produitBLL.ChargerProduits()
                    .OrderBy(p => p.CategorieProduit.NomCategorie)
                    .ThenBy(p => p.LibelleProduit)
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
        }

        // On vient ouvrir la popup permettant de renseigner la remise et la quantite d'un produit cocher
        private void chkProduits_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (enCoursDeChargement)
                return; // On ne fait rien pendant le chargement initial
            var item = chkProduits.Items[e.Index];

            // Si l'item n'est pas un produit, on bloque la case
            if (!(item is Produit))
            {
                e.NewValue = e.CurrentValue; // empêche le check/décheck
                return;
            }

            Produit produit = (Produit)item;

            if (e.NewValue == CheckState.Checked)
            {
                using (PopupQuantiteProduit popup = new PopupQuantiteProduit(produit))
                {
                    if (popup.ShowDialog() == DialogResult.OK)
                    {
                        produitsSelectionnes.Add(new ContientTemp
                        {
                            CodeProduit = produit.CodeProduit,
                            Quantite = (int)popup.Quantite,
                            Remise = (double)popup.Remise
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
            // Recalculer après que l'état de la case soit appliqué
            this.BeginInvoke(new Action(() => CalculerTotalTTC()));
        }

        private void btnAjouterDevis_Click(object sender, EventArgs e)
        {
            var clientSelectionne = (Client)cmbClients.SelectedItem;
            if (clientSelectionne == null || produitsSelectionnes.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un client et au moins un produit.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Récupère le statut choisi
                int codeStatutSelectionne = (int)cmbStatut.SelectedValue;

                // Vérifie si on ajoute un nouveau devis ou on modifie un existant
                if (codeDevisEnCours == null)
                {
                    int codeDevis = devisBLL.CreerDevis(clientSelectionne.CodeClient, produitsSelectionnes, codeStatutSelectionne);
                    MessageBox.Show($"Devis créé avec succès (Code: {codeDevis}).", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    devisBLL.ModifierDevis(codeDevisEnCours.Value, clientSelectionne.CodeClient, produitsSelectionnes, codeStatutSelectionne);
                    MessageBox.Show($"Devis modifié avec succès (Code: {codeDevisEnCours.Value}).", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la création du devis : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculerTotalTTC()
        {
            if (produitsSelectionnes.Count == 0)
            {
                lblTotalTTC.Text = "0,00 €";
                return;
            }

            decimal totalHT = 0;

            foreach (var p in produitsSelectionnes)
            {
                // Récupère le prix du produit
                Produit produit = produitBLL.GetProduitById(p.CodeProduit);
                decimal prix = produit.PrixVenteHT;

                // Applique la quantité et la remise
                totalHT += (prix * p.Quantite) * (decimal)(1 - p.Remise / 100);
            }

            // Calcul TVA
            double tauxTVA = 20; // ou récupère depuis un champ si tu as NumericUpDown
            decimal totalTTC = totalHT * (1 + (decimal)tauxTVA / 100);

            lblTotalTTC.Text = $"{totalTTC:C}";
        }

    }
}
