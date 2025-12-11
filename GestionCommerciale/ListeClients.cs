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
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestionCommerciale
{
    public partial class ListeClients : Form
    {
        //Instance de la couche BLL
        private readonly ClientBLL clientBLL = new ClientBLL();
        public ListeClients()
        {
            InitializeComponent();
            this.Load += ListeClients_Load;
        }

        private void ListeClients_Load(object sender, EventArgs e)
        {
            dtgClient.AllowUserToAddRows = false;
            ChargerClients();
        }
        private void ChargerClients()
        {
            var clients = clientBLL.ChargerClients();

            dtgClient.AutoGenerateColumns = false;
            dtgClient.DataSource = clients;
        }

        // Action au click pour Suppresion d'un client avec demande de confirmation
        private void dtgClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var client = (Client)dtgClient.Rows[e.RowIndex].DataBoundItem;
            int codeClient = client.CodeClient;
            if (dtgClient.Columns[e.ColumnIndex].Name == "btnSupprimer" && e.RowIndex >= 0)
            {
                
                DialogResult result = MessageBox.Show(
                    $"Voulez-vous vraiment supprimer le client '{client.NomClient}' ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        clientBLL.SupprimerClient(client.CodeClient);
                        ChargerClients();
                        MessageBox.Show("Client supprimé avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message, "Suppression impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                }
            }
            // modifier
            if (dtgClient.Columns[e.ColumnIndex].Name == "Modifier")
            {
                client = (Client)dtgClient.Rows[e.RowIndex].DataBoundItem;
                codeClient = client.CodeClient;

                modifierClient formModifier = new modifierClient(codeClient);
                formModifier.ShowDialog();

                ChargerClients();
            }
            /*using (var formModifier = new modifierClient(codeClient))
            {
                var result = formModifier.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Recharge la liste depuis la BLL
                    ChargerClients();

                    // Si vous utilisez un BindingSource du designer, forcer le refresh
                    // this.devisBindingSource.ResetBindings(false); // adapter le nom du bindingSource si nécessaire
                }
            }*/
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

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            ajouterClient formAjout = new ajouterClient();
            formAjout.ShowDialog();

            ChargerClients();
        }

        private void btnListeDevis_Click(object sender, EventArgs e)
        {
            ListeDevis listeDevis = new ListeDevis();

            listeDevis.FormClosed += (s, args) => this.Close();

            listeDevis.Show();
            ListeDevisTemp listeDevisTemp = new ListeDevisTemp();

            listeDevisTemp.FormClosed += (s, args) => this.Close();

            listeDevisTemp.Show();
            this.Hide();
        }

        private void btnSyntheseClient_Click(object sender, EventArgs e)
        {
            SyntheseClients syntheseClients = new SyntheseClients();

            syntheseClients.FormClosed += (s, args) => this.Close();

            syntheseClients.Show();
            this.Hide();
        }
    }
}
