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
        List<Candidato> listaCand;
        public f7_EvCandidatos()
        {
            InitializeComponent();
        }
        public f7_EvCandidatos(Evaluacion ev, List<Candidato> lc)
        {
            listaCand = lc;
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
            try
            {
                GestorDeCuestionario clogCu = new GestorDeCuestionario();
                DialogResult dialogResult = MessageBox.Show("¿Desea exportar los datos de los candidatos con sus claves a un archivo Excel?.", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.No)
                {
                    clogCu.finalizar(evaluacion, listaCuest, listaCand);
                    Owner.Show();
                    this.Close();
                }
                else
                {
                    FolderBrowserDialog fbd = new FolderBrowserDialog();
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        GestorExcel clogExc = new GestorExcel();
                        clogExc.exportarAExcel(evaluacion, dgvCandidatos, fbd);
                        clogCu.finalizar(evaluacion, listaCuest, listaCand);
                        Owner.Show();
                        this.Close();
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(("Se ha producido un error:\n" + ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            listaCuest = clogCu.generarCuestionarios(evaluacion, listaCand);
            dgvCandidatos.DataSource = listaCand.Select(ca => new { ca.apellido, ca.nombre, ca.tipo_documento, ca.nro_documento, ca.contraseña }).ToList();
            dgvCandidatos.Columns[0].HeaderText = "Apellido";
            dgvCandidatos.Columns[1].HeaderText = "Nombre";
            dgvCandidatos.Columns[2].HeaderText = "Tipo de documento";
            dgvCandidatos.Columns[3].HeaderText = "Nro de documento";
            dgvCandidatos.Columns[4].HeaderText = "Clave de ingreso";
        }
    }
}
