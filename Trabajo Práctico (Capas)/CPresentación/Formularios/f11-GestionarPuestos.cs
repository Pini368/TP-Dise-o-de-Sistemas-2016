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
    public partial class f11_GestionarPuestos : Form
    {
        public f11_GestionarPuestos()
        {
            InitializeComponent();
        }

        private void gestionarCandidatos_Load(object sender, EventArgs e)
        {
            tbNombre.CharacterCasing = CharacterCasing.Upper;
            tbEmpresa.CharacterCasing = CharacterCasing.Upper;
            GestorDePuestos clogPuesto = new GestorDePuestos();
            List<Puesto> lp = clogPuesto.getPuestos();
            dgvPuestos.DataSource = lp.Select(pu => new { pu.codigo_puesto, pu.nombre, pu.empresa }).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            f12_AltaPuesto altaPuesto = new f12_AltaPuesto();
            altaPuesto.Show(this);
        }

        private void button8_Click(object sender, EventArgs e)
        {
                this.Hide();
                GestorDePuestos clogPuestos = new GestorDePuestos();
                Puesto puestoSeleccionado = new Puesto();
                puestoSeleccionado.codigo_puesto = (int)dgvPuestos.Rows[dgvPuestos.SelectedRows[0].Index].Cells[0].Value;
                puestoSeleccionado.nombre = dgvPuestos.Rows[dgvPuestos.SelectedRows[0].Index].Cells[1].Value.ToString();
                puestoSeleccionado.empresa = dgvPuestos.Rows[dgvPuestos.SelectedRows[0].Index].Cells[2].Value.ToString();
                puestoSeleccionado = clogPuestos.getPuestos(puestoSeleccionado).First();
                Formularios.f13_ModificarPuesto altaPuesto = new Formularios.f13_ModificarPuesto(puestoSeleccionado);
                altaPuesto.Show(this);
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try {
                Puesto pues = new Puesto();
                if(tbCodigo.Text == "")
                {
                    pues.codigo_puesto = -1;
                }
                else
                {
                    pues.codigo_puesto = Int32.Parse(tbCodigo.Text);
                }
                pues.nombre = tbNombre.Text;
                pues.empresa = tbEmpresa.Text;
                GestorDePuestos clogPuesto = new GestorDePuestos();
                List<Puesto> lp = clogPuesto.getPuestos(pues);
                dgvPuestos.DataSource = lp.Select(pu => new { pu.codigo_puesto, pu.nombre, pu.empresa }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Se ha producido un error:\n" + ex.ToString()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            GestorDePuestos clogPuestos = new GestorDePuestos();
            Puesto puestoSeleccionado = new Puesto();
            try
            {
                puestoSeleccionado.codigo_puesto = (int)dgvPuestos.Rows[dgvPuestos.SelectedRows[0].Index].Cells[0].Value;
                puestoSeleccionado.nombre = dgvPuestos.Rows[dgvPuestos.SelectedRows[0].Index].Cells[1].Value.ToString();
                puestoSeleccionado.empresa = dgvPuestos.Rows[dgvPuestos.SelectedRows[0].Index].Cells[2].Value.ToString();
                puestoSeleccionado = clogPuestos.getPuestos(puestoSeleccionado).First();
<<<<<<< HEAD
              //  clogPuestos.baja(puestoSeleccionado);
=======
                clogPuestos.baja(puestoSeleccionado);
                MessageBox.Show(("Los datos del puesto " + puestoSeleccionado.nombre + " han sido eliminado del sistema."), "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
>>>>>>> origin/master
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Se ha producido un error:\n" + ex.ToString()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
    }
}
