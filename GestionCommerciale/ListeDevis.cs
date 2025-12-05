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
            this.Load += ListeDevis_Load;

            devisBLL = new DevisBLL();

            // Préparer le DataGridView pour le binding
            dgvDevis.AutoGenerateColumns = false; // si vous utilisez des colonnes définies dans le Designer
            dgvDevis.DataSource = bindingSourceDevis;
        }

        private void ChargerDevis()
        {
            var devis = devisBLL.ChargerDevis();
            bindingSourceDevis.DataSource = devis;
        }

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
            if (dgvDevis.Columns[e.ColumnIndex].Name == "btnSupprimer" && e.RowIndex >= 0)
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
            if (dgvDevis.Columns[e.ColumnIndex].Name == "btnModifier")
            {
                devis = (Devis)dgvDevis.Rows[e.RowIndex].DataBoundItem;
                codeDevis = devis.CodeDevis;

                modifierClient formModifier = new modifierClient(codeDevis);
                formModifier.ShowDialog();

                ChargerDevis();
            }
        }
    }
}
