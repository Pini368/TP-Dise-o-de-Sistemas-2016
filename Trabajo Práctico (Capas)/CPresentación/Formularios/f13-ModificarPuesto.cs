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
                foreach (Puntaje_Requerido car in puestoActual.Puntaje_Requerido.ToList())
                {
                    Puntaje_Requerido pr = new Puntaje_Requerido();
                    pr.codigo_competencia = car.codigo_competencia;
                    pr.ponderacion = car.ponderacion;
                    listaCar.Add(pr);
                    listaCarInic.Add(pr);
                }
                //Llenamos el comboBox de competencias con los nombres de todas las competencias
                List<string> listaNom = new List<string>();
                foreach (var comp in competencias)
                {
                    listaNom.Add(comp.nombre);
                }
                cmbCompetencias.DataSource = listaNom;
                foreach(var car in puestoActual.Puntaje_Requerido.ToList())
                {
                    dgvPuntajesRequeridos.Rows.Add(car.Competencia.nombre, car.ponderacion);
                    excluidos.Add(car.Competencia.nombre);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Se ha producido un error:\n" + ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            List<Competencia> competencias1 = new List<Competencia>();
            //Guardo la competencia seleccionada en una lista de competencias1
            foreach (var item in competencias)
            {
                if (item.nombre == cmbCompetencias.Text)
                {
                    competencias1.Add(item);
                }
            }
            //Si solo selecciono una competencia
            if (competencias1.Count == 1)
            {
                try
                {
                    //Si no esta dentro de las caracteristicas que se deben excluir
                    if (!excluidos.Contains(cmbCompetencias.Text))
                    {
                        try
                        {
                            int ponderacion = Int32.Parse(tbPonderacion.Text);
                            if (ponderacion > 0 && ponderacion <= 10)
                            {
                                Puntaje_Requerido car = new Puntaje_Requerido(competencias1[0], ponderacion);
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
                        catch (Exception)
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
                    MessageBox.Show(("Se ha producido un error:\n" + ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error, no existe o existe más de una competencia con ese nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                bool funcionesMod = false;
                tbCodigo.Text = tbCodigo.Text.Trim(' ');
                tbDescripcion.Text = tbDescripcion.Text.Trim(' ');
                tbEmpresa.Text = tbEmpresa.Text.Trim(' ');
                tbNombre.Text = tbNombre.Text.Trim(' ');
                tbPonderacion.Text = tbPonderacion.Text.Trim(' ');
                int codigo = Int32.Parse(tbCodigo.Text);
                //validarDatosCompletos
                if (tbNombre.Text != "" && tbDescripcion.Text != "" && tbEmpresa.Text != "" && listaCar.Count>0 ) 
                {
                    //Se fija si las funciones fueron modificadas
                    foreach (var carI in listaCarInic)
                    {
                        foreach (var carN in listaCar)
                        {
                            //if ((carI.codigo_competencia == carN.codigo_competencia && carI.ponderacion != carN.ponderacion)
                            if(!carI.Igual(carN))
                            {
                                funcionesMod = true;
                                break;
                            }
                        }
                    }
                    if (listaCarInic.Count() != listaCar.Count())
                    {
                        funcionesMod = true;
                    }

                    if(funcionesMod == true) {
                        GestorDePuestos clogP = new GestorDePuestos();
                        if (clogP.contieneCuestionarios(puestoActual))
                        {
                            MessageBox.Show(("Ya existen cuestionarios generados para el puesto \n"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Owner.Show();
                            this.Close();
                        }
                        else { 
                            Puesto puesto = new Puesto(codigo, tbNombre.Text, tbDescripcion.Text, tbEmpresa.Text, listaCar);
                            GestorDePuestos clog = new GestorDePuestos();
                            clog.modificarCFunc(puesto,puestoActual);
                            limpiarCampos();
                            DialogResult dialogResult = MessageBox.Show("El puesto " + tbNombre.Text + " se ha modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Owner.Show();
                            this.Close();
                        }
                    }
                    if (funcionesMod == false)
                    {
                        puestoActual.nombre = tbNombre.Text;
                        puestoActual.descripcion = tbDescripcion.Text;
                        puestoActual.empresa = tbEmpresa.Text;
                        GestorDePuestos clog = new GestorDePuestos();
                        clog.modificarSFunc(puestoActual);
                        limpiarCampos();
                        DialogResult dialogResult = MessageBox.Show("El puesto " + tbNombre.Text + " se ha modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Owner.Show();
                        this.Close();
                        
                    }
                }
                else
                {
                    //string errorString = "";
                    if (tbNombre.Text == "")
                    {
                        errorProv.SetError(tbNombre, "No puede dejar el campo nombre vacío.");
                        //errorString += "No puede dejar el campo nombre vacío.\n";
                    }
                    else
                    {
                        errorProv.SetError(tbNombre, null);
                    }
                    if (tbDescripcion.Text == "")
                    {
                        errorProv.SetError(tbDescripcion, "No puede dejar el campo descripción vacío.");
                        //errorString += "No puede dejar el campo descripción vacío.\n";
                    }
                    else
                    {
                        errorProv.SetError(tbDescripcion, null);
                    }

                    if (tbEmpresa.Text == "")
                    {
                        errorProv.SetError(tbEmpresa, "No puede dejar el campo empresa vacío.");
                        //errorString += "No puede dejar el campo empresa vacío.\n";
                    }
                    else
                    {
                        errorProv.SetError(tbEmpresa, null);
                    }

                    if (listaCar.Count == 0)
                    {
                        errorProv.SetError(dgvCaracteristicas, "Debe cargar al menos una característica.");
                        //errorString += "Debe cargar al menos una característica.\n";
                    }
                    else
                    {
                        errorProv.SetError(dgvCaracteristicas, null);
                    }
                    //errorString.Remove(errorString.LastIndexOf('\n'));
                    //MessageBox.Show(errorString, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                errorProv.SetError(tbCodigo, "El campo código debe ser un número o estar completo.");
                //string errorString = "El campo código debe ser un número o estar completo.\n";
                if (tbNombre.Text == "")
                {
                    errorProv.SetError(tbNombre, "No puede dejar el campo nombre vacío.");
                    //errorString += "No puede dejar el campo nombre vacío.\n";
                }
                else
                {
                    errorProv.SetError(tbNombre, null);
                }
                if (tbDescripcion.Text == "")
                {
                    errorProv.SetError(tbDescripcion, "No puede dejar el campo descripción vacío.");
                    //errorString += "No puede dejar el campo descripción vacío.\n";
                }
                else
                {
                    errorProv.SetError(tbDescripcion, null);
                }

                if (tbEmpresa.Text == "")
                {
                    errorProv.SetError(tbEmpresa, "No puede dejar el campo empresa vacío.");
                    //errorString += "No puede dejar el campo empresa vacío.\n";
                }
                else
                {
                    errorProv.SetError(tbEmpresa, null);
                }

                if (listaCar.Count == 0)
                {
                    errorProv.SetError(dgvCaracteristicas, "Debe cargar al menos una característica.");
                    //errorString += "Debe cargar al menos una característica.\n";
                }
                else
                {
                    errorProv.SetError(dgvCaracteristicas, null);
                }
                //errorString.Remove(errorString.LastIndexOf('\n'));
                //MessageBox.Show(errorString, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Se ha producido un error:\n" + ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (dgvPuntajesRequeridos.RowCount > 0)
            {

                int indice = dgvPuntajesRequeridos.SelectedRows[0].Index;
                List<Competencia> competencias1 = new List<Competencia>();
                foreach (var item in competencias)
                {
                    if (item.nombre == dgvPuntajesRequeridos.Rows[indice].Cells[0].Value.ToString())
                    {
                        competencias1.Add(item);
                    }
                }
                if (competencias1.Count == 1)
                {
                    try
                    {
                        Puntaje_Requerido car = new Puntaje_Requerido(competencias1[0], Int32.Parse(dgvPuntajesRequeridos.Rows[indice].Cells[1].Value.ToString()));
                        int i = 0;
                        bool encontrado = false;
                        while (i < listaCar.Count() && !encontrado)
                        {
                            if (listaCar[i].Igual(car))
                            {
                                listaCar.RemoveAt(i);
                                encontrado = true;
                            }
                            i++;
                        }
                        encontrado = false;
                        i = 0;
                        while (i < excluidos.Count() && !encontrado)
                        {
                            if (excluidos[i].Equals(dgvPuntajesRequeridos.Rows[indice].Cells[0].Value.ToString()))
                            {
                                excluidos.RemoveAt(i);
                                encontrado = true;
                            }
                            i++;
                        }
                        dgvPuntajesRequeridos.Rows.RemoveAt(dgvPuntajesRequeridos.CurrentRow.Index);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(("Se ha producido un error:\n" + ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error, no existe o existe más de una competencia con ese nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

        private void tbPonderacion_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
