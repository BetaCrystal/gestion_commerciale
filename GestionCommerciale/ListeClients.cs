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
        private ClientBLL clientBLL = new ClientBLL();
        public ListeClients()
        {
            InitializeComponent();
        }
        private void ChargerClients()
        {
            var clients = clientBLL.ChargerClients();

            dtgClient.AutoGenerateColumns = false;
            dtgClient.DataSource = clients;
        }
    }
}
