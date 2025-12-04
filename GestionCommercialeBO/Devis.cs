using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private float montantHTAvecRemise;
        private float montantTTC;
        private float montantTVA;
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

        public float MontantHTAvecRemise
        {
            get { return montantHTAvecRemise; }
            set { montantHTAvecRemise = montantHTHorsRemise * tauxRemiseGlobal; }
        }

        public float MontantTTC
        {
            get { return montantTTC; }
            set { montantTTC = (montantHTHorsRemise - montantTVA) * tauxRemiseGlobal; }
        }

        public float MontantTVA
        {
            get { return montantTVA; }
            set { montantTVA = montantHTHorsRemise * (1 - tauxTVA); }
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
            this.montantHTAvecRemise = montantHTHorsRemise * tauxRemiseGlobal;
            this.montantTVA = montantHTHorsRemise * (1 - tauxTVA);
            this.montantTTC = (montantHTHorsRemise - montantTVA) * tauxRemiseGlobal;
            this.client = client;
            this.statut = statut;
        }

    }
}
