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
    public partial class f21_CuestionarioInstrucciones : Form
    {
        public f21_CuestionarioInstrucciones()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            f22Cuestionario cu = new f22Cuestionario();
            cu.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void f21_CuestionarioInstrucciones_Load(object sender, EventArgs e)
        {

        }

        private void f21_CuestionarioInstrucciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
