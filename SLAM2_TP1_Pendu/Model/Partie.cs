using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLAM2_TP1_Pendu.Model
{
    public class Partie
    {
        public Int32 nbEssais;
        public String motatrouver;
        public String motaafficher;
        public Timer timer;
        public Int32 tempsPartie;


        public void changerIMG(PictureBox pb_pendu)
        {
            switch (nbEssais)
            {
                case 0:
                    pb_pendu.Image = Properties.Resources.C1;
                    break;
                case 1:
                    pb_pendu.Image = Properties.Resources.C2;
                    break;
                case 2:
                    pb_pendu.Image = Properties.Resources.C3;
                    break;
                case 3:
                    pb_pendu.Image = Properties.Resources.C4;
                    break;
                case 4:
                    pb_pendu.Image = Properties.Resources.C5;
                    break;
                case 5:
                    pb_pendu.Image = Properties.Resources.C6;
                    break;
                case 6:
                    pb_pendu.Image = Properties.Resources.C7;
                    break;
                case 7:
                    pb_pendu.Image = Properties.Resources.C8;
                    break;
                case 8:
                    pb_pendu.Image = Properties.Resources.C9;
                    break;
                default:
                    pb_pendu.Image = Properties.Resources.C1;
                    break;
            }
        }

        public void verification(string lettretape, TextBox txt_afficher_mot)
        {
            char[] cArray = motatrouver.ToCharArray();
            char[] motaff = motaafficher.ToCharArray();
            motaafficher = "";
            bool erreur = false;

            for (int i = 0; i < cArray.Count(); i++)
            {
                if (cArray[i] == Convert.ToChar(lettretape))
                {
                    motaafficher += lettretape;
                    erreur = true;
                }
                else
                {
                    motaafficher += motaff[i];
                }
            }
            if (!erreur)
                nbEssais++;
            txt_afficher_mot.Text = motaafficher;
        }

        public void genererMotAfficher(string motatrouver)
        {
            string motaff = "";

            for (int i = 0; i < motatrouver.Count(); i++)
                motaff += "_";

            motaafficher = motaff;
        }

        public void choisirMotATrouver(List<String> listeATrouver)
        {
            Random aleatoire = new Random();
            int nbAleatoire = aleatoire.Next(listeATrouver.Count);
            motatrouver = listeATrouver[nbAleatoire].ToUpper();
        }

        public void victoire(Form formulaireJeuActif, TextBox txt_motAafficher, List<string> listeMotaTrouver, PictureBox pbpendu, Timer timer)
        {
            DialogResult msg;
            if (nbEssais >= 8)
            {
                timer.Stop();
                msg = MessageBox.Show("Vous avez perdu !! \r\nVous deviez trouver le mot: " + motatrouver + "\r\nVoulez vous faire une autre partie ??", "You loose", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (msg == DialogResult.Yes)
                {
                    remiseAZero(formulaireJeuActif, txt_motAafficher, listeMotaTrouver, pbpendu, timer);
                }
                else if (msg == DialogResult.No)
                {
                    Form1 Accueil = new Form1();
                    Accueil.Show();
                    formulaireJeuActif.Hide();
                }
            }
            else if (motatrouver == motaafficher)
            {
                timer.Stop(); 
                msg = MessageBox.Show("Vous avez gagné !! \r\nVous avez trouver en : " +timer.ToString()+" sec! \r\nVous avez trouvé le mot: " + motatrouver + "\r\nVoulez vous faire une autre partie ??", "You win", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (msg == DialogResult.Yes)
                {
                    remiseAZero(formulaireJeuActif, txt_motAafficher, listeMotaTrouver, pbpendu, timer);
                }
                else if (msg == DialogResult.No)
                {
                    Form1 Accueil = new Form1();
                    Accueil.Show();
                    formulaireJeuActif.Hide();
                }
            }
        }

        public void remiseAZero(Form formulaireJeuActif, TextBox txt_motAafficher, List<String> listeMotaTrouver, PictureBox pb_pendu, Timer timer)
        {
            motaafficher = "";
            motatrouver = "";
            timer.Start();
            choisirMotATrouver(listeMotaTrouver);
            genererMotAfficher(motatrouver);
            txt_motAafficher.Text = motaafficher;

            foreach (Control c in formulaireJeuActif.Controls)
            {
                if (c.GetType() == typeof(Button))
                    c.Enabled = true;
            }
            nbEssais = 0;
            changerIMG(pb_pendu);
        }

        public void gestionTimer(TextBox txt_timer)
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, e) => Timer_Tick(sender, e, txt_timer);

            timer.Start();
        }

        public void Timer_Tick(object sender, EventArgs e, TextBox txt_timer)
        {
            tempsPartie++;
            txt_timer.Text = tempsPartie.ToString() + " sec";
        }
    }
}
