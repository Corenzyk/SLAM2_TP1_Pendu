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
        public Jeu()
        {
            InitializeComponent();
            P = new Partie();
            init();
        }

        private void init()
        {
            List<string> listeMotATrouver = new List<string> { "Francophile", "Chlorophylle", "Conspirateur", "Qualification", "Attraction", "Cornemuse", "Tourisme", "Diapason", "Brouhaha" };
            P.choisirMotATrouver(listeMotATrouver);
            P.genererMotAfficher(P.motatrouver);
            txt_afficher_mot.Text = P.motaafficher;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            P.verification(((Button)sender).Text.ToString(), txt_afficher_mot);
            P.changerIMG(pb_pendu);
        }

    }
}
