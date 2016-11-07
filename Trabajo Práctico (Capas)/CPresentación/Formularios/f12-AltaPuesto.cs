using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEntidades.Entidades;
using CLogica.Gestores;

namespace Trabajo_práctico
{
    public partial class f11_AltaPuesto : Form
    {
        List<Caracteristica> listaCar = new List<Caracteristica>();
        DataTable competencias;
        List<string> excluidos = new List<string>();
        public f11_AltaPuesto()
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
            try
            {
                competencias = clogC.getCompetencias().Tables[0];
                cbCompetencias.DataSource = competencias;
                cbCompetencias.ValueMember = "nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error:\n" + ex.ToString());
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
                int codigo = Int32.Parse(tbCodigo.Text);
                if (tbNombre.Text != "" && tbDescripcion.Text != "" && tbEmpresa.Text != "" && listaCar.Count > 0)
                {
                    Puesto puesto = new Puesto(codigo, tbNombre.Text, tbDescripcion.Text, tbEmpresa.Text, listaCar);
                    GestorDePuestos clog = new GestorDePuestos();
                    clog.alta(puesto);

                    DialogResult dialogResult =  MessageBox.Show("El puesto " + tbNombre.Text + " se ha creado correctamente ¿Desea cargar otro ?.", "Éxito", MessageBoxButtons.YesNo);
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
                    MessageBox.Show(errorString);
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
                MessageBox.Show(errorString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error:\n" + ex.ToString());
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            DataRow[] competencias1 = competencias.Select("nombre = '" + cbCompetencias.Text + "'");
            if (competencias1.Length == 1)
            {
                try
                {
                    if (!excluidos.Contains(cbCompetencias.Text))
                    {
                        try
                        {
                            Competencia competencia = new Competencia(Int32.Parse(competencias1[0].ItemArray[0].ToString()), competencias1[0].ItemArray[1].ToString(), competencias1[0].ItemArray[2].ToString(), competencias1[0].ItemArray[3].ToString());
                            Caracteristica car = new Caracteristica();
                            car.Competencia = competencia;
                            car.Ponderacion = Int32.Parse(tbPonderacion.Text);
                            if (car.Ponderacion > 0 && car.Ponderacion <= 10)
                            {
                                listaCar.Add(car);
                                dgvCaracteristicas.Rows.Add(cbCompetencias.Text, tbPonderacion.Text);
                                excluidos.Add(cbCompetencias.Text);
                            }
                            else
                            {
                                string errorString = "El campo ponderación debe ser un número entre 0 y 10.";
                                MessageBox.Show(errorString);
                            }
                        }
                        catch (Exception ex)
                        {
                            string errorString = "El campo ponderación debe ser un número o estar completo.";
                            MessageBox.Show(errorString);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error, usted ya ha cargado esa competencia.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error:\n" + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Error, no existe o existe más de una competencia con ese nombre");
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            int indice = dgvCaracteristicas.SelectedRows[0].Index;
            DataRow[] competencias1 = competencias.Select("nombre = '" + dgvCaracteristicas.Rows[indice].Cells[0].Value.ToString() + "'");
            if (competencias1.Length == 1)
            {
                try
                {
                    Competencia competencia = new Competencia(Int32.Parse(competencias1[0].ItemArray[0].ToString()), competencias1[0].ItemArray[1].ToString(), competencias1[0].ItemArray[2].ToString(), competencias1[0].ItemArray[3].ToString());
                    Caracteristica car = new Caracteristica();
                    car.Competencia = competencia;
                    car.Ponderacion = Int32.Parse(tbPonderacion.Text);
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
                    MessageBox.Show("Ha ocurrido un error:\n" + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Error, no existe o existe más de una competencia con ese nombre");
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
    }
}
