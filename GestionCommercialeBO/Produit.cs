using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeBO
{
    public class Produit
    {
        public int CodeProduit { get; set; }
        public string LibelleProduit { get; set; }
        public decimal PrixVenteHT { get; set; }
        public Categorie CategorieProduit { get; set; }

        public Produit() { }


        public Produit(int codeProduit, string libelleProduit, decimal prixVenteHT, Categorie categorieProduit)
        {
            CodeProduit = codeProduit;
            LibelleProduit = libelleProduit;
            PrixVenteHT = prixVenteHT;
            CategorieProduit = categorieProduit;
        }

        public override string ToString()
        {
            return $"{LibelleProduit} - {PrixVenteHT:C} ({CategorieProduit?.NomCategorie})";
        }


    }


}
