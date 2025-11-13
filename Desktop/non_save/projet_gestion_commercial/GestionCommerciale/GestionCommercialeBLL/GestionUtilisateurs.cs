using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using GestionCommercialeBO;
using GestionCommercialeDAL;

namespace GestionCommercialeBLL
{
    public class GestionUtilisateurs
    {
        private static GestionUtilisateurs uneGestionUtilisateurs;

        public static GestionUtilisateurs GetGestionUtilisateurs()
        {
            if (uneGestionUtilisateurs == null)
            {
                uneGestionUtilisateurs = new GestionUtilisateurs();
            }
            return uneGestionUtilisateurs;
        }
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        public static List<Utilisateur> GetUtilisateurs()
        {
            return GestionCommercialeDAO.GetUtilisateurs();
        }

        public static bool FindUser(Utilisateur utilisateur)
        {
            Authentification auth = new Authentification();
            return auth.FindUser(utilisateur);
        }
    }
}
