using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Ecole.ENTITY.INSCRIPTION
{
    [Serializable]
    class Classe
    {
        private int id;
        private string code;
        private string libelle;
        private double montant;
        private Batiment batiment = new Batiment();

        public Classe()
        { }

        public Classe(int id)
        {
            this.id = id;
        }

        public int getId
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public string getCode
        {
            set { this.code = value; }
            get { return this.code; }
        }

        public string getLibelle
        {
            set { this.libelle = value; }
            get { return this.libelle; }
        }

        public double getMontant
        {
            set { this.montant = value; }
            get { return this.montant; }
        }

        public Batiment getBatiment
        {
            set { this.batiment = value; }
            get { return this.batiment; }
        }
    }
}
