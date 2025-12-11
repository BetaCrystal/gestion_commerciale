using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionCommercialeBLL;
using GestionCommercialeBO;

namespace GestionCommerciale
{
    public partial class ListeDevis : Form
    {
        private readonly DevisBLL devisBLL;
        private readonly BindingSource bindingSourceDevis = new BindingSource();

        public ListeDevis()
        {
            InitializeComponent();
            dgvDevis.CellFormatting += DgvDevis_CellFormatting;
            this.Load += ListeDevis_Load;

            devisBLL = new DevisBLL();

            dgvDevis.AutoGenerateColumns = false; //Affiche les données lorsqu'on change true par false. Erreur de nommage à trouver
            dgvDevis.DataSource = bindingSourceDevis;

            dgvDevis.CellFormatting += DgvDevis_CellFormatting;
        }

        private void ChargerDevis()
        {
            var devis = devisBLL.ChargerDevis();
            bindingSourceDevis.DataSource = devis;
        }

        // test pour corriger non affichage des devis
        /*private void ChargerDevis()
        {
            List<Devis> liste = null;
            try
            {
                liste = devisBLL.ChargerDevis();
            }
            catch (Exception ex)
            {
                // log minimal pour voir l'erreur
                System.Diagnostics.Debug.WriteLine("Erreur ChargerDevis(): " + ex);
                MessageBox.Show("Erreur lors du chargement des devis : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                liste = new List<Devis>();
            }

            // diagnostic rapide
            System.Diagnostics.Debug.WriteLine($"ChargerDevis: liste == null? {liste == null} count={(liste != null ? liste.Count.ToString() : "0")}");

            // bind et forcer rafraîchissement
            bindingSourceDevis.DataSource = liste ?? new List<Devis>();
            bindingSourceDevis.ResetBindings(false);
            dgvDevis.Refresh();
        }*/

        private void ListeDevis_Load(object sender, EventArgs e)
        {
            ChargerDevis();
        }

        private void btnListeProduits_Click(object sender, EventArgs e)
        {
            ListeProduits listeProduits = new ListeProduits();

            listeProduits.FormClosed += (s, args) => this.Close();

            listeProduits.Show();
            this.Hide();
        }

        private void btnListeClients_Click(object sender, EventArgs e)
        {
            ListeClients listeClients = new ListeClients();

            listeClients.FormClosed += (s, args) => this.Close();
            listeClients.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvDevis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var devis = (Devis)dgvDevis.Rows[e.RowIndex].DataBoundItem;
            int codeDevis = devis.CodeDevis;
            if (dgvDevis.Columns[e.ColumnIndex].Name == "btnSupprimerDevis" && e.RowIndex >= 0)
            {

                DialogResult result = MessageBox.Show(
                    $"Voulez-vous vraiment supprimer le devis '{devis.CodeDevis}' ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        devisBLL.SupprimerDevis(devis.CodeDevis);
                        ChargerDevis();
                        MessageBox.Show("Devis supprimé avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message, "Suppression impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            // modifier
            /*if (dgvDevis.Columns[e.ColumnIndex].Name == "btnModifier")
            {
                devis = (Devis)dgvDevis.Rows[e.RowIndex].DataBoundItem;
                codeDevis = devis.CodeDevis;

                modifierClient formModifier = new modifierClient(codeDevis);
                formModifier.ShowDialog();

                ChargerDevis();
            }*/
        }

        // handler
        private void DgvDevis_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvDevis.Rows[e.RowIndex];
            var devis = row.DataBoundItem as Devis;
            if (devis == null) return;

            // calcule HT à partir des lignes Contient
            float ht = 0f;
            if (devis.Lignes != null)
            {
                foreach (var ligne in devis.Lignes)
                {
                    if (ligne == null) continue;
                    var produit = ligne.Produit;
                    float prix = 0f;
                    if (produit != null)
                    {
                        // adaptez le type selon Produit.PrixVenteHT (float/double/decimal)
                        prix = Convert.ToSingle(produit.PrixVenteHT);
                    }
                    int qte = ligne.QuantiteProduit;
                    float remiseProduit = ligne.RemiseProduit; // vérifier si en base c'est 10 => 10% => diviser par 100
                                                               // si remise est en pourcentage (10), convertissez: if (remiseProduit > 1f) remiseProduit /= 100f;
                    if (remiseProduit > 1f) remiseProduit /= 100f;

                    float prixApresRemiseProduit = prix * (1f - remiseProduit);
                    ht += prixApresRemiseProduit * qte;
                }
            }

            // idem pour taux global et TVA : vérifier s'ils sont en pourcentages
            float tauxRemiseGlobal = devis.TauxRemiseGlobal;
            if (tauxRemiseGlobal > 1f) tauxRemiseGlobal /= 100f;
            float tauxTVA = devis.TauxTVA;
            if (tauxTVA > 1f) tauxTVA /= 100f;

            float htAvecRemise = ht * (1f - tauxRemiseGlobal);
            float tva = htAvecRemise * tauxTVA;
            float ttc = htAvecRemise + tva;

            var colName = dgvDevis.Columns[e.ColumnIndex].Name;
            if (colName == "montant_ht_avec_remise")
            {
                e.Value = htAvecRemise.ToString("N2");
                e.FormattingApplied = true;
            }
            else if (colName == "montant_tva")
            {
                e.Value = tva.ToString("N2");
                e.FormattingApplied = true;
            }
            else if (colName == "montant_ttc")
            {
                e.Value = ttc.ToString("N2");
                e.FormattingApplied = true;
            }
        }
    }
}
