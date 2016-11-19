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
    public partial class f3_IngresoConsultor : Form
    {
        public f3_IngresoConsultor()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void cerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iniciarSesiónComoConsultorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            f3_IngresoConsultor ingresoConsultor1 = new f3_IngresoConsultor();
            ingresoConsultor1.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formularios.f4_MainConsultor MainConsultor1 = new Formularios.f4_MainConsultor();
            MainConsultor1.Show(Owner);
        }

        private void ingresoConsultor_Load(object sender, EventArgs e)
        {

        }

        private void f3_IngresoConsultor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
