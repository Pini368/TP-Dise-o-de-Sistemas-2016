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
        
        List<Puntaje_Requerido> listaCar = new List<Puntaje_Requerido>();
        List<string> excluidos = new List<string>();

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

        private void limpiarCampos()
        {
            tbCodigo.Text = "";
            tbNombre.Text = "";
            tbDescripcion.Text = "";
            tbEmpresa.Text = "";
            tbPonderacion.Text = "";
            dgvPuntajesRequeridos.Rows.Clear();
            excluidos.Clear();
            listaCar.Clear();
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
                listaCar = puestoActual.Puntaje_Requerido.ToList();
                List<string> listaNom = new List<string>();
                foreach (var comp in competencias)
                {
                    listaNom.Add(comp.nombre);
                }
                cmbCompetencias.DataSource = listaNom;
                dgvPuntajesRequeridos.DataSource = puestoActual.Puntaje_Requerido.Select(pr => new { pr.Competencia.nombre, pr.ponderacion }).ToList();
                Competencia compSeleccionada = puestoActual.Puntaje_Requerido.Where(pr => pr.Competencia.nombre == dgvPuntajesRequeridos.SelectedRows[dgvPuntajesRequeridos.SelectedRows[0].Index].Cells[0].Value.ToString()).Select(pr => pr.Competencia).First();
                /*if (clogP.contieneCuestionarios(puestoActual))
                {
                    MessageBox.Show(("Ya existen cuestionarios generados para el puesto :\n" + ex.ToString()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
                ;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Se ha producido un error:\n" + ex.ToString()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void f13_ModificarPuesto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            /*List<Competencia> competencias1 = new List<Competencia>();
            foreach (var item in competencias)
            {
                if (item.nombre == cmbCompetencias.Text)
                {
                    competencias1.Add(item);
                }
            }
            if (competencias1.Count == 1)
            {
                try
                {
                    if (!excluidos.Contains(cmbCompetencias.Text))
                    {
                        try
                        {
                            Puntaje_Requerido car = new Puntaje_Requerido(competencias1[0], Int32.Parse(tbPonderacion.Text));
                            if (car.ponderacion > 0 && car.ponderacion <= 10)
                            {
                                listaCar.Add(car);
                                dgvPuntajesRequeridos.Rows.Add(cmbCompetencias.Text, tbPonderacion.Text);
                                excluidos.Add(cmbCompetencias.Text);
                            }
                            else
                            {
                                string errorString = "El campo ponderación debe ser un número entre 0 y 10.";
                                MessageBox.Show(errorString, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch (Exception ex)
                        {
                            string errorString = "El campo ponderación debe ser un número o estar completo.";
                            MessageBox.Show(errorString, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error, usted ya ha cargado esa competencia.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(("Se ha producido un error:\n" + ex.ToString()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error, no existe o existe más de una competencia con ese nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }

        private void cmbCompetencias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbPonderacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Int32.Parse(tbCodigo.Text);
                if (tbNombre.Text != "" && tbDescripcion.Text != "" && tbEmpresa.Text != "")
                {
                    Puesto puesto = new Puesto(codigo, tbNombre.Text, tbDescripcion.Text, tbEmpresa.Text, listaCar);
                    GestorDePuestos clog = new GestorDePuestos();
                    clog.modificar(puesto);

                    DialogResult dialogResult = MessageBox.Show("El puesto " + tbNombre.Text + " se ha modificado correctamente ¿Desea modificar otro ?.", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    limpiarCampos();
                    if (dialogResult == DialogResult.No)
                    {
                        Owner.Show();
                        this.Close();
                    }
                }
                else
                {
                    string errorString = "";
                    if (tbNombre.Text == "")
                    {
                        errorString += "No puede dejar el campo nombre vacío.\n";
                    }
                    if (tbDescripcion.Text == "")
                    {
                        errorString += "No puede dejar el campo descripción vacío.\n";
                    }
                    if (tbEmpresa.Text == "")
                    {
                        errorString += "No puede dejar el campo empresa vacío.\n";
                    }
                    if (listaCar.Count == 0)
                    {
                        errorString += "Debe cargar al menos una característica.\n";
                    }
                    errorString.Remove(errorString.LastIndexOf('\n'));
                    MessageBox.Show(errorString, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException exfm)
            {
                string errorString = "El campo código debe ser un número o estar completo.\n";
                if (tbNombre.Text == "")
                {
                    errorString += "No puede dejar el campo nombre vacío.\n";
                }
                if (tbDescripcion.Text == "")
                {
                    errorString += "No puede dejar el campo descripción vacío.\n";
                }
                if (tbEmpresa.Text == "")
                {
                    errorString += "No puede dejar el campo empresa vacío.\n";
                }
                if (listaCar.Count == 0)
                {
                    errorString += "Debe cargar al menos una característica.\n";
                }
                errorString.Remove(errorString.LastIndexOf('\n'));
                MessageBox.Show(errorString, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Se ha producido un error:\n" + ex.ToString()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
