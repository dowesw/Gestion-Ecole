using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Ecole.ENTITY.INSCRIPTION
{
    [Serializable]
    class Batiment
    {
        private int id;
        private string code;
        private string libelle;

        public Batiment()
        { }

        public Batiment(int id)
        {
            this.id = id;
        }

        public Batiment(int id,string code,string libelle)
        {
            this.id = id;
            this.code = code;
            this.libelle = libelle;
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
    }
}
