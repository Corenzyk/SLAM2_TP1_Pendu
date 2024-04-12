using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLAM2_TP1_Pendu.Controllers;
using SLAM2_TP1_Pendu.Model;

namespace SLAM2_TP1_Pendu
{
    public partial class Form1 : Form
    {
        private Difficulte dt_difficulte;

        public Form1()
        {
            InitializeComponent();
            dt_difficulte = new Difficulte();
            cb_diff.DataSource = dt_difficulte.GetListeDifficulte();
            cb_diff.DisplayMember = "LABELDIFFICULTE"; //nom de l’alias SQL
            cb_diff.ValueMember = "IDDIFFICULTE"; //nom de l’alias SQL
        }
        
        public void button1_Click(object sender, EventArgs e)
        {
            bool erreur = true;
            if (txt_prenom.Text == "")
            {
                MessageBox.Show("Aucun prénom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                erreur = false;
            }
            if (txt_nom.Text == "")
            {
                MessageBox.Show("Aucun nom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                erreur = false;
            }
            if (cb_diff.SelectedValue.ToString() == "-1")
            {
                MessageBox.Show("Aucun difficulté n'est choisie", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                erreur = false;
            }
            if (erreur==true)
            {
                SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["Menu"] as Menu).pan_menu);
                SF.openChildForm(new Jeu(txt_prenom.Text + " " + txt_nom.Text, dt_difficulte.GetDiff(Convert.ToInt32(cb_diff.SelectedValue.ToString()))));
                this.Hide();
            }
        }
        
        public void cb_diff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_diff.SelectedValue.ToString() == "4") { 
                this.BackColor = Color.Red;
                lbl_nom.Font = new Font(lbl_nom.Font, FontStyle.Bold);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Bold);
                lbl_diff.Font = new Font(lbl_diff.Font, FontStyle.Bold);
            }
            else{
                this.BackColor = Color.FromArgb(153, 180, 209);
                lbl_nom.Font = new Font(lbl_nom.Font, FontStyle.Regular);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Regular);
                lbl_diff.Font = new Font(lbl_diff.Font, FontStyle.Regular);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
