using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionCommercialeDAL;
using GestionCommercialeBO;
using static GestionCommercialeDAL.DevisDAL;

namespace GestionCommercialeBLL
{
    public class DevisBLL
    {
        private DevisBLL devisBLL;

        public DevisBLL()
        {
            devisBLL = new DevisBLL();
        }

        // Récupérer tous les devis
        public List<DevisBLL> ChargerDevis()
        {
            return devisBLL.ChargerDevis();
        }

        //Suppresion d'un devis par son id
        public void SupprimerDevis(int codeDevis)
        {
            devisBLL.SupprimerDevis(codeDevis);
        }

        public Devis GetDevisById(int codeDevis)
        {
            return devisBLL.GetDevisById(codeDevis);
        }
    }
}
