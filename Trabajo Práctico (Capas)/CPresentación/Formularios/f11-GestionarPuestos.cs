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
using System.Linq.Expressions;

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
            try
            {
                dgvPuestos.DataSource = clogPuesto.getPuestos().Select(pu => new { pu.codigo_puesto, pu.nombre, pu.empresa }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Se ha producido un error:\n" + ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            try
            {
                this.Hide();
                GestorDePuestos clogPuestos = new GestorDePuestos();
                Puesto puestoSeleccionado = new Puesto();
                int codigoPuesto = (int)dgvPuestos.Rows[dgvPuestos.SelectedRows[0].Index].Cells[0].Value;
                string nombrePuesto = dgvPuestos.Rows[dgvPuestos.SelectedRows[0].Index].Cells[1].Value.ToString();
                string empresaPuesto = dgvPuestos.Rows[dgvPuestos.SelectedRows[0].Index].Cells[2].Value.ToString();
                puestoSeleccionado = clogPuestos.getPuestos(codigoPuesto, nombrePuesto, empresaPuesto).First();
                Formularios.f13_ModificarPuesto altaPuesto = new Formularios.f13_ModificarPuesto(puestoSeleccionado);
                altaPuesto.Show(this);
            }
            catch(Exception ex)
            {
                MessageBox.Show(("Se ha producido un error:\n" + ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                int codigoPuesto;
                if (tbCodigo.Text == "")
                {
                    codigoPuesto = -1;
                }
                else
                {
                    codigoPuesto = Int32.Parse(tbCodigo.Text);
                }
                string nombrePuesto = tbNombre.Text;
                string empresaPuesto = tbEmpresa.Text;
                GestorDePuestos clogPuesto = new GestorDePuestos();
                List<Puesto> lp = clogPuesto.getPuestos(codigoPuesto, nombrePuesto, empresaPuesto);
                dgvPuestos.DataSource = lp.Select(pu => new { pu.codigo_puesto, pu.nombre, pu.empresa }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Se ha producido un error:\n" + ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            GestorDePuestos clogPuestos = new GestorDePuestos();
            Puesto puestoSeleccionado = new Puesto();
            try
            {
                int codigoPuesto = (int)dgvPuestos.Rows[dgvPuestos.SelectedRows[0].Index].Cells[0].Value;
                string nombrePuesto = dgvPuestos.Rows[dgvPuestos.SelectedRows[0].Index].Cells[1].Value.ToString();
                string empresaPuesto = dgvPuestos.Rows[dgvPuestos.SelectedRows[0].Index].Cells[2].Value.ToString();
                puestoSeleccionado = clogPuestos.getPuestos(codigoPuesto, nombrePuesto, empresaPuesto).First();
                clogPuestos.baja(puestoSeleccionado);
                MessageBox.Show(("Los datos del puesto " + puestoSeleccionado.nombre + " han sido eliminado del sistema."), "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Se ha producido un error:\n" + ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void f11_GestionarPuestos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
