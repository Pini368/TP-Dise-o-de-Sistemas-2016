using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLogica.Gestores;
using CEntidades;

namespace Trabajo_práctico
{
    public partial class f6_EvCandidatos : Form
    {
        List<Candidato> listaCand;
        List<Puesto> listaPuestos;
        bool cerrar = false;
        public f6_EvCandidatos()
        {
            InitializeComponent();
        }
        public f6_EvCandidatos(List<Candidato> lcand)
        {
            listaCand = lcand;
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
            if (dgvPuntajesRequeridos.Rows.Count > 0)
            {
                cerrar = true;
                this.Hide();
                Evaluacion ev = new Evaluacion();
                //ev.Candidato = listaCand;
                Puesto puestoSeleccionado = listaPuestos.First(pu => pu.nombre.Equals(dgvPuestos.Rows[dgvPuestos.SelectedRows[0].Index].Cells[0].Value) && pu.empresa.Equals(dgvPuestos.Rows[dgvPuestos.SelectedRows[0].Index].Cells[1].Value));
                ev.id_puesto = puestoSeleccionado.id_puesto;
                GestorDeEvaluacion clogEv = new GestorDeEvaluacion();
                f7_EvCandidatos ev_candidatos2 = new f7_EvCandidatos(ev, listaCand);
                ev_candidatos2.Show(this);
            }
            else
            {
                MessageBox.Show("Usted no ha seleccionado ningún puesto a evaluar.\nPara seleccionar accione doble click sobre el puesto deseado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void f6_EvCandidatos_Load(object sender, EventArgs e)
        {
            GestorDePuestos clogPuesto = new GestorDePuestos();
            try
            {
                listaPuestos = clogPuesto.getPuestos();
                dgvPuestos.DataSource = listaPuestos.Select(pu => new { pu.nombre, pu.empresa }).ToList();
                dgvPuestos.Columns[0].HeaderText = "Puesto";
                dgvPuestos.Columns[1].HeaderText = "Empresa";
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Se ha producido un error:\n" + ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void llenarDataGrid(Puesto pues, DataGridView dgv)
        {
            foreach(Puntaje_Requerido pr in pues.Puntaje_Requerido)
            {
                dgv.Rows.Add(pr.Competencia.nombre, pr.ponderacion);
            }
        }


        private void dgvPuestos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvPuntajesRequeridos.Rows.Clear();
            Puesto puestoSeleccionado = listaPuestos.First(pu => pu.nombre.Equals(dgvPuestos.Rows[dgvPuestos.SelectedRows[0].Index].Cells[0].Value) && pu.empresa.Equals(dgvPuestos.Rows[dgvPuestos.SelectedRows[0].Index].Cells[1].Value));
            GestorDePuestos clogPues = new GestorDePuestos();
            List<Competencia> compNoEvaluables = clogPues.getCompetenciasNoEvaluables(puestoSeleccionado);
            if (compNoEvaluables.Count() == 0)
            {
                llenarDataGrid(puestoSeleccionado, dgvPuntajesRequeridos);
            }
            else
            {
                string mensaje = "Las siguiente competencias no pueden ser evaluadas:\n";
                foreach (Competencia comp in compNoEvaluables)
                {
                    mensaje += comp.nombre + "\n";
                }
                mensaje = mensaje.Remove(mensaje.LastIndexOf('\n'));
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvPuntajesRequeridos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void f6_EvCandidatos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Refresh();
            Owner.Show();
        }

        private void f6_EvCandidatos_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible && cerrar)
            {
                this.Close();
            }
        }
    }
}
