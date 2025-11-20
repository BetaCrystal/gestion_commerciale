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

<<<<<<< HEAD
        public Connexion(bool connexion) 
=======
        public Connexion(bool connexion)
>>>>>>> f8d224008bb874cc497a689787bf50114e583130
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
