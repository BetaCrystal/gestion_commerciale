using System;

namespace GestionCommercialeBO
{
    public class Devis
    {
        private int codeDevis;
        private DateTime dateDevis;
        private string statutDevis;
        private float tauxTVA;
        private float tauxRemiseGlobal;
        private float montantHTHorsRemise;
        private Client client;
        private Statut statut;

        public int CodeDevis
        {
            get { return codeDevis; }
            set { codeDevis = value; }
        }

        public DateTime DateDevis
        {
            get { return dateDevis; }
            set { dateDevis = value; }
        }

        public string StatutDevis
        {
            get { return statutDevis; }
            set { statutDevis = value; }
        }

        public float TauxTVA
        {
            get { return tauxTVA; }
            set { tauxTVA = value; }
        }

        public float TauxRemiseGlobal
        {
            get { return tauxRemiseGlobal; }
            set { tauxRemiseGlobal = value; }
        }

        public float MontantHTHorsRemise
        {
            get { return montantHTHorsRemise; }
            set { montantHTHorsRemise = value; }
        }

        public Client Client
        {
            get { return client; }
            set { client = value; }
        }

        public Statut Statut
        {
            get { return statut; }
            set { statut = value; }
        }

        public Devis(int codeDevis,
                     DateTime dateDevis,
                     string statutDevis,
                     float tauxTVA,
                     float tauxRemiseGlobal,
                     float montantHTHorsRemise,
                     Client client,
                     Statut statut)
        {
            this.codeDevis = codeDevis;
            this.dateDevis = dateDevis;
            this.statutDevis = statutDevis;
            this.tauxTVA = tauxTVA;
            this.tauxRemiseGlobal = tauxRemiseGlobal;
            this.montantHTHorsRemise = montantHTHorsRemise;
            this.client = client;
            this.statut = statut;
        }

        // Propriétés additionnelles pour le binding (robustes)
        public int ClientId
        {
            get { return client != null ? client.CodeClient : 0; }
        }

        public int StatutId
        {
            get { return statut != null ? statut.CodeStatut : 0; }
        }

        // Vous pouvez aussi exposer des valeurs lisibles :
        public string ClientAffichage
        {
            get
            {
                // si Client a NomClient
                return client != null ? client.NomClient : string.Empty;
            }
        }

        public string StatutAffichage
        {
            get
            {
                // si Statut a LibelleStatut ou similaire
                return statut != null ? statut.LibelleStatut : string.Empty;
            }
        }
    }
}