using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Data;

namespace Gestion_Ecole.TOOLS
{
    class Connexion
    {
        public MySqlConnection getConnection()
        {
            try
            {
                string constr = "server=127.0.0.1;User Id=root;Password='';database=gestion_ecole";
                MySqlConnection con = new MySqlConnection(constr);
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                Messages.Exception(ex);
                return null;
            }
        }
    }
}
