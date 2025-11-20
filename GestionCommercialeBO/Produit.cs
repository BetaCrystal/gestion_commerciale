using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeBO
{
    public class Produit
    {
        public int code_produit { get; set; }
        public string libelle_produit { get; set; }
        public decimal prix_vente_ht_produit { get; set; }
        public string nom_categorie { get; set; }
        public int code_categorie { get; set; }
    }
}
