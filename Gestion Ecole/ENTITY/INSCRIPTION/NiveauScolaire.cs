using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Ecole.ENTITY.INSCRIPTION
{
    [Serializable]
    class NiveauScolaire
    {
        private int id;
        private int anneeScolaire;
        private Eleve eleve = new Eleve();
        private Classe classe = new Classe();

        public NiveauScolaire()
        { }

        public NiveauScolaire(int id)
        {
            this.id = id;
        }

        public int getId
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public int getAnneeScolaire
        {
            set { this.anneeScolaire = value; }
            get { return this.anneeScolaire; }
        }

        public Eleve getEleve
        {
            set { this.eleve = value; }
            get { return this.eleve; }
        }

        public Classe getClasse
        {
            set { this.classe = value; }
            get { return this.classe; }
        }
    }
}
