using GestionCommercialeBO;
using GestionCommercialeDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeBLL
{
    public class SyntheseClientBLL
    {
        public List<SyntheseClient> GetSyntheseClients(DateTime? dateDebut = null, DateTime? dateFin = null)
        {
            var devis = SyntheseClientDAL.GetDevis(dateDebut, dateFin);
            var clients = SyntheseClientDAL.GetClients();

            List<SyntheseClient> synthese = new List<SyntheseClient>();

            foreach (var client in clients)
            {
                var devisClient = devis.Where(d => d.CodeClient == client.CodeClient).ToList();
                if (devisClient.Count == 0)
                    continue; // uniquement les clients ayant au moins un devis

                int nbDevis = devisClient.Count;
                int nbAccepte = devisClient.Count(d => d.CodeStatut == 2);
                int nbAttente = devisClient.Count(d => d.CodeStatut == 1);
                int nbRefuse = devisClient.Count(d => d.CodeStatut == 3);
                double montantTotalHT = devisClient.Where(d => d.CodeStatut == 2).Sum(d => d.MontantTotalHTDevis);

                double pctAccepte = nbDevis > 0 ? Math.Round((double)nbAccepte / nbDevis * 100, 2) : 0;
                double pctAttente = nbDevis > 0 ? Math.Round((double)nbAttente / nbDevis * 100, 2) : 0;
                double pctRefuse = nbDevis > 0 ? Math.Round((double)nbRefuse / nbDevis * 100, 2) : 0;

                synthese.Add(new SyntheseClient
                {
                    NomClient = client.NomClient,
                    NombreDevis = nbDevis,
                    NombreDevisAccepte = nbAccepte,
                    PourcentageAccepte = pctAccepte,
                    PourcentageEnAttente = pctAttente,
                    PourcentageRefuse = pctRefuse,
                    MontantTotalHT = montantTotalHT
                });
            }

            return synthese;
        }
    }

}
