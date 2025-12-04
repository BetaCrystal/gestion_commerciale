using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeBO
{
    public class Contient
    {
        private Produit produit;
        private Devis devis;
        private float remiseProduit;
        private int quantiteProduit;

        public Produit Produit
        {
            get { return produit; }
            set { produit = value; }
        }

        public Devis Devis
        {
            get { return devis; }
            set { devis = value; }
        }

        public float RemiseProduit
        {
            get { return remiseProduit; }
            set { remiseProduit = value; }
        }

        public int QuantiteProduit
        {
            get { return quantiteProduit; }
            set { quantiteProduit = value; }
        }

        public Contient(Produit produit, Devis devis, float remiseProduit, int quantiteProduit)
        {
            this.produit = produit;
            this.devis = devis;
            this.remiseProduit = remiseProduit;
            this.quantiteProduit = quantiteProduit;
        }

        }
}
