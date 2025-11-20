using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeBO
{
    public class Produit
    {
<<<<<<< HEAD
        public int code_produit { get; set; }
        public string libelle_produit { get; set; }
        public decimal prix_vente_ht_produit { get; set; }
        public string nom_categorie { get; set; }
        public int code_categorie { get; set; }
    }
=======
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


>>>>>>> f8d224008bb874cc497a689787bf50114e583130
}
