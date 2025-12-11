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
    public partial class ListeDevisTemp : Form
    {
        public ListeDevisTemp()
        {
            InitializeComponent();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            // Ouvrir la fenêtre ListeDevis
            //ListeDevis listeDevis = new ListeDevis();
            ModifierListeDevis modifierListeDevis = new ModifierListeDevis();
            //listeDevis.ShowDialog();
            modifierListeDevis.ShowDialog();
        }

        private void btnAjouterDevis_Click(object sender, EventArgs e)
        {
            // On ouvre le formulaire AjouterDevis en mode ajout
            AjouterDevis ajouterDevisForm = new AjouterDevis();

            ajouterDevisForm.ShowDialog();

            // Après fermeture de AjouterDevis
            //ChargerListeDevis();
        }
    }
}
