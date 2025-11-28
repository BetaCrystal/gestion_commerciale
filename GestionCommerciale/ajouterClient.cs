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
    public partial class ajouterClient : Form
    {
        public ajouterClient()
        {
            InitializeComponent();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            string nomClient = textBoxNom.Text.Trim();
            string numeroTel = textBoxTel.Text.Trim();
            string faxClient = textBoxFax.Text.Trim();
            string mailClient = textBoxMail.Text.Trim();
            string numFacturation = textBoxNumFacturation.Text.Trim();
            string rueFacturation = textBoxRueFacturation.Text.Trim();
            string codeFacturation = textBoxCodeFacturation.Text.Trim();
            string villeFacturation = textBoxVilleFacturation.Text.Trim();
            string numLivraison = textBoxNumLivraison.Text.Trim();
            string rueLivraison = textBoxRueLivraison.Text.Trim();
            string codeLivraison = textBoxCodeLivraison.Text.Trim();
            string villeLivraison = textBoxVilleLivraison.Text.Trim();
            if (string.IsNullOrWhiteSpace(nomClient))
            {
                MessageBox.Show("Veuillez saisir un nom de client.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(numeroTel))
            {
                MessageBox.Show("Veuillez saisir un numéro de téléphone.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(mailClient))
            {
                MessageBox.Show("Veuillez saisir une adresse mail.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(faxClient))
            {
                MessageBox.Show("Veuillez saisir un numéro de fax.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(numFacturation) ||
                string.IsNullOrWhiteSpace(rueFacturation) ||
                string.IsNullOrWhiteSpace(codeFacturation) ||
                string.IsNullOrWhiteSpace(villeFacturation))
            {
                MessageBox.Show("Veuillez saisir toutes les informations de l'adresse de facturation.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(numLivraison) ||
                string.IsNullOrWhiteSpace(rueLivraison) ||
                string.IsNullOrWhiteSpace(codeLivraison) ||
                string.IsNullOrWhiteSpace(villeLivraison))
            {
                MessageBox.Show("Veuillez saisir toutes les informations de l'adresse de livraison.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Client c = new Client
            {
                NomClient = nomClient,
                NumTelephoneClient = numeroTel,
                NumFaxClient = faxClient,
                AdresseMailClient = mailClient,
                NumAdresseFacturationClient = numFacturation,
                RueFacturationClient = rueFacturation,
                CodePostalFacturationClient = codeFacturation,
                VilleFacturationClient = villeFacturation,
                NumAdresseLivraisonClient = numLivraison,
                RueLivraisonClient = rueLivraison,
                CodePostalLivraisonClient = codeLivraison,
                VilleLivraisonClient = villeLivraison
            };

            try
            {
                ClientBLL clientBLL = new ClientBLL();
                clientBLL.AjouterClient(c);
                MessageBox.Show("Client ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de l'ajout du client : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ajouterClient_Load(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
