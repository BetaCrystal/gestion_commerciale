using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeDAL
{
    public class CategorieDAL
    {
        private readonly string connectionString = "Data Source=psl23-p16;Initial Catalog=Gestion_commerciale;Integrated Security=True;";

        public DataTable GetCategories()
        {
            string query = "SELECT code_categorie, nom_categorie FROM categorie";
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
            {
                conn.Open();
                da.Fill(dt);
            }

            return dt;
        }
    }
}
