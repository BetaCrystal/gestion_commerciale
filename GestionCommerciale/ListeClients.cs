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
    }
}
