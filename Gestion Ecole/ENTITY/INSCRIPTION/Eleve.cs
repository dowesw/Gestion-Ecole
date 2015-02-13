using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Ecole.ENTITY.INSCRIPTION
{
    [Serializable]
    class Eleve
    {
        private int id;
        private string matricule;
        private string nom;
        private string prenom;
        private DateTime dateNaissance;

        public Eleve()
        { }

        public Eleve(int id)
        {
            this.id = id;
        }

        public Eleve(int id, string matricule)
        {
            this.id = id;
            this.matricule = matricule;
        }

        public int getId
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public string getMatricule
        {
            set { this.matricule = value; }
            get { return this.matricule; }
        }

        public string getNom
        {
            set { this.nom = value; }
            get { return this.nom; }
        }

        public string getPrenom
        {
            set { this.prenom = value; }
            get { return this.prenom; }
        }

        public DateTime getDateNaissance
        {
            set { this.dateNaissance = value; }
            get { return this.dateNaissance; }
        }

    }
}
