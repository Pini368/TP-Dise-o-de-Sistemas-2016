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
    public partial class f2_RealizarCuestionario : Form
    {
        public f2_RealizarCuestionario()
        {
            InitializeComponent();
        }

        private void iniciarSesiónComoConsultorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            f3_IngresoConsultor ingresoConsultor1 = new f3_IngresoConsultor();
            ingresoConsultor1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            f1_Main main = new f1_Main();
            main.Show();
        }

        private void cerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f21_CuestionarioInstrucciones cui = new f21_CuestionarioInstrucciones();
            cui.Show(this);
        }

        private void f2_RealizarCuestionario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
