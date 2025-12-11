using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionCommercialeBO;
using GestionCommercialeDAL;
using static GestionCommercialeDAL.StatutDAL;


namespace GestionCommercialeBLL
{
    public class StatutBLL
    {
        public StatutDAL statutDAL = new StatutDAL();

        public List<Statut> ChargerStatuts()
        {
            return statutDAL.GetStatuts();
        }
    }
}
