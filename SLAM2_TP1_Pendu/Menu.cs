using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLAM2_TP1_Pendu.Model;

namespace SLAM2_TP1_Pendu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void démarrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire(pan_menu);
            SF.openChildForm(new Form1());
        }

        private void donnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire(pan_menu);
            SF.openChildForm(new Donnees());
        }
    }
}
