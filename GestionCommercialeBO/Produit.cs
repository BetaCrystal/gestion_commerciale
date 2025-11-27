using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Classe Prdouit utilisant la classe categorie 
 * La méthode ToString() est redéfinie pour un affichage friendly
 */
namespace GestionCommercialeBO
{
    public class Produit
    {
        private int codeProduit;
        private string libelleProduit;
        private decimal prixVenteHT;
        private Categorie categorieProduit;


        public int CodeProduit 
        {
            get { return codeProduit;}
            set { codeProduit = value; }        
        }
        public string LibelleProduit
        {
            get { return libelleProduit; }
            set { libelleProduit = value; }
        }
        public decimal PrixVenteHT
        {
            get { return prixVenteHT; }
            set { prixVenteHT = value; }
        }
        public Categorie CategorieProduit
        {
            get { return categorieProduit; }
            set { categorieProduit = value; }
        }

        public Produit() { }


        public Produit(int codeProduit, string libelleProduit, decimal prixVenteHT, Categorie categorieProduit)
        {
            this.codeProduit = codeProduit;
            this.libelleProduit = libelleProduit;
            this.prixVenteHT = prixVenteHT;
            this.categorieProduit = categorieProduit;
        }

        public override string ToString()
        {
            return $"{LibelleProduit} - {PrixVenteHT:C} ({CategorieProduit?.NomCategorie})";
        }


    }


}
