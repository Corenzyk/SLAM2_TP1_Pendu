using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLAM2_TP1_Pendu.Controllers;
using SLAM2_TP1_Pendu.Model;

namespace SLAM2_TP1_Pendu
{
    public partial class Donnees : Form
    {
        private DataView dv;
        
        private Mots dt_mot;
        private Difficulte dt_difficulte;

        public Donnees()
        {
            InitializeComponent();
            dt_mot = new Mots();
            dv = new DataView(dt_mot.GetListeMots());
            dt_difficulte = new Difficulte();
            dgv_Mots.DataSource = dv;
            dgv_Mots.Columns["IDMOTS"].Visible = false;
            dgv_Mots.Columns["IDDIFFICULTE"].Visible = false;
            dgv_Mots.Columns["Mots"].Width = 200;
            cb_RechercheDiff.DataSource = dt_difficulte.GetListeDifficulte();
            cb_RechercheDiff.DisplayMember = "LABELDIFFICULTE"; //nom de l’alias SQL
            cb_RechercheDiff.ValueMember = "IDDIFFICULTE"; //nom de l’alias SQL

        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_RechercheDiff_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void txt_RechercheMots_TextChanged(object sender, EventArgs e)
        {
            refresh(txt_RechercheMots.Text,cb_RechercheDiff.SelectedValue.ToString());
            
        }

        private void cb_RechercheDiff_SelectionChangeCommitted(object sender, EventArgs e)
        {
            refresh(txt_RechercheMots.Text, cb_RechercheDiff.SelectedValue.ToString());

        }

        public void refresh(string mot, string diff)
        {
            dv = new DataView(dt_mot.GetListeMotsdifficult(mot, Convert.ToInt32(diff)));
            dt_difficulte = new Difficulte();
            dgv_Mots.DataSource = dv;
            dgv_Mots.Columns["IDMOTS"].Visible = false;
            dgv_Mots.Columns["IDDIFFICULTE"].Visible = false;
            dgv_Mots.Columns["Mots"].Width = 200;
            


        }

    }
}
