using GestionCommercialeBO;
using GestionCommercialeDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionCommercialeDAL.ProduitDAL;

/*
 * Cette classe sert d'intermédiaire entre la DAL et la GUI 
 */

namespace GestionCommercialeBLL
{
    public class ProduitBLL
    {
        private ProduitDAL produitDAL = new ProduitDAL();

        //On recupère tous les produits
        public List<Produit> ChargerProduits()
        {
            return produitDAL.GetProduits();
        }

        //Suppresion d'un produit par son id
        public void SupprimerProduit(int codeProduit)
        {
            produitDAL.SupprimerProduit(codeProduit);
        }

        //Ajout d'un produit
        public void AjouterProduit(Produit p)
        {
            produitDAL.InsertProduit(p);
        }

        //Recupérer un produit par son id 
        public Produit GetProduitById(int codeProduit)
        {
            return produitDAL.GetProduitById(codeProduit);
        }

        //Modif d'un produit par son id
        public void UpdateProduit(Produit p)
        {
            produitDAL.UpdateProduit(p);
        }
    }
    
}
