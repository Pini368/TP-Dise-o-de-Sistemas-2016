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

namespace Trabajo_práctico.Formularios
{
    public partial class f13_ModificarPuesto : Form
    {
        List<Competencia> competencias = new List<Competencia>();
        List<Puntaje_Requerido> listaCarInic = new List<Puntaje_Requerido>();
        private Puesto puestoActual;

        public f13_ModificarPuesto()
        {
            InitializeComponent();
        }
        public f13_ModificarPuesto(Puesto p)
        {
            puestoActual = p;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void f13_ModificarPuesto_Load(object sender, EventArgs e)
        {
            tbNombre.CharacterCasing = CharacterCasing.Upper;
            tbDescripcion.CharacterCasing = CharacterCasing.Upper;
            tbEmpresa.CharacterCasing = CharacterCasing.Upper;
            dgvPuntajesRequeridos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbCodigo.Text = puestoActual.codigo_puesto.ToString();
            tbNombre.Text = puestoActual.nombre;
            tbEmpresa.Text = puestoActual.empresa;
            tbDescripcion.Text = puestoActual.descripcion;
            GestorDeCompetencia clogC = new GestorDeCompetencia();
            GestorDePuestos clogP = new GestorDePuestos();
            try
            {
                competencias = clogC.getCompetencias();
                List<string> listaNom = new List<string>();
                foreach (var comp in competencias)
                {
                    listaNom.Add(comp.nombre);
                }
                cmbCompetencias.DataSource = listaNom;
                dgvPuntajesRequeridos.DataSource = puestoActual.Puntaje_Requerido.Select(pr => new { pr.Competencia.nombre, pr.ponderacion }).ToList();
                Competencia compSeleccionada = puestoActual.Puntaje_Requerido.Where(pr => pr.Competencia.nombre == dgvPuntajesRequeridos.SelectedRows[dgvPuntajesRequeridos.SelectedRows[0].Index].Cells[0].Value.ToString()).Select(pr => pr.Competencia).First();
                clogP.contieneCuestionarios(puestoActual);
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Se ha producido un error:\n" + ex.ToString()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
