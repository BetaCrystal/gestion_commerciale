using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionCommercialeDAL;
using GestionCommercialeBO;
using static GestionCommercialeDAL.ClientDAL;

/*
 * Cette classe sert d'intermédiaire entre la DAL et la GUI 
 */

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

        //Suppresion d'un client par son id
        public void SupprimerClient(int codeClient)
        {
            clientDAL.SupprimerClient(codeClient);
        }

    }
}
