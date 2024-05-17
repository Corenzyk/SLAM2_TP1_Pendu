using SLAM2_TP1_Pendu.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SLAM2_TP1_Pendu.Controllers
{
    internal class Difficulte
    {
        private DataTable dtListeDifficulte;
        private Connexion conn;

        #region Recupération liste difficulté
        public DataTable GetListeDifficulte()
        {
            dtListeDifficulte = new DataTable();
            conn = new Connexion();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT IDDIFFICULTE, LABELDIFFICULTE FROM difficulte;", conn.Connection))
                {
                    conn.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtListeDifficulte.Load(reader);
                    conn = null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            DataRow workRow = dtListeDifficulte.NewRow();
            workRow[0] = -1;
            workRow[1] = "";
            dtListeDifficulte.Rows.InsertAt(workRow, 0);
            return dtListeDifficulte;
        }
        #endregion

        #region Récupération difficulté spécifique
        public string GetDiff(int idDiff)
        {
            DataTable temp = new DataTable();
            string diff = "";
            conn = new Connexion();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT LABELDIFFICULTE FROM difficulte WHERE IDDIFFICULTE="+idDiff+";", conn.Connection))
                {
                    conn.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    temp.Load(reader);
                    foreach(DataRow dr in temp.Rows)
                    {
                        diff = dr[0].ToString();
                    }
                    conn = null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return diff;
        }
        #endregion
    }
}
