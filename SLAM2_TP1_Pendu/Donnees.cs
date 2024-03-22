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
        private DataGridView dgv_Mots;
        private Mots dt_mot;
        public Donnees()
        {
            InitializeComponent();
            dt_mot = new Mots();
            dv = new DataView(dt_mot.GetListeMots());
            dgv_Mots.DataSource = dv;
            dgv_Mots.Columns["IDMOTS"].Visible = false;
            dgv_Mots.Columns["Mots"].Width = 190;

        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
