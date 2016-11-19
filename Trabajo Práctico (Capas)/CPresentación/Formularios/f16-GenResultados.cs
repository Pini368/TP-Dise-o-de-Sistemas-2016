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
    public partial class f16_GenResultados : Form
    {
        public f16_GenResultados()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            f17_EmitirRepComparativo eoc = new f17_EmitirRepComparativo();
            eoc.Show(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            f18_EvaluacionesPuesto eP = new f18_EvaluacionesPuesto();
            eP.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void f16_GenResultados_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
