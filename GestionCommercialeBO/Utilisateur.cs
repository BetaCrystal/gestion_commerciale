using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeBO
{
    public class Utilisateur
    {
        private string identifiant;
        private string mdp;

        public Utilisateur (string identifiant, string mdp)
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
