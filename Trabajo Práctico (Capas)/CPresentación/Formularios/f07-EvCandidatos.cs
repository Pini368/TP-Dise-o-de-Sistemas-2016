using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEntidades;
using CLogica.Gestores;

namespace Trabajo_práctico
{
    public partial class f7_EvCandidatos : Form
    {
        Evaluacion evaluacion;
        List<Cuestionario> listaCuest;
        public f7_EvCandidatos()
        {
            InitializeComponent();
        }
        public f7_EvCandidatos(Evaluacion ev)
        {
            evaluacion = ev;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GestorDeCuestionario clogCu = new GestorDeCuestionario();
            clogCu.finalizar(evaluacion,listaCuest); 
            Owner.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void f7_EvCandidatos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void f7_EvCandidatos_Load(object sender, EventArgs e)
        {
            GestorDeCuestionario clogCu = new GestorDeCuestionario();
            listaCuest = clogCu.generarCuestionarios(evaluacion);
            dgvCandidatos.DataSource = evaluacion.Candidato.Select(ca => new { ca.apellido,ca.nombre,ca.tipo_documento,ca.nro_documento,ca.contraseña }).ToList();
            dgvCandidatos.Columns[0].HeaderText = "Apellido";
            dgvCandidatos.Columns[1].HeaderText = "Nombre";
            dgvCandidatos.Columns[2].HeaderText = "Tipo de documento";
            dgvCandidatos.Columns[3].HeaderText = "Nro de documento";
            dgvCandidatos.Columns[4].HeaderText = "Clave de ingreso";
        }

        private void dgvCandidatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
