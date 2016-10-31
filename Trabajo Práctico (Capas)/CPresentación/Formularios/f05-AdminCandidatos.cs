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
    public partial class f5_AdminCandidatos : Form
    {
        public f5_AdminCandidatos()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            f6_EvCandidatos ev_candidatos1 = new f6_EvCandidatos();
            ev_candidatos1.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel_EC.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel_EC.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            panel_EC.Size = new Size(551, 410);
            panel_EC.Visible = true;
        }

        private void cerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel_EC.Size = new Size(551, 410);
            panel_EC.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel_EC.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel_EC.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            f6_EvCandidatos ev_candidatos1 = new f6_EvCandidatos();
            ev_candidatos1.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
    }
}
