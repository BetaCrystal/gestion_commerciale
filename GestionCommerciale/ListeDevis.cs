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
        public ListeDevis()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListeDevis_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_commercialeDataSet.Contient'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.contientTableAdapter.Fill(this.gestion_commercialeDataSet.Contient);
            // TODO: cette ligne de code charge les données dans la table 'gestion_commercialeDataSet.Devis'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.devisTableAdapter.Fill(this.gestion_commercialeDataSet.Devis);

        }
    }
}
