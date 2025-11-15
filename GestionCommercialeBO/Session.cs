using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Cette classe permet de créer une session qui devient True une fois l'utilisateur connecté.
 * Si elle devient False, alors l'utilisateur est déconnecté et ne peut pas accéder aux pages autres que
 * la page de connexion.
 */

namespace GestionCommercialeBO
{
    public class Session
    {
        private bool session = false;

        public Session(bool session)
        {
            this.session = session;
        }

        public bool GetSession()
        {
            return session;
        }

        public void SetSession(bool session)
        {
            this.session = session;
        }
    }
}
