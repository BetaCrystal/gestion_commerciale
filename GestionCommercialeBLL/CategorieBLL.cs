using GestionCommercialeDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Cette classe sert d'intermédiaire entre la DAL et la GUI 
 */
namespace GestionCommercialeBLL
{
    public class CategorieBLL
    {
        private CategorieDAL categorieDAL = new CategorieDAL();

        //Recupère toute les categorie depuis la bdd sous forme de Datatable
        public DataTable ChargerCategories()
        {
            return categorieDAL.GetCategories();
        }
    }
}
