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
    public partial class ModifierListeDevis : Form
    {
        private readonly DevisBLL devisBLL = new DevisBLL();
        private List<Devis> listeDevis;
        public ModifierListeDevis()
        {
            InitializeComponent();
        }

        private void ModifierListeDevis_Load(object sender, EventArgs e)
        {
            ChargerListeDevis();
        }
        private void ChargerListeDevis()
        {
            listeDevis = devisBLL.ChargerDevis();

            clbDevis.Items.Clear();

            foreach (var devis in listeDevis)
            {
                // On affiche uniquement le code_devis pour le moment
                clbDevis.Items.Add($"Code: {devis.CodeDevis} - Client: {devis.NomClient}", false);
            }
        }

        private void btnOuvrir_Click(object sender, EventArgs e)
        {
            // Vérifie qu’un devis est sélectionné
            if (clbDevis.CheckedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un devis.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // on prend le premier devis sélectionné
            int indexSelectionne = clbDevis.CheckedIndices[0];
            Devis devisSelectionne = listeDevis[indexSelectionne];

            // Ouvrir AjouterDevis en mode modification
            AjouterDevis formModif = new AjouterDevis(devisSelectionne.CodeDevis);
            formModif.ShowDialog();

            this.Close();
        }
    }
}
