using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionCommercialeDAL;
using GestionCommercialeBO;

namespace GestionCommercialeBLL
{
    public class DevisBLL
    {
        private readonly DevisDAL devisDAL = new DevisDAL();
        private readonly ContientDAL contientDAL = new ContientDAL();

        /// <summary>
        /// Crée un devis complet (entête + lignes produits).
        /// </summary>
        public int CreerDevis(int codeClient, List<ContientTemp> produitsSelectionnes, int codeStatut, DateTime dateDevis)
        {
            // Calcul automatique du montant total HT du devis
            decimal montantTotalHT = 0;
            foreach (var p in produitsSelectionnes)
            {
                // Récupérer le prix unitaire via DAL ou BLL produit
                Produit produit = new ProduitBLL().GetProduitById(p.CodeProduit);
                decimal prixUnitaire = produit.PrixVenteHT;
                montantTotalHT += (prixUnitaire * p.Quantite) * (1 - (decimal)p.Remise / 100);
            }

            // Création de l’objet Devis
            Devis devis = new Devis
            {
                DateDevis = dateDevis,
                TauxTVADevis = 20, // Par défaut (tu pourras ajuster avec ton NumericUpDown)
                MontantTotalHTDevis = (double)montantTotalHT,
                TauxRemiseGlobalDevis = 0, // à changer si tu as un champ Remise globale
                CodeClient = codeClient,
                CodeStatut = codeStatut // Par défaut (ex: "En cours")
            };

            // Insertion du devis → on récupère l’ID généré
            int codeDevisCree = devisDAL.InsertDevis(devis);

            // Insertion des lignes produits
            contientDAL.InsertContients(codeDevisCree, produitsSelectionnes);

            return codeDevisCree;
        }

        public List<Devis> ChargerDevis()
        {
            return devisDAL.ChargerDevis();
        }

        public Devis GetDevisByCode(int codeDevis)
        {
            return devisDAL.GetDevisByCode(codeDevis);
        }
        public List<Statut> GetStatuts()
        {
            return devisDAL.GetStatuts();
        }

        public void ModifierDevis(int codeDevis, int codeClient, List<ContientTemp> produitsSelectionnes, int codeStatut, DateTime dateDevis)
        {
            // Calcul automatique du montant total HT du devis
            decimal montantTotalHT = 0;
            foreach (var p in produitsSelectionnes)
            {
                Produit produit = new ProduitBLL().GetProduitById(p.CodeProduit);
                decimal prixUnitaire = produit.PrixVenteHT;
                montantTotalHT += (prixUnitaire * p.Quantite) * (1 - (decimal)p.Remise / 100);
            }

            // Mise à jour de l'entête du devis
            Devis devisModifie = new Devis
            {
                CodeDevis = codeDevis,
                CodeClient = codeClient,
                DateDevis = dateDevis,
                MontantTotalHTDevis = (double)montantTotalHT,
                TauxTVADevis = 20,
                TauxRemiseGlobalDevis = 0,
                CodeStatut = codeStatut
            };

            // Appel DAL pour mettre à jour l'entête
            devisDAL.ModifierDevis(devisModifie);

            // Supprimer les lignes produits existantes
            contientDAL.SupprimerContients(codeDevis);

            // Réinsérer les nouvelles lignes
            contientDAL.InsertContients(codeDevis, produitsSelectionnes);
        }


    }
}

