using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeBO
{
    public class Client
    {

        public int CodeClient { get; set; }
        public string NomClient { get; set; }
        public string NumTelephoneClient { get; set; }
        public string NumFaxClient { get; set; }
        public string AdresseMailClient { get; set; }

        public string NumAdresseFacturationClient { get; set; }
        public string RueFacturationClient { get; set; }
        public string CodePostalFacturationClient { get; set; }
        public string VilleFacturationClient { get; set; }

        public string NumAdresseLivraisonClient { get; set; }
        public string RueLivraisonClient { get; set; }
        public string CodePostalLivraisonClient { get; set; }
        public string VilleLivraisonClient { get; set; }

        public Client() { }

        public Client(
        int codeClient,
        string nomClient,
        string numTelephoneClient,
        string numFaxClient,
        string adresseMailClient,
        string numAdresseFacturationClient,
        string rueFacturationClient,
        string codePostalFacturationClient,
        string villeFacturationClient,
        string numAdresseLivraisonClient,
        string rueLivraisonClient,
        string codePostalLivraisonClient,
        string villeLivraisonClient)
        {
            CodeClient = codeClient;
            NomClient = nomClient;
            NumTelephoneClient = numTelephoneClient;
            NumFaxClient = numFaxClient;
            AdresseMailClient = adresseMailClient;
            NumAdresseFacturationClient = numAdresseFacturationClient;
            RueFacturationClient = rueFacturationClient;
            CodePostalFacturationClient = codePostalFacturationClient;
            VilleFacturationClient = villeFacturationClient;
            NumAdresseLivraisonClient = numAdresseLivraisonClient;
            RueLivraisonClient = rueLivraisonClient;
            CodePostalLivraisonClient = codePostalLivraisonClient;
            VilleLivraisonClient = villeLivraisonClient;
        }

        public override string ToString()
        {
            return $"{NomClient} (Code: {CodeClient})";
        }

    }
}
