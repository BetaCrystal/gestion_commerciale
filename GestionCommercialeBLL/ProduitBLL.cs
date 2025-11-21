using GestionCommercialeBO;
using GestionCommercialeDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionCommercialeDAL.ProduitDAL;

namespace GestionCommercialeBLL
{
    public class ProduitBLL
    {
        private ProduitDAL produitDAL = new ProduitDAL();

        public List<Produit> ChargerProduits()
        {
            return produitDAL.GetProduits();
        }

        public void SupprimerProduit(int codeProduit)
        {
            produitDAL.SupprimerProduit(codeProduit);
        }

        public void AjouterProduit(Produit p)
        {
            produitDAL.InsertProduit(p);
        }
        public Produit GetProduitById(int codeProduit)
        {
            return produitDAL.GetProduitById(codeProduit);
        }

        public void UpdateProduit(Produit p)
        {
            produitDAL.UpdateProduit(p);
        }
    }
    
}
