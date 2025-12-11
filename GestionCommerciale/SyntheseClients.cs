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
    public partial class SyntheseClients : Form
    {
        private readonly SyntheseClientBLL syntheseClientBLL = new SyntheseClientBLL();
        public SyntheseClients()
        {
            InitializeComponent();
        }

        private void SyntheseClient_Load(object sender, EventArgs e)
        {
            ChargerSyntheseClients();
        }

        private void btnRafraichir_Click(object sender, EventArgs e)
        {
            ChargerSyntheseClients();
        }

        private void ChargerSyntheseClients()
        {
            try
            {
                List<SyntheseClient> syntheses = syntheseClientBLL.GetSyntheseClients();
                dtgSynthese.AutoGenerateColumns = false;
                dtgSynthese.DataSource = syntheses;

                // Calcul total général
                double totalGlobalHT = 0;
                foreach (var s in syntheses)
                    totalGlobalHT += s.MontantTotalHT;

                lblTotalGeneral.Text = $"Total HT facturé : {totalGlobalHT:C2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement de la synthèse : " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOuvrirProduit_Click(object sender, EventArgs e)
        {
            ListeProduits liste = new ListeProduits();

            // Lorsque ListeProduits est fermé, on ferme aussi la fenêtre de connexion
            // (permet de terminer proprement l'application)
            liste.FormClosed += (s, args) => this.Close();

            liste.Show();
            this.Hide();
        }

        private void btnListeDevis_Click(object sender, EventArgs e)
        {
            ListeDevisTemp listeDevisTemp = new ListeDevisTemp();

            listeDevisTemp.FormClosed += (s, args) => this.Close();

            listeDevisTemp.Show();
            this.Hide();
        }

        private void btnListeClient_Click(object sender, EventArgs e)
        {
            // Instancie le Form ListeClients
            ListeClients listeClientsForm = new ListeClients();

            //(permet de terminer proprement l'application)
            listeClientsForm.FormClosed += (s, args) => this.Close();

            // Ouvre le Form Client
            listeClientsForm.Show();
            this.Hide();
        }

        private void lblDateDebut_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrer_Click(object sender, EventArgs e)
        {
            DateTime dateDebut = dtpDateDebut.Value.Date;
            DateTime dateFin = dtpDateFin.Value.Date;

            if (dateDebut > dateFin)
            {
                MessageBox.Show("La date de début doit être antérieure à la date de fin.",
                    "Erreur de filtre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<SyntheseClient> synthesesFiltrees = syntheseClientBLL.GetSyntheseClients(dateDebut, dateFin);


                // Actualisation du DataGridView
                dtgSynthese.DataSource = synthesesFiltrees;

                // Recalcul du total
                double totalGlobalHT = synthesesFiltrees.Sum(s => s.MontantTotalHT);
                lblTotalGeneral.Text = $"Total HT facturé : {totalGlobalHT:C2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du filtrage : " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

