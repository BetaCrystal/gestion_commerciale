using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeBO
{
    public class Statut
    {
        private int codeStatut;
        private string nomStatut;
        public int CodeStatut
        {
            get { return codeStatut; }
            set { codeStatut = value; }
        }
        public string NomStatut
        {
            get { return nomStatut; }
            set { nomStatut = value; }
        }
        public Statut(int codeStatut, string nomStatut)
        {
            this.codeStatut = codeStatut;
            this.nomStatut = nomStatut;
        }
    }
}
