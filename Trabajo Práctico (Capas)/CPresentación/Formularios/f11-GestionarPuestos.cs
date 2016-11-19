using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            Formularios.f13_ModificarPuesto altaPuesto = new Formularios.f13_ModificarPuesto();
            altaPuesto.Show(this);
        }
    }
}
