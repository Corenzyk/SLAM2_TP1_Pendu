using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SLAM2_TP1_Pendu.Model;

namespace SLAM2_TP1_Pendu.Controllers
{
    internal class Mots
    {
        private DataTable dtListeMots;

        /*public DataTable GetListeMots()
        {
            DataTable dtLisMots = new DataTable();
            Connection conn = new Connection();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(" Ici ecrire la requête SQL permetant d’afficher la liste des mots ainsi que la difficulté", conn.connection))
                {
                    conn.connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtListeMots.Load(reader);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dtListeMots;
        }*/
    }
}
