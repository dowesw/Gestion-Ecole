using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Ecole.ENTITY.INSCRIPTION
{
    [Serializable]
    class Paiement
    {
        private int id;
        private DateTime datePaiement;
        private double montant;
        private Eleve eleve = new Eleve();

        public Paiement()
        { }

        public Paiement(int id)
        {
            this.id = id;
        }

        public int getId
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public DateTime getDatePaiement
        {
            set { this.datePaiement = value; }
            get { return this.datePaiement; }
        }

        public double getMontant
        {
            set { this.montant = value; }
            get { return this.montant; }
        }

        public Eleve getEleve
        {
            set { this.eleve = value; }
            get { return this.eleve; }
        }
    }
}
