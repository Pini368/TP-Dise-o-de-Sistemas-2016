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
        public Puesto puestoActual;

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

        private void f13_ModificarPuesto_Load(object sender, EventArgs e)
        {

        }
    }
}
