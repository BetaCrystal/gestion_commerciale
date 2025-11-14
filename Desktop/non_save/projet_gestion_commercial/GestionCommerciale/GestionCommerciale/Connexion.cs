using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using GestionCommercialeBO;
using GestionCommercialeBLL;

namespace GestionCommerciale
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings
            ["Gestion_commercialeDataSet"]);
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            Session session = new Session(false);

            Utilisateur uti = new Utilisateur(textBoxIdentifiant.Text, textBoxMdp.Text);
            bool connexion = GestionUtilisateurs.FindUser(uti);
            if (connexion == false)
            {
                //Affiche un message d'erreur si l'identifiant ou le mot de passe est incorrect
                MessageBox.Show("Identifiant ou mot de passe incorrect", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                session.SetSession(true);
                // Ouvre le formulaire ListeProduits, masque ce formulaire de connexion
                ListeProduits liste = new ListeProduits();

                // Lorsque ListeProduits est fermé, on ferme aussi la fenêtre de connexion
                // (permet de terminer proprement l'application)
                liste.FormClosed += (s, args) => this.Close();

                liste.Show();
                this.Hide();
            }
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }
    }
}
