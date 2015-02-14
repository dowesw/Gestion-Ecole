using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Ecole.TOOLS
{
    class Messages
    {
        static public DialogResult ChampsVide()
        {
            DialogResult reponse = MessageBox.Show("Les champs doivent contenir une valeur", Utils.ApplName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return reponse;
        }

        static public DialogResult ChampsVide(string element)
        {
            DialogResult reponse = MessageBox.Show("Veuillez entrer la valeur de '" + element + "'", Utils.ApplName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            return reponse;
        }

        static public DialogResult Confirmation(string action)
        {
            DialogResult reponse = MessageBox.Show("Etes sûr de vouloir " + action + " les informations?", Utils.ApplName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return reponse;
        }

        static public DialogResult Annulation()
        {
            DialogResult reponse = MessageBox.Show("Voulez-vous annuler l'action?", Utils.ApplName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            return reponse;
        }

        static public DialogResult FermerApplication()
        {
            DialogResult reponse = MessageBox.Show("Voulez-vous fermer l'application?", Utils.ApplName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            return reponse;
        }

        static public DialogResult Exception(Exception ex)
        {
            DialogResult reponse = MessageBox.Show("L'erreur suivante a été detectée : " + ex.Message, Utils.ApplName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return reponse;
        }

        static public DialogResult Inexistant(string element)
        {
            DialogResult reponse = MessageBox.Show(element + " n'existe pas", Utils.ApplName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            return reponse;
        }

        static public DialogResult Succes(string element, string action)
        {
            DialogResult reponse = MessageBox.Show(element + " " + action + " avec succès", Utils.ApplName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return reponse;
        }

        static public DialogResult Erreur(string message)
        {
            DialogResult reponse = MessageBox.Show(message, Utils.ApplName, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            return reponse;
        }

        static public DialogResult Show(string message)
        {
            DialogResult reponse = MessageBox.Show(message, Utils.ApplName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return reponse;
        }
    }
}
