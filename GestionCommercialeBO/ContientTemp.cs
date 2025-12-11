using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeBO
{
    public class ContientTemp
    {
        private int codeProduit;
        private int quantite;
        private double remise;

        public int CodeProduit
        {
            get { return codeProduit; }
            set { codeProduit = value; }
        }

        public int Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }

        public double Remise
        {
            get { return remise; }
            set { remise = value; }
        }

        public ContientTemp() { }

        public ContientTemp(int codeProduit, int quantite, double remise)
        {
            this.codeProduit = codeProduit;
            this.quantite = quantite;
            this.remise = remise;
        }

        public override string ToString()
        {
            return $"Produit {codeProduit} - Qté: {quantite}, Remise: {remise}%";
        }
    }


}
