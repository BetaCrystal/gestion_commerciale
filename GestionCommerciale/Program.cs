using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using System.Configuration;
using GestionCommercialeBLL;
=======
>>>>>>> f8d224008bb874cc497a689787bf50114e583130

namespace GestionCommerciale
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new ListeProduits());
            // Initialisation de la chaîne de connexion depuis App.config 
            // (Pour se connexter à la base de données)
            //Code donné par Copilot, permet de ne pas avoir à modifier le code de la couche BLL pour la connexion
            var cs = ConfigurationManager.ConnectionStrings["Gestion_commercialeDataSet"];
            if (cs != null)
            {
                GestionUtilisateurs.SetchaineConnexion(cs);
            }
            else
            {
                MessageBox.Show("Chaîne de connexion introuvable dans App.config", "Configuration manquante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
=======
>>>>>>> f8d224008bb874cc497a689787bf50114e583130
            Application.Run(new Connexion());
        }
    }
}
