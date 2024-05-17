using SLAM2_TP1_Pendu.Model;
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

namespace SLAM2_TP1_Pendu
{
    public partial class Jeu : Form
    {
        Partie P;
        Mots M;
        Difficulte D;
        List<string> listeMotATrouver;

        #region Constructeur jeu
        public Jeu(string nomPrenomJoueur, int difficultePartie)
        {
            P = new Partie();
            M = new Mots();
            D = new Difficulte();
            InitializeComponent();
            txt_afficher_prenom_nom.Text = nomPrenomJoueur;
            txt_afficher_diff.Text = D.GetDiff(difficultePartie);
            listeMotATrouver = M.GetListeMotsByDiff(difficultePartie);
            P.choisirMotATrouver(listeMotATrouver);
            P.genererMotAfficher(P.motatrouver);
            txt_afficher_mot.Text = P.motaafficher;
            P.gestionTimer(txt_timer, progB_coup, this, pb_pendu, txt_afficher_mot, listeMotATrouver);
        }
        #endregion

        #region Bouton lettre
        private void btn_Click(object sender, EventArgs e)
        {
            progB_coup.Value = 0;
            P.dureeCoup = 0;
            P.verification(((Button)sender).Text.ToString(), txt_afficher_mot);
            P.changerIMG(pb_pendu);
            ((Button)sender).Enabled = false;
            P.victoire(this, txt_afficher_mot, listeMotATrouver, pb_pendu);
        }
        #endregion

        #region Fermeture form jeu
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
