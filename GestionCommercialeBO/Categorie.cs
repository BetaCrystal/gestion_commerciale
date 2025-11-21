using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeBO
{
    public class Categorie
    {

        public int CodeCategorie { get; set; }
        public string NomCategorie { get; set; }

        public Categorie() { }

        public Categorie(int codeCategorie, string nomCategorie)
        {
            CodeCategorie = codeCategorie;
            NomCategorie = nomCategorie;
        }

        public override string ToString()
        {
            return NomCategorie;
        }


    }
}
