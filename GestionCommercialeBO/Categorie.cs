using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Classe categorie
 * La méthode ToString() est redéfinie pour un affichage friendly
 */

namespace GestionCommercialeBO
{
    public class Categorie
    {
        private int codeCategorie;
        private string nomCategorie;
        
        public int CodeCategorie
        {
            get { return codeCategorie; }
            set { codeCategorie = value; }
        }

        public string NomCategorie
        {
            get { return nomCategorie; }
            set { nomCategorie = value; }
        }

        public Categorie() { }

        public Categorie(int codeCategorie, string nomCategorie)
        {
            this.codeCategorie = codeCategorie;
            this.nomCategorie = nomCategorie;
        }

        public override string ToString()
        {
            return NomCategorie;
        }


    }
}
