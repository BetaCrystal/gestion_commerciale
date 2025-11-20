using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeBO
{
    internal class Connexion
    {
        private bool connexion = false;

        public Connexion(bool connexion)
        {
            this.connexion = connexion;
        }

        public bool getConnexion()
        {
            return connexion;
        }

        public void setConnexion(bool connexion)
        {
            this.connexion = connexion;
        }
    }
}
