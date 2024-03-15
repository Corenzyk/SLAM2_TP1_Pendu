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

namespace SLAM2_TP1_Pendu
{
    public partial class Jeu : Form
    {
        Partie P;
        List<string> listeMotATrouver;

        private void Init()
        {
            P = new Partie();
            InitializeComponent();
            listeMotATrouver = new List<string> { "Francophile", "Chlorophylle", "Conspirateur", "Qualification", "Attraction", "Cornemuse", "Tourisme", "Diapason", "Brouhaha" };
            P.choisirMotATrouver(listeMotATrouver);
            P.genererMotAfficher(P.motatrouver);
            txt_afficher_mot.Text = P.motaafficher;
            P.gestionTimer(txt_timer, progB_coup, pb_pendu);
        }

        public Jeu()
        {
            Init();
        }

        public Jeu(string nomPrenomJoueur, string difficultePartie)
        {
            Init();
            txt_afficher_prenom_nom.Text = nomPrenomJoueur;
            txt_afficher_diff.Text = difficultePartie;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            progB_coup.Value = 0;
            P.dureeCoup = 0;
            P.verification(((Button)sender).Text.ToString(), txt_afficher_mot);
            P.changerIMG(pb_pendu);
            ((Button)sender).Enabled = false;
            P.victoire(this, txt_afficher_mot, listeMotATrouver, pb_pendu);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
