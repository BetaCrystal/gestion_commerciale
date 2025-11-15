using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionCommercialeBO;
using System.Data.SqlClient;

namespace GestionCommercialeDAL
{
    public class GestionCommercialeDAO
    {
        private static GestionCommercialeDAO uneGestionCommercialeDAO;

        public static GestionCommercialeDAO GetuneGestionCommercialeDAO()
        {
            if (uneGestionCommercialeDAO == null)
            {
                uneGestionCommercialeDAO = new GestionCommercialeDAO();
            }
            return uneGestionCommercialeDAO;
        }
        public static List<Utilisateur> GetUtilisateurs()
        {
            int id;
            string identifiant;
            string mdp;
            Utilisateur unUtilisateur;

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            List<Utilisateur> lesUtilisateurs = new List<Utilisateur>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM Utilisateur";
            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                id = Int32.Parse(monReader["code_utilisateur"].ToString());
                if (monReader["identifiant_utilisateur"] == DBNull.Value)
                {
                    identifiant = default(string);
                }
                else
                {
                    identifiant = monReader["identifiant_utilisateur"].ToString();
                }
                if (monReader["mdp_utilisateur"] == DBNull.Value)
                {
                    mdp = default(string);
                }
                else
                {
                    mdp = monReader["mdp_utilisateur"].ToString();
                }
                unUtilisateur = new Utilisateur(identifiant, mdp);
                lesUtilisateurs.Add(unUtilisateur);
            }
            maConnexion.Close();
            return lesUtilisateurs;
        }
    }
}
