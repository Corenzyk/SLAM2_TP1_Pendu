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

namespace SLAM2_TP1_Pendu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cb_diff.Items.Add("Facile");
            cb_diff.Items.Add("Moyen");
            cb_diff.Items.Add("Difficile");
            cb_diff.Items.Add("Enfer");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result1 = "";
            string result2 = "";
            if (txt_prenom.Text != "")
                result1 += txt_prenom.Text + " ";
            else
                MessageBox.Show("Aucun prénom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (txt_nom.Text != "")
                result1 += txt_nom.Text;
            else
                MessageBox.Show("Aucun nom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (cb_diff.SelectedIndex > -1)
                result2 = "La difficultés sélectionnée est:" + cb_diff.SelectedItem.ToString();
            else
                MessageBox.Show("Aucun difficulté n'est choisie", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //Jeu.txt_afficher_prenom_nom.Text = result1;
            //Jeu.txt_afficher_diff.Text = result2;
            Jeu J = new Jeu();
            J.Show();
            this.Hide();
        }

        private void cb_diff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_diff.SelectedItem.ToString() == "Enfer"){
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
    }
}
