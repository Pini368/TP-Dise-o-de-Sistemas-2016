using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_práctico.Formularios
{
    public partial class f4_MainConsultor : Form
    {
        public f4_MainConsultor()
        {
            InitializeComponent();
        }

        private void f4_main_consultor_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            f5_AdminCandidatos AdminCandidatos1 = new f5_AdminCandidatos();
            AdminCandidatos1.Show(this);
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            f8_GestionarPreguntas GestionarPreguntas = new f8_GestionarPreguntas();
            GestionarPreguntas.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f11_GestionarPuestos gestionarPuestos = new f11_GestionarPuestos();
            gestionarPuestos.Show(this);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            f16_GenResultados res = new f16_GenResultados();
            res.Show(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            f14_GestionarOpcionesRespuesta gor = new f14_GestionarOpcionesRespuesta();
            gor.Show(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            f11_GestionarPuestos gp = new f11_GestionarPuestos();
            gp.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
