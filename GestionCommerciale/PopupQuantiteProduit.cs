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
    public partial class PopupQuantiteProduit : Form
    {
        private Produit produit;
        public int Quantite { get; private set; } = 1;
        public decimal Remise { get; private set; } = 0; 

        

        public PopupQuantiteProduit(Produit produit)
        {
            InitializeComponent();

            this.produit = produit;

            // Afficher le nom du produit dans un label de la popup
            lblProduit.Text = produit.LibelleProduit;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // Récupérer les valeurs des NumericUpDown
            Quantite = (int)nudQuantite.Value;
            Remise = nudRemise.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
