using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;
using SLAM2_TP1_Pendu.Model;

namespace SLAM2_TP1_Pendu.Controllers
{
    public class Mots
    {
        private DataTable dtListeMots;
        private Connexion conn;
        private List<string> listMots;

        #region Récupération liste mots
        public DataTable GetListeMots()
        {
            dtListeMots = new DataTable();
            conn = new Connexion();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT IDMOTS, LABELMOTS AS Mots, mots.IDDIFFICULTE, LABELDIFFICULTE AS Difficulte FROM mots INNER JOIN difficulte diff ON mots.IDDIFFICULTE=diff.IDDIFFICULTE;", conn.Connection))
                {
                    conn.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtListeMots.Load(reader);
                    conn = null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dtListeMots;
        }
        #endregion

        #region Création liste mots selon diff choisie
        public List<string> GetListeMotsByDiff(int diff)
        {
            listMots = new List<string>();
            conn = new Connexion();
            dtListeMots = new DataTable();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT LABELMOTS FROM mots WHERE IDDIFFICULTE=" + diff + ";", conn.Connection))
                {
                    conn.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtListeMots.Load(reader);
                    foreach (DataRow dr in dtListeMots.Rows)
                    {
                        listMots.Add(dr[0].ToString());
                    }
                    conn = null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return listMots;
        }
        #endregion

        #region Récupération liste mots et difficulté
        public DataTable GetListeMotsdifficult(string extMot, int idDiff)
        {
            string rqtSql = "SELECT IDMOTS, LABELMOTS AS Mots, mots.IDDIFFICULTE, LABELDIFFICULTE AS Difficulte FROM mots INNER JOIN difficulte diff ON mots.IDDIFFICULTE=diff.IDDIFFICULTE ";
            if (extMot != "" || idDiff > -1)
            {
                rqtSql += "WHERE ";
                if (extMot != "")
                {
                    rqtSql += "LABELMOTS LIKE \"%" + extMot + "%\" ";
                }
                if (idDiff > -1)
                {
                    if (extMot != "")
                    {
                        rqtSql += "AND ";
                    }
                    rqtSql += " mots.IDDIFFICULTE = " + idDiff;
                }
                
            }
            rqtSql += " ;";

            dtListeMots = new DataTable();
            conn = new Connexion();
                try
                {
                    Connexion conn = new Connexion();
                    using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connection))
                    {
                        conn.Connection.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        dtListeMots.Load(reader);
                        conn = null;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
                return dtListeMots;
        }
        #endregion
    }
}
