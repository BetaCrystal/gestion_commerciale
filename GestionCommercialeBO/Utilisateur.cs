using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
/*
 * Classe permettant de créer un utilisateur avec son identifiant et son mot de passe afin de vérifier
 * s'il existe bien dans la base de données et permettre sa connexion.
 */

=======
>>>>>>> f8d224008bb874cc497a689787bf50114e583130
namespace GestionCommercialeBO
{
    public class Utilisateur
    {
        private string identifiant;
        private string mdp;

<<<<<<< HEAD
        public Utilisateur (string identifiant, string mdp)
=======
        public Utilisateur(string identifiant, string mdp)
>>>>>>> f8d224008bb874cc497a689787bf50114e583130
        {
            this.identifiant = identifiant;
            this.mdp = mdp;
        }
        public string GetIdentifiant()
        {
            return identifiant;
        }
        public string GetMdp()
        {
            return mdp;
        }
        public void SetIdentifiant(string identifiant)
        {
            this.identifiant = identifiant;
        }
        public void SetMdp(string mdp)
        {
            this.mdp = mdp;
        }
    }
}
