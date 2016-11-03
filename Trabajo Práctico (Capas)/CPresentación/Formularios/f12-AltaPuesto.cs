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
            dgvCaracteristicas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CLogica.Gestores.GestorDeCompetencia clog = new CLogica.Gestores.GestorDeCompetencia();
            try
            {
                competencias = clog.getCompetencias().Tables[0];
                cbCompetencias.DataSource = competencias;
                cbCompetencias.ValueMember = "nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error:\n" + ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Puesto puesto = new Puesto(Int32.Parse(tbCodigo.Text), tbNombre.Text, tbDescripcion.Text, tbEmpresa.Text, listaCar);
            try
            {
                GestorDePuestos clog = new GestorDePuestos();
                clog.alta(puesto);
            }
            catch(Exception ex)
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
                    if (!excluidos.Contains(cbCompetencias.Text)) {
                        Competencia competencia = new Competencia(Int32.Parse(competencias1[0].ItemArray[0].ToString()), competencias1[0].ItemArray[1].ToString(), competencias1[0].ItemArray[2].ToString(), competencias1[0].ItemArray[3].ToString());
                        Caracteristica car = new Caracteristica();
                        car.Competencia = competencia;
                        car.Ponderacion = Int32.Parse(tbPonderacion.Text);
                        listaCar.Add(car);
                        dgvCaracteristicas.Rows.Add(cbCompetencias.Text, tbPonderacion.Text);
                        excluidos.Add(cbCompetencias.Text);
                    }
                    else
                    {
                        MessageBox.Show("Error, usted ya ha cargado esa competencia");
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
                    while(i<listaCar.Count() && !encontrado)
                    {
                        if(listaCar[i].Igual(car))
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
    }
}
