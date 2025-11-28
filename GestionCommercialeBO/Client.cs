using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Classe Client
 * La méthode ToString() est redéfinie pour un affichage friendly
 */

namespace GestionCommercialeBO
{
    public class Client
    {
        private int codeClient;
        private string nomClient;
        private string numTelephoneClient;
        private string numFaxClient;
        private string adresseMailClient;
        private string numAdresseFacturationClient;
        private string rueFacturationClient;
        private string codePostalFacturationClient;
        private string villeFacturationClient;
        private string numAdresseLivraisonClient;
        private string rueLivraisonClient;
        private string codePostalLivraisonClient;
        private string villeLivraisonClient;

        public int CodeClient
        {
            get { return codeClient; }
            set { codeClient = value; }
        }
        public string NomClient
        {
            get { return nomClient; }
            set { nomClient = value; }
        }
        public string NumTelephoneClient
        {
            get { return numTelephoneClient; }
            set { numTelephoneClient = value; }
        }
        public string NumFaxClient
        {
            get { return numFaxClient; }
            set { numFaxClient = value; }
        }
        public string AdresseMailClient
        {
            get { return adresseMailClient; }
            set { adresseMailClient = value; }
        }

        public string NumAdresseFacturationClient
        {
            get { return numAdresseFacturationClient; }
            set { numAdresseFacturationClient = value; }
        }
        public string RueFacturationClient
        {
            get { return rueFacturationClient; }
            set { rueFacturationClient = value; }
        }
        public string CodePostalFacturationClient
        {
            get { return codePostalFacturationClient; }
            set {codePostalFacturationClient = value; }
        }
        public string VilleFacturationClient
        {
            get { return villeFacturationClient; }
            set { villeFacturationClient = value; }
        }

        public string NumAdresseLivraisonClient
        {
            get { return numAdresseLivraisonClient; }
            set {numAdresseFacturationClient = value; }
        }
        public string RueLivraisonClient
        {
            get { return rueLivraisonClient; }
            set { rueLivraisonClient = value;}
        }
        public string CodePostalLivraisonClient
        {
            get { return codePostalLivraisonClient; }
            set { codePostalLivraisonClient =  value; }
        }
        public string VilleLivraisonClient
        {
            get { return villeLivraisonClient; }
            set { villeLivraisonClient = value; }
        }

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
            this.codeClient = codeClient;
            this.nomClient = nomClient;
            this.numTelephoneClient = numTelephoneClient;
            this.numFaxClient = numFaxClient;
            this.adresseMailClient = adresseMailClient;
            this.numAdresseFacturationClient = numAdresseFacturationClient;
            this.rueFacturationClient = rueFacturationClient;
            this.codePostalFacturationClient = codePostalFacturationClient;
            this.villeFacturationClient = villeFacturationClient;
            this.numAdresseLivraisonClient = numAdresseLivraisonClient;
            this.rueLivraisonClient = rueLivraisonClient;
            this.codePostalLivraisonClient = codePostalLivraisonClient;
            this.villeLivraisonClient = villeLivraisonClient;
        }

        public override string ToString()
        {
            return $"{NomClient} (Code: {CodeClient})";
        }

    }
}
