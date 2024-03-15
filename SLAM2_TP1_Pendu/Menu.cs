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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public Form activeForm = null;

        public void openChildForm(Form formEnfant)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            pan_menu.Controls.Add(formEnfant);
            pan_menu.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();
        }

        private void démarrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Form1());
        }
    }
}
