using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_práctico
{
    public partial class f1_Main : Form
    {
        public f1_Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2_RealizarCuestionario realizarCuestionario1 = new f2_RealizarCuestionario();
            realizarCuestionario1.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            f3_IngresoConsultor ingresoConsultor1 = new f3_IngresoConsultor();
            ingresoConsultor1.Show(this);
        }

        private void realizarCuestionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2_RealizarCuestionario realizarCuestionario1 = new f2_RealizarCuestionario();
            realizarCuestionario1.Show();
        }

        private void iniciarSesiónComoConsultorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            f3_IngresoConsultor ingresoConsultor1 = new f3_IngresoConsultor();
            ingresoConsultor1.Show();
        }

        private void cerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void principal_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f17_EmitirRepComparativo eoC = new f17_EmitirRepComparativo();
            eoC.Show(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
