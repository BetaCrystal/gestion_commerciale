using GestionCommercialeDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeBLL
{
    public class CategorieBLL
    {
        private CategorieDAL categorieDAL = new CategorieDAL();

        public DataTable ChargerCategories()
        {
            return categorieDAL.GetCategories();
        }
    }
}
