using System;
using System.Collections.Generic;
using GestionCommercialeDAL;
using GestionCommercialeBO;

namespace GestionCommercialeBLL
{
    public class DevisBLL
    {
        private readonly DevisDAL _devisDal;

        public DevisBLL()
        {
            _devisDal = new DevisDAL();
        }

        // Récupérer tous les devis
        public List<Devis> ChargerDevis()
        {
            return _devisDal.GetDevis();
        }

        // Suppression d'un devis par son id
        public void SupprimerDevis(int codeDevis)
        {
            _devisDal.SupprimerDevis(codeDevis);
        }

        public Devis GetDevisById(int codeDevis)
        {
            return ChargerDevis().Find(devis => devis.CodeDevis == codeDevis);
        }
    }
}