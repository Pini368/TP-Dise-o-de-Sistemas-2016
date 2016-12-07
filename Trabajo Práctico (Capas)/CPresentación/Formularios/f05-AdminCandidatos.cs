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
    public partial class f5_AdminCandidatos : Form
    {
        List<Candidato> listaCand = new List<Candidato>();

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

        private void llenarDataGrid(string apellido, string nombre, string nroCandidato, DataGridView dgv)
        {
            GestorDeCandidato clogCand = new GestorDeCandidato();
            List<Candidato> lc = clogCand.getCandidatos(apellido, nombre, nroCandidato);
            foreach (Candidato cand in lc)
            {
                dgv.Rows.Add(cand.apellido, cand.nombre, cand.nroCandidato);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel_EC.Size = new Size(551, 410);
            panel_EC.Visible = true;
            llenarDataGrid("", "", "", dgvCandiadtos);
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

        private void f5_AdminCandidatos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void f5_AdminCandidatos_Load(object sender, EventArgs e)
        {

        }

        private void tbApellido_TextChanged(object sender, EventArgs e)
        {
            GestorDeCandidato clogCand = new GestorDeCandidato();
            llenarDataGrid(tbApellido.Text, tbNombre.Text, tbNroCandidato.Text, dgvCandidatosAEvaluar);
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            GestorDeCandidato clogCand = new GestorDeCandidato();
            llenarDataGrid(tbApellido.Text, tbNombre.Text, tbNroCandidato.Text, dgvCandidatosAEvaluar);
        }

        private void tbNroCandidato_TextChanged(object sender, EventArgs e)
        {
            GestorDeCandidato clogCand = new GestorDeCandidato();
            llenarDataGrid(tbApellido.Text, tbNombre.Text, tbNroCandidato.Text, dgvCandidatosAEvaluar);
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            string apellido = dgvCandiadtos.Rows[dgvCandiadtos.SelectedRows[0].Index].Cells[0].Value.ToString();
            string nombre = dgvCandiadtos.Rows[dgvCandiadtos.SelectedRows[0].Index].Cells[1].Value.ToString();
            int nroCand = (int)dgvCandiadtos.Rows[dgvCandiadtos.SelectedRows[0].Index].Cells[2].Value;
            bool contiene = false;
            foreach(Candidato can in listaCand)
            {
                if (can.nroCandidato == nroCand)
                {
                    contiene = true;
                    break;
                }
            }
            if (!contiene)
            {
                GestorDeCandidato clogCand = new GestorDeCandidato();
                listaCand.Add(clogCand.getCandidatos(nroCand));
                dgvCandidatosAEvaluar.Rows.Add(apellido, nombre, nroCand);
            }
            else
            {
                MessageBox.Show("Error, ese candidato ya está cargado en la lista de candidatos a evaluar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            if (dgvCandidatosAEvaluar.SelectedRows.Count > 0)
            {
                string apellido = dgvCandidatosAEvaluar.Rows[dgvCandidatosAEvaluar.SelectedRows[0].Index].Cells[0].Value.ToString();
                string nombre = dgvCandidatosAEvaluar.Rows[dgvCandidatosAEvaluar.SelectedRows[0].Index].Cells[1].Value.ToString();
                int nroCand = (int)dgvCandidatosAEvaluar.Rows[dgvCandidatosAEvaluar.SelectedRows[0].Index].Cells[2].Value;
                int i = 0;
                foreach (Candidato cand in listaCand)
                {
                    if (cand.apellido.Equals(apellido) && cand.nombre.Equals(nombre) && cand.nroCandidato == nroCand)
                    {
                        break;
                    }
                    i++;
                }
                listaCand.RemoveAt(i);
                dgvCandidatosAEvaluar.Rows.RemoveAt(dgvCandidatosAEvaluar.SelectedRows[0].Index);
            }
        }
    }
}
