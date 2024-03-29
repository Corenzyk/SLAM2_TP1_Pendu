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
    public class Mots
    {
        private DataTable dtListeMots;
        private Connexion conn;

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
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dtListeMots;
        }

        public DataTable GetListeMotsDiff(string libDiff, int idDiff)
        {
            if (libDiff != "" && idDiff > 0)
            {
                string rqtSql = "SELECT IDMOTS, LABELMOTS AS Mots, mots.IDDIFFICULTE, LABELDIFFICULTE AS Difficulte FROM mots INNER JOIN difficulte diff ON mots.IDDIFFICULTE=diff.IDDIFFICULTE WHERE diff.IDDIFFICULTE = " + idDiff + " AND LABELDIFFICULTE = " + libDiff + ";";
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

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
                return dtListeMots;
            }
            else
            {
                dtListeMots = new DataTable();
                conn = new Connexion();
                try
                {
                    Connexion conn = new Connexion();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT IDMOTS, LABELMOTS AS Mots, mots.IDDIFFICULTE, LABELDIFFICULTE AS Difficulte FROM mots INNER JOIN difficulte diff ON mots.IDDIFFICULTE=diff.IDDIFFICULTE;", conn.Connection))
                    {
                        conn.Connection.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        dtListeMots.Load(reader);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
                return dtListeMots;
            }
        }
    }
}
