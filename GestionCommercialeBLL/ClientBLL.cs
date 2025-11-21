using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionCommercialeDAL;
using GestionCommercialeBO;
using static GestionCommercialeDAL.ClientDAL;

namespace GestionCommercialeBLL
{
    public class ClientBLL
    {
        private  ClientDAL clientDAL = new ClientDAL();

        public ClientBLL()
        {
            clientDAL = new ClientDAL();
        }

        // Récupérer tous les clients
        public List<Client> ChargerClients()
        {
            return clientDAL.GetClients();
        }

        public void SupprimerClient(int codeClient)
        {
            clientDAL.SupprimerClient(codeClient);
        }

    }
}
