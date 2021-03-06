﻿using System;
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
    public partial class f12_AltaPuesto : Form
    {

        List<Puntaje_Requerido> listaCar = new List<Puntaje_Requerido>();

        List<string> excluidos = new List<string>();

        List<Competencia> competencias = new List<Competencia>();
        public f12_AltaPuesto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void f11_AltaPuesto_Load(object sender, EventArgs e)
        {
            tbNombre.CharacterCasing = CharacterCasing.Upper;
            tbDescripcion.CharacterCasing = CharacterCasing.Upper;
            tbEmpresa.CharacterCasing = CharacterCasing.Upper;
            dgvCaracteristicas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GestorDeCompetencia clogC = new GestorDeCompetencia();
            GestorDePuestos clogP = new GestorDePuestos();
            try
            {
                competencias = clogC.getCompetencias();
                List<string> listaNom = new List<string>();
                foreach(var comp in competencias)
                {
                    listaNom.Add(comp.nombre);
                }
                cbCompetencias.DataSource = listaNom;
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Se ha producido un error:\n" + ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarCampos()
        {
            tbCodigo.Text = "";
            tbNombre.Text = "";
            tbDescripcion.Text = "";
            tbEmpresa.Text = "";
            tbPonderacion.Text = "";
            dgvCaracteristicas.Rows.Clear();
            excluidos.Clear();
            listaCar.Clear();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                tbCodigo.Text = tbCodigo.Text.Trim(' ');
                tbDescripcion.Text = tbDescripcion.Text.Trim(' ');
                tbEmpresa.Text = tbEmpresa.Text.Trim(' ');
                tbNombre.Text = tbNombre.Text.Trim(' ');
                tbPonderacion.Text = tbPonderacion.Text.Trim(' ');
                int codigo = Int32.Parse(tbCodigo.Text);
                if (tbNombre.Text != "" && tbDescripcion.Text != "" && tbEmpresa.Text != "" && listaCar.Count > 0)
                {
                    Puesto puesto = new Puesto(codigo, tbNombre.Text, tbDescripcion.Text, tbEmpresa.Text, listaCar);
                    GestorDePuestos clog = new GestorDePuestos();
                    clog.alta(puesto);
                    DialogResult dialogResult = MessageBox.Show("El puesto " + tbNombre.Text + " se ha creado correctamente ¿Desea cargar otro ?.", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    limpiarCampos();
                    if (dialogResult == DialogResult.No)
                    {
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

        private void btnCargar_Click(object sender, EventArgs e)
        {
            List<Competencia> competencias1 = new List<Competencia>();
            foreach (var item in competencias)
            {
                if (item.nombre == cbCompetencias.Text)
                {
                    competencias1.Add(item);
                }
            }
            if (competencias1.Count == 1)
            {
                try
                {
                    if (!excluidos.Contains(cbCompetencias.Text))
                    {
                        try
                        {
                            int ponderacion = Int32.Parse(tbPonderacion.Text);
                            if (ponderacion > 0 && ponderacion <= 10)
                            {
                                Puntaje_Requerido car = new Puntaje_Requerido(competencias1[0], ponderacion);
                                listaCar.Add(car);
                                dgvCaracteristicas.Rows.Add(cbCompetencias.Text, tbPonderacion.Text);
                                excluidos.Add(cbCompetencias.Text);
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

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if(dgvCaracteristicas.RowCount > 0) { 
            int indice = dgvCaracteristicas.SelectedRows[0].Index;
            List<Competencia> competencias1 = new List<Competencia>();
            foreach (var item in competencias)
            {
                if(item.nombre == dgvCaracteristicas.Rows[indice].Cells[0].Value.ToString())
                {
                    competencias1.Add(item);
                }
            }
            
            if (competencias1.Count == 1)
            {
                try
                {
                    Puntaje_Requerido car = new Puntaje_Requerido(competencias1[0], Int32.Parse(dgvCaracteristicas.Rows[indice].Cells[1].Value.ToString()));
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
                        if (excluidos[i].Equals(dgvCaracteristicas.Rows[indice].Cells[0].Value.ToString()))
                        {
                            excluidos.RemoveAt(i);
                            encontrado = true;
                        }
                        i++;
                    }
                    dgvCaracteristicas.Rows.RemoveAt(dgvCaracteristicas.CurrentRow.Index);
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

        private void cbCompetencias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void f12_AltaPuesto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
