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
        public SousFormulaire SF;

        public Menu()
        {
            InitializeComponent();
            SF = new SousFormulaire(pan_menu);
        }

        private void démarrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SF.openChildForm(new Form1());
        }

        private void donnéesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SF.openChildForm(new Donnees());
        }
    }
}
