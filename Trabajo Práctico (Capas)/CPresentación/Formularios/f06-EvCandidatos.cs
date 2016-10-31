using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_práctico
{
    public partial class f6_EvCandidatos : Form
    {
        public f6_EvCandidatos()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            f7_EvCandidatos ev_candidatos2 = new f7_EvCandidatos();
            ev_candidatos2.Show(Owner);
        }

        private void cerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            f7_EvCandidatos ev_candidatos2 = new f7_EvCandidatos();
            ev_candidatos2.Show(Owner);
        }
    }
}
