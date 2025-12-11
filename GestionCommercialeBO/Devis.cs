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
        private double tauxTVADevis;
        private double montantTotalHTDevis;
        private double tauxRemiseGlobalDevis;
        private int codeClient;
        private int codeStatut;
        private string nomClient;
        private List<ContientTemp> produits = new List<ContientTemp>();
        private string statutDevis;
        private float tauxTVA;
        private float tauxRemiseGlobal;
        private float montantHTHorsRemise;
        /*private float montantHTAvecRemise;
        private float montantTTC;
        private float montantTVA;*/
        private Client client;
        private Statut statut;

        public List<Contient> Lignes { get; set; } = new List<Contient>();

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

        public double TauxTVADevis
        {
            get { return tauxTVADevis; }
            set { tauxTVADevis = value; }
        }

        public double MontantTotalHTDevis
        {
            get { return montantTotalHTDevis; }
            set { montantTotalHTDevis = value; }
        }

        public double TauxRemiseGlobalDevis
        {
            get { return tauxRemiseGlobalDevis; }
            set { tauxRemiseGlobalDevis = value; }
        }

        public int CodeClient
        {
            get { return codeClient; }
            set { codeClient = value; }
        }

        public int CodeStatut
        {
            get { return codeStatut; }
            set { codeStatut = value; }
        }

        public string NomClient
        {
            get { return nomClient; }
            set { nomClient = value; }
        }

        public List<ContientTemp> Produits
        {
            get { return produits; }
            set { produits = value; }
        }

        public Devis() { }

        public Devis(int codeDevis, DateTime dateDevis, double tauxTVA, double montantHT, double remise, int codeClient, int codeStatut)
        {
            this.codeDevis = codeDevis;
            this.dateDevis = dateDevis;
            this.tauxTVADevis = tauxTVA;
            this.montantTotalHTDevis = montantHT;
            this.tauxRemiseGlobalDevis = remise;
            this.codeClient = codeClient;
            this.codeStatut = codeStatut;
        }

        public override string ToString()
        {
            return $"Devis {codeDevis} - Client: {NomClient} - Total HT: {montantTotalHTDevis:C}";
        }
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

        /*public float MontantHTAvecRemise
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
        }*/

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

        // Récupérer le nom du client et le nom du statut pour les afficher dans la datagridview
        public string ClientNom
        {
            get { return client != null ? (client.NomClient ?? string.Empty) : string.Empty; }
        }

        public string StatutNom
        {
            get { return statut != null ? (statut.NomStatut ?? string.Empty) : string.Empty; }
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
            /*this.montantHTAvecRemise = montantHTHorsRemise * tauxRemiseGlobal;
            this.montantTVA = montantHTHorsRemise * (1 - tauxTVA);
            this.montantTTC = (montantHTHorsRemise - montantTVA) * tauxRemiseGlobal;*/
            this.client = client;
            this.statut = statut;
        }

        /*public void RecalculerMontantsFromLignes()
        {
            float sum = 0f;
            if (Lignes != null)
            {
                foreach (var ligne in Lignes)
                {
                    // Priorité : si Contient a une référence Produit avec prix, utilisez-la.
                    float prixUnitaire = 0f;
                    try
                    {
                        if (ligne.Produit != null)
                        {
                            // adapter le nom de la propriété prix si besoin (ex: PrixVenteHT)
                            prixUnitaire = ligne.Produit.PrixVenteHT;
                        }
                        else
                        {
                            // fallback sur une propriété PrixUnitaire dans Contient
                            prixUnitaire = ligne.PrixUnitaire;
                        }
                    }
                    catch
                    {
                        prixUnitaire = ligne.PrixUnitaire;
                    }

                    sum += prixUnitaire * (float)ligne.Quantite;
                }
            }

            montantHTHorsRemise = sum;
        }

        // Propriétés calculées exposées pour le binding
        public float MontantHTAvecRemise => (montantHTHorsRemise * (1f - tauxRemiseGlobal));

        public float MontantTVA => (MontantHTAvecRemise * tauxTVA);

        public float MontantTTC => (MontantHTAvecRemise + MontantTVA);*/
    }
}
