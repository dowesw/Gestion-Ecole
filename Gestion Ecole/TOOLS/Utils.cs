using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Ecole.TOOLS
{
    class Utils
    {
        static public string ApplName = "Gestion Ecole";

        static public string[] Mois = new string[] { "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };

        static public void ActiverBouton(Button btn_nouv, Button btn_enreg, Button btn_supp, Button btn_annul, bool etat)
        {
            btn_nouv.Enabled = !etat;
            btn_enreg.Enabled = etat;
            btn_annul.Enabled = etat;
            btn_supp.Enabled = etat;
        }
    }
}
