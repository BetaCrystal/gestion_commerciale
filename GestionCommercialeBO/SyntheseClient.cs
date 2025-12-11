using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeBO
{
    public class SyntheseClient
    {
        private string nomClient;
        private int nombreDevis;
        private int nombreDevisAccepte;
        private double pourcentageAccepte;
        private double pourcentageEnAttente;
        private double pourcentageRefuse;
        private double montantTotalHT;
        private List<Devis> devis;

        public string NomClient
        {
            get { return nomClient; }
            set { nomClient = value; }
        }

        public int NombreDevis
        {
            get { return nombreDevis; }
            set { nombreDevis = value; }
        }

        public int NombreDevisAccepte
        {
            get { return nombreDevisAccepte; }
            set { nombreDevisAccepte = value; }
        }

        public double PourcentageAccepte
        {
            get { return pourcentageAccepte; }
            set { pourcentageAccepte = value; }
        }

        public double PourcentageEnAttente
        {
            get { return pourcentageEnAttente; }
            set { pourcentageEnAttente = value; }
        }

        public double PourcentageRefuse
        {
            get { return pourcentageRefuse; }
            set { pourcentageRefuse = value; }
        }

        public double MontantTotalHT
        {
            get { return montantTotalHT; }
            set { montantTotalHT = value; }
        }

        public List<Devis> Devis
        {
            get { return devis; }
            set { devis = value; }
        }

        public SyntheseClient()
        {
            devis = new List<Devis>();
        }

        public SyntheseClient(string nomClient, int nombreDevis, int nombreAccepte, double pourcentageAccepte,
                              double pourcentageEnAttente, double pourcentageRefuse, double montantTotalHT, List<Devis> devis)
        {
            this.nomClient = nomClient;
            this.nombreDevis = nombreDevis;
            this.nombreDevisAccepte = nombreAccepte;
            this.pourcentageAccepte = pourcentageAccepte;
            this.pourcentageEnAttente = pourcentageEnAttente;
            this.pourcentageRefuse = pourcentageRefuse;
            this.montantTotalHT = montantTotalHT;
            this.devis = devis ?? new List<Devis>();
        }

        public override string ToString()
        {
            return $"{NomClient} - {NombreDevis} devis, {NombreDevisAccepte} acceptés, Total HT: {MontantTotalHT:C2}";
        }
    }


}
